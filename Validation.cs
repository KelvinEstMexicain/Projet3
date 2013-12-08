using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.ComponentModel;

namespace Projet3
{
    public static class Validation
    {
        public static void TextBoxValideTextSeulement(object sender, ErrorProvider errProvider, String errMessage, CancelEventArgs e)
        {
            var textbox = (TextBoxBase)sender;
            if (!ValideTextSeulement(textbox.Text))
            {
                errProvider.SetError(textbox, errMessage);
                e.Cancel = true;
            }
            else
            {
                errProvider.SetError(textbox, "");
            }
        }

        public static void TextBoxValideEmail(object sender, ErrorProvider errProvider, String errMessage, CancelEventArgs e)
        {
            var textbox = (TextBoxBase)sender;
            if (!ValideEmail(textbox.Text))
            {
                errProvider.SetError(textbox, errMessage);
                e.Cancel = true;
            }
            else
            {
                errProvider.SetError(textbox, "");
            }
        }

        public static void MaskedTextBoxValideTelOpt(object sender, ErrorProvider errProvider, String errMessage, CancelEventArgs e)
        {
            var textbox = (MaskedTextBox)sender;
            if (textbox.Text != "(   )    -")
            {
                MaskedTextBoxValideTel(sender, errProvider, errMessage, e);
            }
            else
            {
                errProvider.SetError(textbox, "");
            }
            
        }

        public static void MaskedTextBoxValideTel(object sender, ErrorProvider errProvider, String errMessage, CancelEventArgs e)
        {
            var textbox = (MaskedTextBox)sender;
            if (!ValideTel(textbox.Text))
            {
                errProvider.SetError(textbox, errMessage);
                e.Cancel = true;
            }
            else
            {
                errProvider.SetError(textbox, "");
            }
        }

        public static void ComboBoxValideNonVide(object sender, ErrorProvider errProvider, String errMessage, CancelEventArgs e)
        {
            var combobox = (ComboBox)sender;
            if (combobox.SelectedIndex < 0)
            {
                errProvider.SetError(combobox, errMessage);
                e.Cancel = true;
            }
            else
            {
                errProvider.SetError(combobox, "");
            }
        }

        public static void TextBoxValideNonVide(object sender, ErrorProvider errProvider, String errMessage, CancelEventArgs e)
        {
            var textbox = (TextBoxBase)sender;
            if (textbox.Text == "")
            {
                errProvider.SetError(textbox, errMessage);
                e.Cancel = true;
            }
            else
            {
                errProvider.SetError(textbox, "");
            }
        }

        public static void TextBoxValideCodePostal(object sender, ErrorProvider errProvider, String errMessage, CancelEventArgs e)
        {
            var textbox = (TextBoxBase)sender;
            if (!ValideCodePostal(textbox.Text))
            {
                errProvider.SetError(textbox, errMessage);
                e.Cancel = true;
            }
            else
            {
                errProvider.SetError(textbox, "");
            }
        }

        public static void TextBoxValideArgent(object sender, ErrorProvider errProvider, String errMessage, CancelEventArgs e)
        {
            var textbox = (TextBoxBase)sender;
            if (!ValideArgent(textbox.Text))
            {
                errProvider.SetError(textbox, errMessage);
                e.Cancel = true;
            }
            else
            {
                errProvider.SetError(textbox, "");
            }
        }

        public static void TextBoxValideNombres(object sender, ErrorProvider errProvider, String errMessage, CancelEventArgs e)
        {
            var textbox = (TextBoxBase)sender;
            if (!ValideNombres(textbox.Text))
            {
                errProvider.SetError(textbox, errMessage);
                e.Cancel = true;
            }
            else
            {
                errProvider.SetError(textbox, "");
            }
        }

        public static void DateTimePickerValideAgeDor(object sender, ErrorProvider errProvider, String errMessage, CancelEventArgs e)
        {
            TimeSpan age = DateTime.Now - ((DateTimePicker)sender).Value;
            int ageAnnee = age.Days / 365;
            if (ageAnnee < 60)
            {
                errProvider.SetError((DateTimePicker)sender, errMessage);
                e.Cancel = true;
            }
            else
            {
                errProvider.SetError((DateTimePicker)sender, "");
            }
        }

