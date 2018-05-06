﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;

namespace programowanie_TestApp
{
    class Model
    {
        
        public List<Question> Questions = new List<Question>();

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

                writer.WriteElementString("title", "tytuł"); //CHANGE ME

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
    }
}
