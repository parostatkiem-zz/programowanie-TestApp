using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programowanie_TestApp
{
    interface ICreator
    {
        event Func<List<Question>> LoadQuestions;
        event Func<int, Question> LoadSingleQuestion;

        event Action<int,Question> UpdateSingleQuestion;
        event Action<Question, Answer> RemoveAnswer;
        event Action<bool> AddQuestion;
        event Action<Question> RemoveQuestion;

        event Action<bool> LoadEmptySet;

        void ShowError(string message);
        void ShowError(string title, string message);
        bool ShowConfirmation(string message);



    }
}
