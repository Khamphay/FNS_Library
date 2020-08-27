using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Data;
using System.Drawing;

namespace ProjectLibrary
{
    class MyModel
    {
        public static string[] staff = new string[6];
       
        public static InputLanguage eng, lao;
        public static DataTable table;
        public static DataTable tablecard, table_staff;
        public static int fsh_action;
        public static void getSwitchLanguage()
        {
            foreach (InputLanguage lg in InputLanguage.InstalledInputLanguages)
            {
                if (lg.LayoutName.Contains("US"))
                {
                    eng = lg;
                }
                else if (lg.LayoutName.Contains("Lao"))
                {
                    lao = lg;
                }

            }
        }

        public static void KeyISBN(KeyPressEventArgs ev)
        {
            if (char.IsControl(ev.KeyChar) || char.IsDigit(ev.KeyChar) || char.IsSymbol(ev.KeyChar))
            {
                ev.Handled = false;
            }
            else
            {
                ev.Handled = true;
            }
        }
        public static void KeyNumber(KeyPressEventArgs ev)
        {
            if (char.IsControl(ev.KeyChar) || char.IsDigit(ev.KeyChar))
            {
                ev.Handled = false;
            }
            else
            {
                ev.Handled = true;
            }
        }
        public static void KeyLatter(KeyPressEventArgs ev)
        {
            if ( !char.IsDigit(ev.KeyChar))
            {
                ev.Handled = false;
            }
            else
            {
                ev.Handled = true;
            }
        }
        public static void MouseHover(Image img, Color backcol, Color textcol, Button button )
        {
            button.Image = img;
            button.BackColor = backcol;
            button.ForeColor = textcol;
        }
        public static void MouseLeave(Image img, Color backcol, Color textcol, Button button )
        {
            button.Image = img;
            button.BackColor = backcol;
            button.ForeColor = textcol;
        }
    }
}
