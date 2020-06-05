//Udisteanu Iulian-Elisei grupa 3123
using NivelModele;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaWindowsForm
{
    public partial class FiltrareGrup : Form
    {
        public Grup grup;
        public FiltrareGrup()
        {
            InitializeComponent();
        }

        private void btnCauta_Click(object sender, EventArgs e)
        {
            int ok = 0;
            Grup gr = Grup.Necunoscut;
            List<string> grupuri = new List<string>();
            foreach (var gr1 in gbGrup.Controls)
            {
                CheckBox ck = gr1 as CheckBox;
                if (ck.Checked == true)
                {
                    gr |= (Grup)Enum.Parse(typeof(Grup), ck.Text);

                    ok++;
                }
            }
            if (ok == 0)
            {
                gr = Grup.Necunoscut;
            }
            grup = gr;
        }
    }
}
