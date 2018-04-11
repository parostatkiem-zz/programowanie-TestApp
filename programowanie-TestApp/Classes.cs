using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programowanie_TestApp
{
    public class Question
    {
        public List<Answer> Answers = new List<Answer>(); 
        public bool IsMultipleChoice { get; set; }
        public string Text { get; set; }

      

        public int AnswersCount
        {
            get
            {
                return Answers.Count;
            }
                
        }

        public int RightAnswersCount
        {
            get
            {
                int count = 0;
                foreach(Answer a in Answers)
                {
                    if (a.IsRight) count++;
                }
                return count;
            }
        }

        public Question(string text="",bool isMultiChoice=false)
        {
            //konstruktor
            IsMultipleChoice = isMultiChoice;
            Text = text;
            for(int i=0;i<DefaultNumberOfAnswers;i++)
            {
                Answers.Add(new Answer());
            }
        }

        public override string ToString()
        {
            return Text;
        }

        private const int DefaultNumberOfAnswers = 4;
        private string text = "";

    }

    public class Answer
    {
        public bool IsRight { get; set; }
        public string Text { get; set; }

        public override string ToString()
        {
            return Text;
        }

        private string text = "";
    }
}
