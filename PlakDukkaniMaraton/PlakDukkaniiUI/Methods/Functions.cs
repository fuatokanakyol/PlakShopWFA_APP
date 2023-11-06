using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlakDukkaniiUI.Methods
{
    public static class Functions
    {
        
        public static bool PasswordCheck(string password)
        {
            // Şifre uzunluğu en az 8 karakter olmalıdır
            if (password.Length < 8)
            {
                return false;
            }

            // Şifrede en az 2 büyük harf olmalıdır
            if (password.Count(char.IsUpper) < 2)
            {
                return false;
            }

            // Şifrede en az 3 küçük harf olmalıdır
            if (password.Count(char.IsLower) < 3)
            {
                return false;
            }

            // Şifrede en az 2 özel karakter olmalıdır: !, :, + veya *
            int uniqueCharCount = password.Count(c => c == '!' || c == ':' || c == '+' || c == '*');
            if (uniqueCharCount < 2)
            {
                return false;
            }

            // Tüm kriterler sağlandıysa true döndür
            return true;
        }
        public static void Clear(Control.ControlCollection collection)
        {
            foreach (var item in collection)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Clear();
                }
                if (item is DataGridView)
                {
                    ((DataGridView)item).ClearSelection();
                }
                if (item is RadioButton)
                {
                    ((RadioButton)item).Checked = false;
                }
                if (item is CheckBox)
                {
                    ((CheckBox)item).Checked = false;
                }
                if (item is NumericUpDown)
                {
                    ((NumericUpDown)item).Value = 0;
                }
            }
        }

        public static bool IsEmptyArea(Control.ControlCollection collection)
        {
            bool result = false;
            foreach (var item in collection)
            {
                if (item is TextBox)
                {
                    result = ((TextBox)item).Text == string.Empty ? true : false;

                }
                if (item is RadioButton)
                {
                    result = ((RadioButton)item).Checked == true ? true : false;

                }
                if (item is DateTimePicker)
                {
                    result = ((DateTimePicker)item).Value == DateTime.Now ? true : false;
                }
                
            }
            return result;
        }
    }
}
