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
        {   if (CurrentlySelectedQuestion == -1) return;
            DisplayQuestion(LoadSingleQuestion(CurrentlySelectedQuestion));
        }

        private void DisplayQuestion(Question q)
        {
            textBoxQuestionText.Text = q.Text;

            if (q.IsMultipleChoice)
                checkBoxMultiChoice.Checked = true;

            panelAnswerContainer.Controls.Clear();
            foreach(Answer a in q.Answers)
            {
                var singleAnswer = new SingleAnswer();
                singleAnswer.Top = singleAnswer.Height * q.Answers.IndexOf(a);
                panelAnswerContainer.Controls.Add(singleAnswer);
            }


        }

        private int CurrentlySelectedQuestion
        {
            get
            { 
                if (listViewQuestions.SelectedItems == null) return -1;
                ListView.SelectedIndexCollection indices = listViewQuestions.SelectedIndices;

                if (indices.Count <= 0) return -1;
                return indices[0];
                
            }
        }

        private void buttonAddQuestion_Click(object sender, EventArgs e)
        {
            
            Question currentQuestion = LoadSingleQuestion(CurrentlySelectedQuestion);
            if (currentQuestion == null) return;
            currentQuestion.Answers.Add(new Answer());
            UpdateSingleQuestion(CurrentlySelectedQuestion, currentQuestion);
            DisplayQuestion(LoadSingleQuestion(CurrentlySelectedQuestion));


        }
    }
}
