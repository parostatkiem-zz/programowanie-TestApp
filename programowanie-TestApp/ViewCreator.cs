using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace programowanie_TestApp
{
    public partial class ViewCreator : Form,ICreator
    {

        #region PUBLIC
        public ViewCreator()
        {
            InitializeComponent();
        }

        public event Func<List<Question>> LoadQuestions;
        public event Func<int, Question> LoadSingleQuestion;
        public event Action<int, Question> UpdateSingleQuestion;
        public event Action<Question, Answer> RemoveAnswer;
        public event Action<bool> AddQuestion;
        public event Action<Question> RemoveQuestion;
        public event Action<bool> LoadEmptySet;
        public event Action<string> LoadSet;
        public event Action<string> SaveSet;
        public void RefreshData(List<Question> questions, int selectedIndex = 0)
        {
            listBoxQuestions.Items.Clear();

            foreach (Question q in questions)
                listBoxQuestions.Items.Add(q.ToString());
            DisplayQuestion(null);
            CurrentlySelectedQuestionIndex = selectedIndex;

        }

        public void ShowError(string message)
        {
            MessageBox.Show(message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //TODO: można zmienić na coś bardziej ambitnego
        }
        public void ShowError(string title, string message)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //TODO: można zmienić na coś bardziej ambitnego
        }

        public bool ShowConfirmation(string message)
        {
            if (MessageBox.Show(message, "Potwierdź", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                return true;
            return false;
            //TODO: można zmienić na coś bardziej ambitnego
        }


        #endregion

        #region GeneratedEvents

        private void View1_Load(object sender, EventArgs e)
        {
            RefreshData(LoadQuestions());
        }

        private void listViewQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CurrentlySelectedQuestionIndex == -1) return;

            DisplayQuestion(LoadSingleQuestion(CurrentlySelectedQuestionIndex));                   
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
        private void buttonSave_Click(object sender, EventArgs e)
        {

            Question currentQuestion = GetCurrentQuestion();
            if (currentQuestion == null) return;



            currentQuestion.IsMultipleChoice = checkBoxMultiChoice.Checked;
            currentQuestion.Text = textBoxQuestionText.Text;

            //dodać zapisywanie odpowiedzi

            currentQuestion.Answers.Clear();
            foreach (SingleAnswerControl s in panelAnswerContainer.Controls)
            {
                currentQuestion.Answers.Add(new Answer(s.TypedText, s.IsRight));
            }

            UpdateSingleQuestion(CurrentlySelectedQuestionIndex, currentQuestion);
            if (!ValidateSingleQuestion(GetCurrentQuestion()))
            {
                ShowError("Ups, chyba nie wszystkie dane są poprawne", "Najedź kursorem na czerwone wykrzykniki, przeczytaj o co chodzi i spróbuj zlikwidować problem");
                return;
            }
            RefreshData(LoadQuestions(), CurrentlySelectedQuestionIndex);




            // DisplayQuestion(LoadSingleQuestion(CurrentlySelectedQuestionIndex));
        }

        private void buttonAddQuestion_Click(object sender, EventArgs e)
        {
            AddQuestion(true);
            RefreshData(LoadQuestions());
        }

        private void buttonRemoveQ_Click(object sender, EventArgs e)
        {
            Question currentQuestion = GetCurrentQuestion();
            if (currentQuestion == null) return;

            RemoveQuestion(currentQuestion);
            RefreshData(LoadQuestions());
            try
            {
                //listViewQuestions.Items[0].Selected = true;
                listBoxQuestions.SelectedItem = listBoxQuestions.Items[0];
                listBoxQuestions.Select();
            }
            catch { }
        }

        #endregion

        #region PRIVATE
        private FileInfo currentFile;
        private FileInfo CurrentFile
        {
            get { return currentFile; }
            set
            {
                if (value == null) return;
                currentFile = value;
                buttonSaveAll.Text = "Zapisz " + currentFile.Name;
             //   buttonSave.Refresh();
            }
        }

        private bool anyQuestionLoaded = false;

        private void DisplayQuestion(Question q)
        {
            anyQuestionLoaded = true;
            if (q==null)
            {
                anyQuestionLoaded = false;
                q = new Question(false);
            }
            
            mainErrorProvider.Clear();
            textBoxQuestionText.Text = q.Text;

            checkBoxMultiChoice.Checked = q.IsMultipleChoice;

            panelAnswerContainer.Controls.Clear();
            foreach(Answer a in q.Answers)
            {
                var singleAnswer = new SingleAnswerControl(a.Text,a.IsRight);
                singleAnswer.Top = singleAnswer.Height * q.Answers.IndexOf(a);
                singleAnswer.Width = panelAnswerContainer.Width - 10;
                singleAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)(((AnchorStyles.Left | AnchorStyles.Right |AnchorStyles.Top))));
                singleAnswer.RemoveAnswer += SingleAnswer_RemoveAnswer;
                panelAnswerContainer.Controls.Add(singleAnswer);
            }
            try { panelAnswerContainer.ScrollControlIntoView(panelAnswerContainer.Controls[panelAnswerContainer.Controls.Count - 1]); } catch { }
            if (anyQuestionLoaded && !ValidateSingleQuestion(GetCurrentQuestion())) return;
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
                if (listBoxQuestions.SelectedItems == null) return -1;
                ListBox.SelectedIndexCollection indices = listBoxQuestions.SelectedIndices;

                if (indices.Count <= 0) return -1;
                return indices[0];  
            }
            set
            {
                try
                {
                    listBoxQuestions.SelectedItem = listBoxQuestions.Items[value];
                   // listViewQuestions.Items[value].Selected = true;
                    listBoxQuestions.Select();
                }
                catch { }
            }
        }

       
        private Question GetCurrentQuestion()
        {
            if (CurrentlySelectedQuestionIndex == -1) return null;
            Question q = LoadSingleQuestion(CurrentlySelectedQuestionIndex);
            if (q == null) return null;
            return q;
        }

        
        private bool ValidateSingleQuestion(Question theQuestion)
        {
            //  Question theQuestion = GetCurrentQuestion();
            mainErrorProvider.Clear();
            if (theQuestion == null) return true;

            bool isValid = true;

            int rightAnswers = 0;
            foreach(Answer answ in theQuestion.Answers)
            {
                if (answ.IsRight) rightAnswers++;
            }

            if (rightAnswers == 0)
            {
                mainErrorProvider.SetError(labelOdpowiedzi, "Przynajmniej jedna odpowiedź musi być poprawna");
                isValid = false;
            }
            if (!theQuestion.IsMultipleChoice && rightAnswers>1)
            { 
                mainErrorProvider.SetError(labelOdpowiedzi, "Tylko jedna odpowiedź może być poprawna");
                isValid = false;
            }

            if(textBoxQuestionText.Text.Length<=0)
            {

                mainErrorProvider.SetError(textBoxQuestionText, "To pole nie może być puste");
                isValid = false;
            }

            if (textBoxQuestionText.Text==Question.DefaultText)
            {

                mainErrorProvider.SetError(textBoxQuestionText, "Hmm.. ktoś chyba zapomniał tu coś wpisać");
                isValid = false;
            }


            foreach (Control c in panelAnswerContainer.Controls)
            {
                if (!(c is SingleAnswerControl)) continue;
                SingleAnswerControl a = c as SingleAnswerControl;
                if (!a.ValidateControl()) isValid = false;
                
            }
            return isValid;
        }
        #endregion

        private void buttonLoadEmpty_Click(object sender, EventArgs e)
        {
            if (!ShowConfirmation("Czy na pewno chcesz załadować nowy, pusty test?\nWszystkie niezapisane postępy zostaną utracone!")) return;
            LoadEmptySet(true);
            RefreshData(LoadQuestions());

        }

        private void buttonSaveAll_Click(object sender, EventArgs e)
        {
            if (CurrentFile == null)
                buttonSaveAs.PerformClick();
            if (CurrentFile == null) return;

            SaveSet(CurrentFile.FullName);



        }

        private void buttonSaveAs_Click(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName==null || saveFileDialog.FileName == "") return;
            CurrentFile = new FileInfo(saveFileDialog.FileName);
            buttonSaveAll.PerformClick();
        }

        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            if (!saveFileDialog.FileName.EndsWith(".xml"))
            {
                ShowError("Wskazany plik MUSI mieć rozszerzenie '.xml'!\nSpróbuj jeszcze raz...");
                 e.Cancel = true;
                return; 
            }
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            if (openFileDialog.FileName == null || openFileDialog.FileName == "") return;
            CurrentFile = new FileInfo(openFileDialog.FileName);
            LoadSet(CurrentFile.FullName);
            RefreshData(LoadQuestions());

        }
    }
}
