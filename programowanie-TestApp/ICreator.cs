﻿using System;
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

        void ShowError(string message);
    }
}
