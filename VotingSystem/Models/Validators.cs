using System.Windows.Forms;
using MetroFramework.Controls;

namespace VotingSystem.Models
{
    public static class Validators
    {
        private static string _title = "Entry Error";
        private static readonly ErrorProvider errProvider = new ErrorProvider();

        public static string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public static bool IsImagePresent(Control control)
        {
            if (control.GetType().ToString() == "System.Windows.Forms.PictureBox")
            {
                PictureBox pictureBox = (PictureBox)control;
                if (pictureBox.Image == null)
                {
                    errProvider.SetError(pictureBox, pictureBox.Tag + @" is a required.");
                    pictureBox.Focus();
                    return false;
                }
                else
                    return true;
            }
            return true;
        }

        public static bool IsPresent(Control control)
        {
            if (control.GetType().ToString() == "MetroFramework.Controls.MetroTextBox")
            {
                var textBox = (MetroTextBox)control;
                if (textBox.Text == "")
                {
                    // MessageBox.Show(textBox.Tag + @" is a required field.", Title);

                    errProvider.SetError(textBox, textBox.Tag + @" is a required field.");
                    textBox.Focus();
                    textBox.SelectAll();
                    return false;
                }
                else
                {
                    errProvider.SetError(textBox, "");
                    return true;
                }
            }
            else if (control.GetType().ToString() == "MetroFramework.Controls.MetroComboBox" )
            {
                var comboBox = (MetroComboBox)control;
                if (comboBox.Text == "")
                {
                    //MessageBox.Show(comboBox.Tag.ToString() + " is a required field.", Title);
                    errProvider.SetError(comboBox, comboBox.Tag + @" is a required field.");
                    comboBox.Focus();
                    comboBox.SelectAll();
                    return false;
                }
                else
                {
                    errProvider.SetError(comboBox, "");
                    return true;
                }

            }
            else if (control.GetType().ToString() == "System.Windows.Forms.MaskedTextBox")
            {
                MaskedTextBox makBox = (MaskedTextBox)control;
                if (makBox.Text == "")
                {
                    errProvider.SetError(makBox, makBox.Tag + @" is a required field ");
                    makBox.Focus();
                    makBox.SelectAll();
                    
                }
                else
                {
                    errProvider.SetError(makBox, "");
                    return true;
                }
            }
            return true;
        }
    }
}