        public static void DataGridTextBoxValideTextSeulement(object sender, String errMessage, CancelEventArgs e)
        {
            var textbox = (DataGridViewTextBoxCell)sender;
            if (!ValideTextSeulement(textbox.EditedFormattedValue.ToString()))
            {
                textbox.ErrorText = errMessage;
            }
            else
            {
                textbox.ErrorText = "";
            }
        }

        public static void DataGridTextBoxValideNonVide(object sender, String errMessage, CancelEventArgs e)
        {
            var textbox = (DataGridViewTextBoxCell)sender;
            if (textbox.EditedFormattedValue == "")
            {
                textbox.ErrorText = errMessage;
            }
            else
            {
                textbox.ErrorText = "";
            }
        }

        public static void DataGridTextBoxValideCodePostal(object sender, String errMessage, CancelEventArgs e)
        {
            var textbox = (DataGridViewTextBoxCell)sender;
            if (!ValideCodePostal(textbox.EditedFormattedValue.ToString()))
            {
                textbox.ErrorText = errMessage;
            }
            else
            {
                textbox.ErrorText = "";
            }
        }

        public static void DataGridDateTimePickerValideAgeDor(object sender, String errMessage, CancelEventArgs e)
        {
            var textbox = (DataGridViewTextBoxCell)sender;
            try
            {
                DateTime date = Convert.ToDateTime(textbox.EditedFormattedValue);
                TimeSpan age = DateTime.Now - date;
                int ageAnnee = age.Days / 365;
                if (ageAnnee < 60)
                {
                    textbox.ErrorText = errMessage;
                }
                else
                {
                    textbox.ErrorText = "";
                }
            }
            catch(FormatException error)
            {
                textbox.ErrorText = "Le format de date entré est incorrect";
            }
        }

        public static void DataGridTextBoxValideTelOpt(object sender, String errMessage, CancelEventArgs e)
        {
            var textbox = (DataGridViewTextBoxCell)sender;
            if (textbox.EditedFormattedValue != "")
            {
                DataGridTextBoxValideTel(sender, errMessage, e);
            }
            else
            {
                textbox.ErrorText = "";
            }

        }

        public static void DataGridTextBoxValideTel(object sender, String errMessage, CancelEventArgs e)
        {
            var textbox = (DataGridViewTextBoxCell)sender;
            if (!ValideTel(textbox.EditedFormattedValue.ToString()))
            {
                textbox.ErrorText = errMessage;
            }
            else
            {
                textbox.ErrorText = "";
            }
        }

        public static void DataGridTextBoxValideEmail(object sender, String errMessage, CancelEventArgs e)
        {
            var textbox = (DataGridViewTextBoxCell)sender;
            if (!ValideEmail(textbox.EditedFormattedValue.ToString()))
            {
                textbox.ErrorText = errMessage;
            }
            else
            {
                textbox.ErrorText = "";
            }
        }

        public static bool ValideTextSeulement(string text)
        {
            return Regex.IsMatch(text, @"^([a-zA-Z'àâéèêôùûçÀÂÉÈÔÙÛÇ\s-]{1,30})$");
        }

        public static bool ValideEmail(string text)
        {
            return Regex.IsMatch(text, @"(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|'(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*')@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[a-z0-9-]*[a-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])");
        }

        public static bool ValideTel(string text)
        {
            return Regex.IsMatch(text, @"\(?(\d{3})\)? ?(\d{3})-(\d{4})");
        }

        public static bool ValideCodePostal(string text)
        {
            return Regex.IsMatch(text, @"^([ABCEGHJKLMNPRSTVXY]\d[ABCEGHJKLMNPRSTVWXYZ])\ {0,1}(\d[ABCEGHJKLMNPRSTVWXYZ]\d)$");
        }

        public static bool ValideArgent(string text)
        {
            return Regex.IsMatch(text, @"\d+(?:,\d{1,2})?");
        }

        public static bool ValideNombres(string text)
        {
            return Regex.IsMatch(text, @"^[a-zA-Z0-9]+$");
        }
    }
}
