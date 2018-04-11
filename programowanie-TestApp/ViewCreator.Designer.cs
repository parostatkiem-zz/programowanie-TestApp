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
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("");
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.labelPytania = new System.Windows.Forms.Label();
            this.panelAnswerContainer = new System.Windows.Forms.Panel();
            this.listViewQuestions = new System.Windows.Forms.ListView();
            this.textBoxQuestionText = new System.Windows.Forms.TextBox();
            this.labelTresc = new System.Windows.Forms.Label();
            this.labelOdpowiedzi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.labelPytania);
            this.splitContainer1.Panel1.Controls.Add(this.listViewQuestions);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.labelOdpowiedzi);
            this.splitContainer1.Panel2.Controls.Add(this.labelTresc);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxQuestionText);
            this.splitContainer1.Panel2.Controls.Add(this.panelAnswerContainer);
            this.splitContainer1.Size = new System.Drawing.Size(643, 442);
            this.splitContainer1.SplitterDistance = 214;
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
            // panelAnswerContainer
            // 
            this.panelAnswerContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAnswerContainer.AutoScroll = true;
            this.panelAnswerContainer.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelAnswerContainer.Location = new System.Drawing.Point(2, 136);
            this.panelAnswerContainer.Name = "panelAnswerContainer";
            this.panelAnswerContainer.Size = new System.Drawing.Size(420, 303);
            this.panelAnswerContainer.TabIndex = 0;
            // 
            // listViewQuestions
            // 
            this.listViewQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listViewQuestions.FullRowSelect = true;
            this.listViewQuestions.GridLines = true;
            this.listViewQuestions.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8});
            this.listViewQuestions.Location = new System.Drawing.Point(0, 24);
            this.listViewQuestions.MultiSelect = false;
            this.listViewQuestions.Name = "listViewQuestions";
            this.listViewQuestions.Size = new System.Drawing.Size(214, 418);
            this.listViewQuestions.TabIndex = 0;
            this.listViewQuestions.UseCompatibleStateImageBehavior = false;
            this.listViewQuestions.View = System.Windows.Forms.View.List;
            this.listViewQuestions.SelectedIndexChanged += new System.EventHandler(this.listViewQuestions_SelectedIndexChanged);
            // 
            // textBoxQuestionText
            // 
            this.textBoxQuestionText.AcceptsReturn = true;
            this.textBoxQuestionText.Location = new System.Drawing.Point(14, 24);
            this.textBoxQuestionText.Multiline = true;
            this.textBoxQuestionText.Name = "textBoxQuestionText";
            this.textBoxQuestionText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxQuestionText.Size = new System.Drawing.Size(399, 87);
            this.textBoxQuestionText.TabIndex = 0;
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
            // labelOdpowiedzi
            // 
            this.labelOdpowiedzi.AutoSize = true;
            this.labelOdpowiedzi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOdpowiedzi.Location = new System.Drawing.Point(2, 116);
            this.labelOdpowiedzi.Name = "labelOdpowiedzi";
            this.labelOdpowiedzi.Size = new System.Drawing.Size(81, 17);
            this.labelOdpowiedzi.TabIndex = 3;
            this.labelOdpowiedzi.Text = "Odpowiedzi";
            // 
            // ViewCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 442);
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
    }
}

