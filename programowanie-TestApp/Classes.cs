using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programowanie_TestApp
{
    class Question
    {
        public List<Answer> Answers = new List<Answer>(); 
        public bool IsMultipleChoice { get; set; }

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
    }

    class Answer
    {
        public bool IsRight { get; set; }
        public string Text { get; set; }

        private string text = "";
    }
}
