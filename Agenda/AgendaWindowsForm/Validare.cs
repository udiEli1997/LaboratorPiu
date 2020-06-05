//Udisteanu Iulian-Elisei grupa 3123
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaWindowsForm
{
    public class Validare
    {


        public static int Validare1(string re, TextBox tb)
        {
            int ok = 0;
            Regex regex = new Regex(re);
            if (!regex.IsMatch(tb.Text))
            {
                tb.ForeColor = Color.Red;
                ok++;
            }
            return ok;
        }
    }
}
