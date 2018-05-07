using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace programowanie_TestApp
{
    class Model
    {
        
        public List<Question> Questions = new List<Question>();
        public Test theTest = new Test();

        public Model()
        {
            Questions.Add(new Question("Test pytanie 1"));
            Questions.Add(new Question("Test pytanie 2 sdas dasdas dasdasdasds dsgsadgfasgfsg dfsgfs  dgfsdgsds dfshdfghdfsgdsgfdasg"));
            Questions.Add(new Question("Test pytanie 3"));
            Questions.Add(new Question("Test pytanie 4"));

        }


        public bool UpdateSingleQuestion(int index, Question target)
        {
            try
            {
                Questions[index] = target;
            }
            catch { return false; }
            return true;
        }

        public bool RemoveAnswerFrom(Question q,Answer a)
        {
            try
            {
                Question source =  Questions[Questions.IndexOf(q)];
             //   source.Answers.Remove(a);
                Answer target = source.Answers.Where(ans => ans.Text == a.Text && ans.IsRight==a.IsRight).FirstOrDefault();
                source.Answers.Remove(target);
                //source.Answers.Remove(a);
            }
            catch { return false; }
            return true;
        }
        public bool RemoveQuestion(Question q)
        {
            try
            {
                if (Questions.Count <= 1)
                    return false; //próba usunięcia ostatniego pytania
                Questions.Remove(q);
            }
            catch { return false; }
            return true;
        }
        public bool AddEmptyQuestion()
        {
            try
            {
                Questions.Add(new Question(true));
            }
            catch { return false; }
            return true;
        }

        public void LoadEmptySet()
        {
            theTest.Name = "";
            Questions.Clear();
        }

        public bool SaveToXML(string path)
        {
            try
            {
                using (XmlWriter writer = XmlWriter.Create(path))
                {
                writer.WriteStartDocument();
                writer.WriteStartElement("test");

                writer.WriteElementString("title", theTest.Name); 

                    writer.WriteStartElement("questions");
                        foreach (Question q in Questions)
                        {
                        writer.WriteStartElement("question");
                        writer.WriteAttributeString("multiChoice",q.IsMultipleChoice.ToString());
                            writer.WriteElementString("text", q.Text); 
                            foreach(Answer a in q.Answers)
                            {
                            writer.WriteStartElement("answer");
                                writer.WriteAttributeString("right", a.IsRight.ToString());
                                writer.WriteElementString("text", a.Text);
                            writer.WriteEndElement();

                            }
                         writer.WriteEndElement();
                        }

                   writer.WriteEndElement(); //questions
                writer.WriteEndElement(); //test
                writer.WriteEndDocument();
                }
            }
            catch { return false; }
            return true;
        }
        public bool LoadFromXML(string path)
        {
            try
            {

                var doc = XDocument.Load(path);
                theTest.Name=doc.Element("test").Element("title").Value;
              
                var questions = from q in doc.Element("test").Descendants("question")
                                select new
                                {
                                    text = q.Element("text").Value,
                                    
                                    answers = from a in q.Descendants("answer")
                                              select new
                                              {
                                                  right = a.Attribute("right"),
                                                  text= a.Element("text").Value
                                              },
                                    multiChoice = q.Attribute("multiChoice") 
                             };

                Questions.Clear();
                Question tmpQ;
                Answer tmpA;
                foreach (var q in questions)
                {
                    tmpQ = new Question(false);
                    tmpQ.IsMultipleChoice = (bool)q.multiChoice;
                    tmpQ.Text = q.text;  
                    foreach(var a in q.answers)
                    {
                        tmpA = new Answer();
                        tmpA.IsRight = (bool)a.right;
                        tmpA.Text = a.text;
                        tmpQ.Answers.Add(tmpA);

                    }
                    Questions.Add(tmpQ);        
                }  
            }
            catch { return false; }
            return true;
        }

        public bool ValidateAllQuestions()
        {
            bool isValid = true;
            if (Questions.Count <= 0) return false;
            foreach (Question theQuestion in Questions)
            { 

                int rightAnswers = 0;
                foreach (Answer answ in theQuestion.Answers)
                {
                    if (answ.IsRight) rightAnswers++;
                    if (answ.Text.Length <= 0) isValid = false;
                }

                if (rightAnswers == 0)
                {
                    isValid = false;
                }
                if (!theQuestion.IsMultipleChoice && rightAnswers > 1)
                {
                    isValid = false;
                }

                if (theQuestion.Text.Length<=0 && theQuestion.Text==Question.DefaultText)
                {
                    isValid = false;
                }
            }
            return isValid;
        }
    }
}
