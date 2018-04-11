using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
    }
}
