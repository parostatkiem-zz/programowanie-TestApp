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




        public void RefreshData(List<Question> questions)
        {
            listViewQuestions.Items.Clear();

            foreach (Question q in questions)
                listViewQuestions.Items.Add(q.ToString());
        }

        private void View1_Load(object sender, EventArgs e)
        {
            RefreshData(LoadQuestions());
        }

        private void listViewQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewQuestions.SelectedItems == null) return;
            ListView.SelectedIndexCollection indices = listViewQuestions.SelectedIndices;
            
            if (indices.Count <= 0) return;
            int selectedIndex = indices[0];
            DisplayQuestion(LoadSingleQuestion(selectedIndex));
        }

        private void DisplayQuestion(Question q)
        {
            textBoxQuestionText.Text = q.Text;

            panelAnswerContainer.Controls.Clear();
            foreach(Answer a in q.Answers)
            {
                var singleAnswer = new SingleAnswer();
                singleAnswer.Top = singleAnswer.Height * q.Answers.IndexOf(a);
                panelAnswerContainer.Controls.Add(singleAnswer);
            }
        }
    }
}
