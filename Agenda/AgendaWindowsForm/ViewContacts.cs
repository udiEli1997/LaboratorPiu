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
    public partial class ViewContacts : Form
    {
        private IStocareData adminPersoane;

        private List<Persoana> persoane;
        public ViewContacts()
        {
            InitializeComponent();
            adminPersoane = StocareFactory.GetAdministratorStocare();
        }

        private void ViewContacts_Load(object sender, EventArgs e)
        {
            ActualizareLista();
        }

        private void ActualizareLista()
        {
            persoane = GetContactsList();
            contactsList.Items.Clear();
            foreach (var pers in persoane)
            {
                var row = new string[] { pers.Nume, pers.Prenume, pers.NumarTelefon };
                var lvi = new ListViewItem(row);

                lvi.Tag = pers;

                contactsList.Items.Add(lvi);
            }
        }

        


        private List<Persoana> GetContactsList()
        {
            return adminPersoane.GetPersoane();
        }

        private void UpdateList(string cautare)
        {
            contactsList.Items.Clear();
            foreach (var pers in persoane)
            {
                if (pers.Nume.ToLower().Contains(cautare) || pers.Prenume.ToLower().Contains(cautare))
                {
                    var row = new string[] { pers.Nume, pers.Prenume, pers.NumarTelefon };
                    var lvi = new ListViewItem(row);

                    lvi.Tag = pers;

                    contactsList.Items.Add(lvi);
                }
            }
        }

        private void txtCautare_TextChanged(object sender, EventArgs e)
        {
            UpdateList(txtCautare.Text.ToLower());
        }

        private void contactsList_MouseClick(object sender, MouseEventArgs e)
        {
            Persoana pers = (Persoana)contactsList.SelectedItems[0].Tag;
            txtNume.Text = pers.Nume;
            txtPrenume.Text = pers.Prenume;
            txtTelefon.Text = pers.NumarTelefon;
            txtEmail.Text = pers.Email;
            txtGrup.Text = string.Join(" ", pers.Grupuri); ;
            txtDataNasterii.Text = pers.DataNasterii.ToShortDateString();
            txtGen.Text = pers.Gen.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Persoana pers = (Persoana)contactsList.SelectedItems[0].Tag;
                if (pers != null)
                {
                    ResetareControale();
                    EditContact edit = new EditContact(pers);
                    Hide();
                    edit.ShowDialog();
                    Show();
                    ActualizareLista();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Selectati un contact!!");
            }

        }

        private void ResetareControale()
        {
            txtNume.Text = string.Empty;
            txtPrenume.Text = string.Empty;
            txtTelefon.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtDataNasterii.Text = string.Empty;
            txtGrup.Text = string.Empty;
            txtGen.Text = string.Empty;
        }

        private void resetareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActualizareLista();
        }

        private void Filtrare(DateTime date1,DateTime date2)
        {
            List<Persoana> filtrare = adminPersoane.FiltrareDupaDataActualizarii(date1, date2);
            contactsList.Items.Clear();
            foreach (var pers in filtrare)
            {
                var row = new string[] { pers.Nume, pers.Prenume, pers.NumarTelefon };
                var lvi = new ListViewItem(row);

                lvi.Tag = pers;

                contactsList.Items.Add(lvi);
            }
        }

        private void FiltrareGrup(Grup gp)
        {
            List<Persoana> filtrare = adminPersoane.FiltrareDupaGrup(gp);
            contactsList.Items.Clear();
            foreach (var pers in filtrare)
            {
                var row = new string[] { pers.Nume, pers.Prenume, pers.NumarTelefon };
                var lvi = new ListViewItem(row);

                lvi.Tag = pers;

                contactsList.Items.Add(lvi);
            }
        }

        private void filtrareDataActualizareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FiltrareData filtare = new FiltrareData())
            {
                if (filtare.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Filtrare(filtare.Dela, filtare.PanaLa);
                }
            }
        }

        private void filtrareDupaGrupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FiltrareGrup filtare = new FiltrareGrup())
            {
                if (filtare.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    FiltrareGrup(filtare.grup);
                }
            }
        }
    }
}
