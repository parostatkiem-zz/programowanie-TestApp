using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace programowanie_TestApp
{
    public partial class ViewCreator : Form,ICreator
    {
        public ViewCreator()
        {
            InitializeComponent();
        }

        public event Func<List<Question>> LoadQuestions;
        public event Func<int,Question> LoadSingleQuestion;
        public event Action<int,Question> UpdateSingleQuestion;
        public event Action<Question, Answer> RemoveAnswer;
        public event Action<bool> AddQuestion;


        public void RefreshData(List<Question> questions)
        {
            listViewQuestions.Items.Clear();

            foreach (Question q in questions)
                listViewQuestions.Items.Add(q.ToString());
        }

        public void ShowError(string message)
        {
            MessageBox.Show(message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //TODO: można zmienić na coś bardziej ambitnego
        }


        private void View1_Load(object sender, EventArgs e)
        {
            RefreshData(LoadQuestions());
        }

        private void listViewQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {   if (CurrentlySelectedQuestionIndex == -1) return;
            DisplayQuestion(LoadSingleQuestion(CurrentlySelectedQuestionIndex));
        }

        private void DisplayQuestion(Question q)
        {
            textBoxQuestionText.Text = q.Text;

            checkBoxMultiChoice.Checked = q.IsMultipleChoice;

            panelAnswerContainer.Controls.Clear();
            foreach(Answer a in q.Answers)
            {
                var singleAnswer = new SingleAnswerControl(a.Text,a.IsRight);
                singleAnswer.Top = singleAnswer.Height * q.Answers.IndexOf(a);
                singleAnswer.RemoveAnswer += SingleAnswer_RemoveAnswer;
                panelAnswerContainer.Controls.Add(singleAnswer);
            }
            try { panelAnswerContainer.ScrollControlIntoView(panelAnswerContainer.Controls[panelAnswerContainer.Controls.Count - 1]); } catch { }

        }

        private void SingleAnswer_RemoveAnswer(Answer obj)
        {
            if (CurrentlySelectedQuestionIndex == -1) return;

            RemoveAnswer(GetCurrentQuestion(), obj);

            DisplayQuestion(LoadSingleQuestion(CurrentlySelectedQuestionIndex));
        }

        private int CurrentlySelectedQuestionIndex
        {
            get
            { 
                if (listViewQuestions.SelectedItems == null) return -1;
                ListView.SelectedIndexCollection indices = listViewQuestions.SelectedIndices;

                if (indices.Count <= 0) return -1;
                return indices[0];
                
            }
        }

        private void buttonAddAnswer_Click(object sender, EventArgs e)
        {
            Question currentQuestion = GetCurrentQuestion();
            if (currentQuestion == null) return;
            currentQuestion.Answers.Add(new Answer());
            UpdateSingleQuestion(CurrentlySelectedQuestionIndex, currentQuestion);
            DisplayQuestion(LoadSingleQuestion(CurrentlySelectedQuestionIndex));
        }

        private void checkBoxMultiChoice_CheckedChanged(object sender, EventArgs e)
        {
            Question currentQuestion = GetCurrentQuestion();
            if (currentQuestion == null) return;
            currentQuestion.IsMultipleChoice = checkBoxMultiChoice.Checked;
            UpdateSingleQuestion(CurrentlySelectedQuestionIndex, currentQuestion);
            DisplayQuestion(LoadSingleQuestion(CurrentlySelectedQuestionIndex));
        }

        private Question GetCurrentQuestion()
        {
            if (CurrentlySelectedQuestionIndex == -1) return null;
            Question q = LoadSingleQuestion(CurrentlySelectedQuestionIndex);
            if (q == null) return null;
            return q;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Question currentQuestion = GetCurrentQuestion();
            if (currentQuestion == null) return;

            currentQuestion.IsMultipleChoice = checkBoxMultiChoice.Checked;
            currentQuestion.Text = textBoxQuestionText.Text;

            //dodać zapisywanie odpowiedzi

            currentQuestion.Answers.Clear();
            foreach(SingleAnswerControl s in panelAnswerContainer.Controls)
            {
                currentQuestion.Answers.Add(new Answer(s.TypedText, s.IsRight));
            }

            UpdateSingleQuestion(CurrentlySelectedQuestionIndex, currentQuestion);
            DisplayQuestion(LoadSingleQuestion(CurrentlySelectedQuestionIndex));
        }

        private void buttonAddQuestion_Click(object sender, EventArgs e)
        {
            AddQuestion(true);
            RefreshData(LoadQuestions());
        }
    }
}
