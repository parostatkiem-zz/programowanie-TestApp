namespace programowanie_TestApp
{
    partial class ViewCreator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.textBoxTestName = new System.Windows.Forms.TextBox();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonLoadEmpty = new System.Windows.Forms.Button();
            this.buttonSaveAs = new System.Windows.Forms.Button();
            this.buttonSaveAll = new System.Windows.Forms.Button();
            this.listBoxQuestions = new System.Windows.Forms.ListBox();
            this.buttonAddQuestion = new System.Windows.Forms.Button();
            this.labelPytania = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonAddAnswer = new System.Windows.Forms.Button();
            this.groupBoxSettings = new System.Windows.Forms.GroupBox();
            this.buttonRemoveQ = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.checkBoxMultiChoice = new System.Windows.Forms.CheckBox();
            this.labelOdpowiedzi = new System.Windows.Forms.Label();
            this.labelTresc = new System.Windows.Forms.Label();
            this.textBoxQuestionText = new System.Windows.Forms.TextBox();
            this.panelAnswerContainer = new System.Windows.Forms.Panel();
            this.mainErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBoxSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.textBoxTestName);
            this.splitContainer1.Panel1.Controls.Add(this.labelCopyright);
            this.splitContainer1.Panel1.Controls.Add(this.buttonOpen);
            this.splitContainer1.Panel1.Controls.Add(this.buttonLoadEmpty);
            this.splitContainer1.Panel1.Controls.Add(this.buttonSaveAs);
            this.splitContainer1.Panel1.Controls.Add(this.buttonSaveAll);
            this.splitContainer1.Panel1.Controls.Add(this.listBoxQuestions);
            this.splitContainer1.Panel1.Controls.Add(this.buttonAddQuestion);
            this.splitContainer1.Panel1.Controls.Add(this.labelPytania);
            this.splitContainer1.Panel1.Controls.Add(this.labelName);
            this.splitContainer1.Panel1MinSize = 313;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.buttonAddAnswer);
            this.splitContainer1.Panel2.Controls.Add(this.groupBoxSettings);
            this.splitContainer1.Panel2.Controls.Add(this.labelOdpowiedzi);
            this.splitContainer1.Panel2.Controls.Add(this.labelTresc);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxQuestionText);
            this.splitContainer1.Panel2.Controls.Add(this.panelAnswerContainer);
            this.splitContainer1.Panel2MinSize = 440;
            this.splitContainer1.Size = new System.Drawing.Size(1001, 520);
            this.splitContainer1.SplitterDistance = 313;
            this.splitContainer1.TabIndex = 0;
            // 
            // textBoxTestName
            // 
            this.textBoxTestName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTestName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxTestName.Location = new System.Drawing.Point(49, 438);
            this.textBoxTestName.Name = "textBoxTestName";
            this.textBoxTestName.Size = new System.Drawing.Size(238, 20);
            this.textBoxTestName.TabIndex = 13;
            // 
            // labelCopyright
            // 
            this.labelCopyright.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCopyright.AutoSize = true;
            this.labelCopyright.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.labelCopyright.Location = new System.Drawing.Point(198, 497);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(108, 13);
            this.labelCopyright.TabIndex = 12;
            this.labelCopyright.Text = "© Jan Sudczak 2018";
            // 
            // buttonOpen
            // 
            this.buttonOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpen.Location = new System.Drawing.Point(95, 492);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(97, 23);
            this.buttonOpen.TabIndex = 11;
            this.buttonOpen.Text = "Otwórz...";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonLoadEmpty
            // 
            this.buttonLoadEmpty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLoadEmpty.Location = new System.Drawing.Point(3, 492);
            this.buttonLoadEmpty.Name = "buttonLoadEmpty";
            this.buttonLoadEmpty.Size = new System.Drawing.Size(86, 23);
            this.buttonLoadEmpty.TabIndex = 10;
            this.buttonLoadEmpty.Text = "Nowy test";
            this.buttonLoadEmpty.UseVisualStyleBackColor = true;
            this.buttonLoadEmpty.Click += new System.EventHandler(this.buttonLoadEmpty_Click);
            // 
            // buttonSaveAs
            // 
            this.buttonSaveAs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveAs.Location = new System.Drawing.Point(198, 463);
            this.buttonSaveAs.Name = "buttonSaveAs";
            this.buttonSaveAs.Size = new System.Drawing.Size(110, 23);
            this.buttonSaveAs.TabIndex = 9;
            this.buttonSaveAs.Text = "Zapisz jako...";
            this.buttonSaveAs.UseVisualStyleBackColor = true;
            this.buttonSaveAs.Click += new System.EventHandler(this.buttonSaveAs_Click);
            // 
            // buttonSaveAll
            // 
            this.buttonSaveAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveAll.Location = new System.Drawing.Point(3, 463);
            this.buttonSaveAll.Name = "buttonSaveAll";
            this.buttonSaveAll.Size = new System.Drawing.Size(189, 23);
            this.buttonSaveAll.TabIndex = 8;
            this.buttonSaveAll.Text = "Zapisz";
            this.buttonSaveAll.UseVisualStyleBackColor = true;
            this.buttonSaveAll.Click += new System.EventHandler(this.buttonSaveAll_Click);
            // 
            // listBoxQuestions
            // 
            this.listBoxQuestions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxQuestions.FormattingEnabled = true;
            this.listBoxQuestions.ItemHeight = 16;
            this.listBoxQuestions.Items.AddRange(new object[] {
            "Pytanie 1",
            "Pytanie 2"});
            this.listBoxQuestions.Location = new System.Drawing.Point(3, 25);
            this.listBoxQuestions.Name = "listBoxQuestions";
            this.listBoxQuestions.Size = new System.Drawing.Size(305, 404);
            this.listBoxQuestions.TabIndex = 7;
            this.listBoxQuestions.SelectedIndexChanged += new System.EventHandler(this.listViewQuestions_SelectedIndexChanged);
            // 
            // buttonAddQuestion
            // 
            this.buttonAddQuestion.BackgroundImage = global::programowanie_TestApp.Properties.Resources.if_sign_add_299068;
            this.buttonAddQuestion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAddQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddQuestion.Location = new System.Drawing.Point(3, 1);
            this.buttonAddQuestion.Name = "buttonAddQuestion";
            this.buttonAddQuestion.Size = new System.Drawing.Size(23, 23);
            this.buttonAddQuestion.TabIndex = 6;
            this.buttonAddQuestion.UseVisualStyleBackColor = true;
            this.buttonAddQuestion.Click += new System.EventHandler(this.buttonAddQuestion_Click);
            // 
            // labelPytania
            // 
            this.labelPytania.AutoSize = true;
            this.labelPytania.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPytania.Location = new System.Drawing.Point(33, 4);
            this.labelPytania.Name = "labelPytania";
            this.labelPytania.Size = new System.Drawing.Size(62, 17);
            this.labelPytania.TabIndex = 1;
            this.labelPytania.Text = "Pytania";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelName.Location = new System.Drawing.Point(3, 441);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(53, 13);
            this.labelName.TabIndex = 14;
            this.labelName.Text = "Nazwa: ";
            // 
            // buttonAddAnswer
            // 
            this.buttonAddAnswer.BackgroundImage = global::programowanie_TestApp.Properties.Resources.if_sign_add_299068;
            this.buttonAddAnswer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAddAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddAnswer.Location = new System.Drawing.Point(4, 115);
            this.buttonAddAnswer.Name = "buttonAddAnswer";
            this.buttonAddAnswer.Size = new System.Drawing.Size(23, 23);
            this.buttonAddAnswer.TabIndex = 5;
            this.buttonAddAnswer.UseVisualStyleBackColor = true;
            this.buttonAddAnswer.Click += new System.EventHandler(this.buttonAddAnswer_Click);
            // 
            // groupBoxSettings
            // 
            this.groupBoxSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSettings.Controls.Add(this.buttonRemoveQ);
            this.groupBoxSettings.Controls.Add(this.buttonSave);
            this.groupBoxSettings.Controls.Add(this.checkBoxMultiChoice);
            this.groupBoxSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxSettings.Location = new System.Drawing.Point(497, 4);
            this.groupBoxSettings.Name = "groupBoxSettings";
            this.groupBoxSettings.Size = new System.Drawing.Size(182, 122);
            this.groupBoxSettings.TabIndex = 5;
            this.groupBoxSettings.TabStop = false;
            this.groupBoxSettings.Text = "Ustawienia pytania";
            // 
            // buttonRemoveQ
            // 
            this.buttonRemoveQ.BackColor = System.Drawing.Color.Tomato;
            this.buttonRemoveQ.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRemoveQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRemoveQ.Location = new System.Drawing.Point(6, 49);
            this.buttonRemoveQ.Name = "buttonRemoveQ";
            this.buttonRemoveQ.Size = new System.Drawing.Size(170, 28);
            this.buttonRemoveQ.TabIndex = 7;
            this.buttonRemoveQ.Text = "Usuń pytanie";
            this.buttonRemoveQ.UseVisualStyleBackColor = false;
            this.buttonRemoveQ.Click += new System.EventHandler(this.buttonRemoveQ_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.LightGreen;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSave.Location = new System.Drawing.Point(6, 88);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(170, 28);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Zapisz zmiany";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // checkBoxMultiChoice
            // 
            this.checkBoxMultiChoice.AutoSize = true;
            this.checkBoxMultiChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxMultiChoice.Location = new System.Drawing.Point(6, 22);
            this.checkBoxMultiChoice.Name = "checkBoxMultiChoice";
            this.checkBoxMultiChoice.Size = new System.Drawing.Size(170, 17);
            this.checkBoxMultiChoice.TabIndex = 4;
            this.checkBoxMultiChoice.Text = "Wiele poprawnych odpowiedzi";
            this.checkBoxMultiChoice.UseVisualStyleBackColor = true;
            this.checkBoxMultiChoice.CheckedChanged += new System.EventHandler(this.checkBoxMultiChoice_CheckedChanged);
            // 
            // labelOdpowiedzi
            // 
            this.labelOdpowiedzi.AutoSize = true;
            this.labelOdpowiedzi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOdpowiedzi.Location = new System.Drawing.Point(28, 120);
            this.labelOdpowiedzi.Name = "labelOdpowiedzi";
            this.labelOdpowiedzi.Size = new System.Drawing.Size(81, 17);
            this.labelOdpowiedzi.TabIndex = 3;
            this.labelOdpowiedzi.Text = "Odpowiedzi";
            // 
            // labelTresc
            // 
            this.labelTresc.AutoSize = true;
            this.labelTresc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTresc.Location = new System.Drawing.Point(28, 4);
            this.labelTresc.Name = "labelTresc";
            this.labelTresc.Size = new System.Drawing.Size(94, 17);
            this.labelTresc.TabIndex = 2;
            this.labelTresc.Text = "Treśc pytania";
            // 
            // textBoxQuestionText
            // 
            this.textBoxQuestionText.AcceptsReturn = true;
            this.textBoxQuestionText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxQuestionText.Location = new System.Drawing.Point(2, 25);
            this.textBoxQuestionText.Multiline = true;
            this.textBoxQuestionText.Name = "textBoxQuestionText";
            this.textBoxQuestionText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxQuestionText.Size = new System.Drawing.Size(477, 85);
            this.textBoxQuestionText.TabIndex = 0;
            // 
            // panelAnswerContainer
            // 
            this.panelAnswerContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAnswerContainer.AutoScroll = true;
            this.panelAnswerContainer.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelAnswerContainer.Location = new System.Drawing.Point(2, 140);
            this.panelAnswerContainer.Name = "panelAnswerContainer";
            this.panelAnswerContainer.Size = new System.Drawing.Size(677, 375);
            this.panelAnswerContainer.TabIndex = 0;
            // 
            // mainErrorProvider
            // 
            this.mainErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.mainErrorProvider.ContainerControl = this;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.CreatePrompt = true;
            this.saveFileDialog.DefaultExt = "xml";
            this.saveFileDialog.Filter = "XML|*.xml";
            this.saveFileDialog.Title = "Wybierz miejsce zapisania pliku";
            this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog_FileOk);
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "xml";
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "XML|*.xml";
            this.openFileDialog.Title = "Wybierz plik";
            // 
            // ViewCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 520);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(815, 294);
            this.Name = "ViewCreator";
            this.Text = "Generator testów";
            this.Load += new System.EventHandler(this.View1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBoxSettings.ResumeLayout(false);
            this.groupBoxSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panelAnswerContainer;
        private System.Windows.Forms.Label labelPytania;
        private System.Windows.Forms.Label labelOdpowiedzi;
        private System.Windows.Forms.Label labelTresc;
        private System.Windows.Forms.TextBox textBoxQuestionText;
        private System.Windows.Forms.GroupBox groupBoxSettings;
        private System.Windows.Forms.CheckBox checkBoxMultiChoice;
        private System.Windows.Forms.Button buttonAddAnswer;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonAddQuestion;
        private System.Windows.Forms.Button buttonRemoveQ;
        private System.Windows.Forms.ErrorProvider mainErrorProvider;
        private System.Windows.Forms.ListBox listBoxQuestions;
        private System.Windows.Forms.Label labelCopyright;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonLoadEmpty;
        private System.Windows.Forms.Button buttonSaveAs;
        private System.Windows.Forms.Button buttonSaveAll;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.TextBox textBoxTestName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

