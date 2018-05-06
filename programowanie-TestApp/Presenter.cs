﻿using System;
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
            view.UpdateSingleQuestion += View_UpdateSingleQuestion;
            view.RemoveAnswer += View_RemoveAnswer;
            view.AddQuestion += View_AddQuestion;
            view.RemoveQuestion += View_RemoveQuestion;
            view.LoadEmptySet += View_LoadEmptySet;
            view.SaveSet += View_SaveSet;
        }

        private void View_SaveSet(string path)
        {
            if (!model.SaveToXML(path)) view.ShowError("Nie udało się zapisać pliku.\nCzy na pewno masz uprawnienia do zapisu w tym miejscu?\n"+path);
        }

        private void View_LoadEmptySet(bool obj)
        {
            model.LoadEmptySet();
        }

        private void View_RemoveQuestion(Question obj)
        {
            if (!model.RemoveQuestion(obj)) view.ShowError("Nie udało się usunąć pytania.\nPamiętaj, że lista pytań nie może być pusta!");
        }

        private void View_AddQuestion(bool obj)
        {
            if (!model.AddEmptyQuestion()) view.ShowError("Wystąpił problem przy dodawaniu pytania");

        }

        private void View_RemoveAnswer(Question arg1, Answer arg2)
        {
            if (!model.RemoveAnswerFrom(arg1,arg2)) view.ShowError("Wystąpił problem przy usuwaniu odpowiedzi");
        }

        private void View_UpdateSingleQuestion(int index, Question target)
        {
            if (!model.UpdateSingleQuestion(index, target)) view.ShowError("Wystąpił problem przy zmianie pytania" );
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
