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
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem("");
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.labelPytania = new System.Windows.Forms.Label();
            this.listViewQuestions = new System.Windows.Forms.ListView();
            this.labelOdpowiedzi = new System.Windows.Forms.Label();
            this.labelTresc = new System.Windows.Forms.Label();
            this.textBoxQuestionText = new System.Windows.Forms.TextBox();
            this.panelAnswerContainer = new System.Windows.Forms.Panel();
            this.checkBoxMultiChoice = new System.Windows.Forms.CheckBox();
            this.groupBoxSettings = new System.Windows.Forms.GroupBox();
            this.buttonAddQuestion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBoxSettings.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.labelPytania);
            this.splitContainer1.Panel1.Controls.Add(this.listViewQuestions);
            this.splitContainer1.Panel1MinSize = 250;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBoxSettings);
            this.splitContainer1.Panel2.Controls.Add(this.labelOdpowiedzi);
            this.splitContainer1.Panel2.Controls.Add(this.labelTresc);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxQuestionText);
            this.splitContainer1.Panel2.Controls.Add(this.panelAnswerContainer);
            this.splitContainer1.Panel2MinSize = 640;
            this.splitContainer1.Size = new System.Drawing.Size(984, 520);
            this.splitContainer1.SplitterDistance = 320;
            this.splitContainer1.TabIndex = 0;
            // 
            // labelPytania
            // 
            this.labelPytania.AutoSize = true;
            this.labelPytania.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPytania.Location = new System.Drawing.Point(4, 4);
            this.labelPytania.Name = "labelPytania";
            this.labelPytania.Size = new System.Drawing.Size(62, 17);
            this.labelPytania.TabIndex = 1;
            this.labelPytania.Text = "Pytania";
            // 
            // listViewQuestions
            // 
            this.listViewQuestions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listViewQuestions.FullRowSelect = true;
            this.listViewQuestions.GridLines = true;
            this.listViewQuestions.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem9,
            listViewItem10,
            listViewItem11,
            listViewItem12});
            this.listViewQuestions.Location = new System.Drawing.Point(0, 24);
            this.listViewQuestions.MultiSelect = false;
            this.listViewQuestions.Name = "listViewQuestions";
            this.listViewQuestions.Size = new System.Drawing.Size(318, 491);
            this.listViewQuestions.TabIndex = 0;
            this.listViewQuestions.UseCompatibleStateImageBehavior = false;
            this.listViewQuestions.View = System.Windows.Forms.View.List;
            this.listViewQuestions.SelectedIndexChanged += new System.EventHandler(this.listViewQuestions_SelectedIndexChanged);
            // 
            // labelOdpowiedzi
            // 
            this.labelOdpowiedzi.AutoSize = true;
            this.labelOdpowiedzi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOdpowiedzi.Location = new System.Drawing.Point(11, 120);
            this.labelOdpowiedzi.Name = "labelOdpowiedzi";
            this.labelOdpowiedzi.Size = new System.Drawing.Size(81, 17);
            this.labelOdpowiedzi.TabIndex = 3;
            this.labelOdpowiedzi.Text = "Odpowiedzi";
            // 
            // labelTresc
            // 
            this.labelTresc.AutoSize = true;
            this.labelTresc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTresc.Location = new System.Drawing.Point(11, 4);
            this.labelTresc.Name = "labelTresc";
            this.labelTresc.Size = new System.Drawing.Size(94, 17);
            this.labelTresc.TabIndex = 2;
            this.labelTresc.Text = "Treśc pytania";
            // 
            // textBoxQuestionText
            // 
            this.textBoxQuestionText.AcceptsReturn = true;
            this.textBoxQuestionText.Location = new System.Drawing.Point(2, 24);
            this.textBoxQuestionText.Multiline = true;
            this.textBoxQuestionText.Name = "textBoxQuestionText";
            this.textBoxQuestionText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxQuestionText.Size = new System.Drawing.Size(457, 93);
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
            this.panelAnswerContainer.Size = new System.Drawing.Size(653, 375);
            this.panelAnswerContainer.TabIndex = 0;
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
            // 
            // groupBoxSettings
            // 
            this.groupBoxSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSettings.Controls.Add(this.buttonAddQuestion);
            this.groupBoxSettings.Controls.Add(this.checkBoxMultiChoice);
            this.groupBoxSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxSettings.Location = new System.Drawing.Point(465, 15);
            this.groupBoxSettings.Name = "groupBoxSettings";
            this.groupBoxSettings.Size = new System.Drawing.Size(182, 102);
            this.groupBoxSettings.TabIndex = 5;
            this.groupBoxSettings.TabStop = false;
            this.groupBoxSettings.Text = "Ustawienia pytania";
            // 
            // buttonAddQuestion
            // 
            this.buttonAddQuestion.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonAddQuestion.Location = new System.Drawing.Point(6, 66);
            this.buttonAddQuestion.Name = "buttonAddQuestion";
            this.buttonAddQuestion.Size = new System.Drawing.Size(106, 30);
            this.buttonAddQuestion.TabIndex = 5;
            this.buttonAddQuestion.Text = "Dodaj pytanie";
            this.buttonAddQuestion.UseVisualStyleBackColor = true;
            this.buttonAddQuestion.Click += new System.EventHandler(this.buttonAddQuestion_Click);
            // 
            // ViewCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 520);
            this.Controls.Add(this.splitContainer1);
            this.Name = "ViewCreator";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.View1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBoxSettings.ResumeLayout(false);
            this.groupBoxSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panelAnswerContainer;
        private System.Windows.Forms.ListView listViewQuestions;
        private System.Windows.Forms.Label labelPytania;
        private System.Windows.Forms.Label labelOdpowiedzi;
        private System.Windows.Forms.Label labelTresc;
        private System.Windows.Forms.TextBox textBoxQuestionText;
        private System.Windows.Forms.GroupBox groupBoxSettings;
        private System.Windows.Forms.CheckBox checkBoxMultiChoice;
        private System.Windows.Forms.Button buttonAddQuestion;
    }
}

