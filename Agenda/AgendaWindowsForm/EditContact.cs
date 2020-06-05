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
    public partial class EditContact : Form
    {
        private IStocareData adminPersoane;
        private int id;
        public EditContact(Persoana pers)
        {
            InitializeComponent();
            txtNume.Text = pers.Nume;
            txtPrenume.Text = pers.Prenume;
            txtTelefon.Text = pers.NumarTelefon;
            txtEmail.Text = pers.Email;
            foreach(string str in pers.Grupuri)
            {
                if (str == "Prieteni")
                {
                    ckPrieteni.Checked = true;
                }
                if (str == "Familie")
                {
                    ckFamilie.Checked = true;
                }
                if (str == "Servici")
                {
                    ckServici.Checked = true;
                }
            }
            dataNasterii.Value = pers.DataNasterii;
            id = pers.IdPersoana;
            if (pers.Gen == Gen.Masculin)
            {
                rdbMasculin.Checked = true;
            }
            if(pers.Gen == Gen.Feminin)
            {
                rdbFeminin.Checked = true;
            }
            adminPersoane = StocareFactory.GetAdministratorStocare();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int ok = 0;
            if (ValidareIntrare())
            {
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
                Gen gen = Gen.Neutru;
                if (rdbMasculin.Checked)
                {
                    gen = Gen.Masculin;
                }
                else if (rdbFeminin.Checked)
                {
                    gen = Gen.Feminin;
                }
                Persoana persActualizat = new Persoana(txtNume.Text, txtPrenume.Text, txtEmail.Text, txtTelefon.Text, gr,dataNasterii.Value,DateTime.Now,gen);
                persActualizat.IdPersoana = id;
                if (adminPersoane.UpdatePersoana(persActualizat))
                {
                    MessageBox.Show("Actualizare cu succes!!");
                }

                Close();
            }
        }

        private bool ValidareIntrare()
        {
            string nume = @"^[a-zA-Z\s]+$";
            string prenume = @"^[a-zA-Z\s]+$";
            string telefon = @"(^[0-9]{10}$)|(^\+[0-9]{2}\s+[0-9] 
                {2}[0-9]{8}$)|(^[0-9]{3}-[0-9]{4}-[0-9]{4}$)";
            string email = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";
            int rezultat = 0;
            rezultat += Validare.Validare1(nume, txtNume);
            rezultat += Validare.Validare1(prenume, txtPrenume);
            rezultat += Validare.Validare1(telefon, txtTelefon);
            rezultat += Validare.Validare1(email, txtEmail);
            if (txtNume.Text == "Nume")
            {
                txtNume.ForeColor = Color.Red;
                rezultat++;
            }
            if (txtPrenume.Text == "Prenume")
            {
               txtPrenume.ForeColor = Color.Red;
                rezultat++;
            }
            return rezultat == 0;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (adminPersoane.StergePersoana(id))
            {
                MessageBox.Show("Stergere cu succes!!");
            }
            Close();
        }
    }
}
