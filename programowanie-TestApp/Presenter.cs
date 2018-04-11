using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programowanie_TestApp
{
    class Presenter
    {
        ICreator view;
        Model model;
        public Presenter(Model model, ICreator view)
        {
            this.model = model;
            this.view = view;

            view.LoadQuestions += View_LoadQuestions;
            view.LoadSingleQuestion += View_LoadSingleQuestion;
        }

        private Question View_LoadSingleQuestion(int arg)
        {
            return model.Questions[arg];
        }

        private List<Question> View_LoadQuestions()
        {
            return model.Questions;
        }
    }
}
