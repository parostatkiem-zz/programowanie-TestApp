using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace programowanie_TestApp
{
    public partial class SingleAnswerControl : UserControl
    {
        public event Action<Answer> RemoveAnswer;
        public SingleAnswerControl()
        {
            InitializeComponent();
        }

        public SingleAnswerControl(string _text, bool _isRight)
        {
            InitializeComponent();
            this.TypedText = _text;
            this.IsRight = _isRight;
            
        }

        public string TypedText
        {
            get
            {
                return textBoxText.Text;
            }
            set
            {
                //dodać sprawdzanie warunków
                if (value == null) value = "";
                textBoxText.Text = value;
            }
        }

        public bool IsRight
        {
            get
            {
                return checkBoxIsRight.Checked;
            }
            set
            {
                checkBoxIsRight.Checked = value;
            }
            //dodać setter
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            RemoveAnswer(GetAnswerObject());
        }

        public Answer GetAnswerObject()
        {
            return new Answer(TypedText, IsRight);
        }
    }
}
