//Udisteanu Iulian-Elisei grupa 3123
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NivelAccesDate;
using NivelModele;

namespace AgendaWindowsForm
{
    public partial class PaginaPrincipla : Form
    {
        private IStocareData adminContacte;
        public PaginaPrincipla()
        {

            InitializeComponent();
            adminContacte = StocareFactory.GetAdministratorStocare();
            List<Persoana> sarbatoriti = adminContacte.CautareDupaDataCurenta();
            if (sarbatoriti.Count != 0)
            {
                string mesaj = "Sarbatoritii de astazi: \n";
                foreach (var pers in sarbatoriti)
                {
                    mesaj += pers.NumeComplet + "\n";
                }
                mesaj += "Salutai cu un sincer, La multi ani!!!";
                MessageBox.Show(mesaj);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Form1 adaugaForma = new Form1();
            Hide();
            adaugaForma.ShowDialog();
            Show();
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            ViewContacts viewContacts = new ViewContacts();
            Hide();
            viewContacts.ShowDialog();
            Show();
        }
    }
}
