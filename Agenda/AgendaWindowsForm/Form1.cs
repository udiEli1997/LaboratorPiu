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
using System.Text.RegularExpressions;

namespace AgendaWindowsForm
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        private IStocareData adminContacte;
        public Form1()
        {
            InitializeComponent();
            adminContacte = StocareFactory.GetAdministratorStocare();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            addPanel.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                txtName.Text = "Nume";
            }
            txtName.ForeColor = Color.DarkGray;
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            if (txtName.Text == "Nume")
            {
                txtName.Text = null;
            }
            txtName.ForeColor = Color.Black;
        }

        private void txtPrenume_Leave(object sender, EventArgs e)
        {
            if (txtPrenume.Text == "")
            {
                txtPrenume.Text = "Prenume";
            }
            txtPrenume.ForeColor = Color.DarkGray;
        }

        private void txtPrenume_Enter(object sender, EventArgs e)
        {
            if (txtPrenume.Text == "Prenume")
            {
                txtPrenume.Text = null;
            }
            txtPrenume.ForeColor = Color.Black;
        }

        private void txtTelefon_Leave(object sender, EventArgs e)
        {
            if (txtTelefon.Text == "")
            {
                txtTelefon.Text = "Telefon";
            }
            txtTelefon.ForeColor = Color.DarkGray;
        }

        private void txtTelefon_Enter(object sender, EventArgs e)
        {
            if (txtTelefon.Text == "Telefon")
            {
                txtTelefon.Text = null;
            }
            txtTelefon.ForeColor = Color.Black;
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "Email";
            }
            txtEmail.ForeColor = Color.DarkGray;
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Email")
            {
                txtEmail.Text = null;
            }
            txtEmail.ForeColor = Color.Black;
        }

        private void btnAdaugare_Click(object sender, EventArgs e)
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
                if(ok==0)
                {
                    gr = Grup.Necunoscut;
                }
                Gen gen = Gen.Neutru;
                if (rbMasculin.Checked)
                {
                    gen = Gen.Masculin;
                }
                else if (rbFeminin.Checked)
                {
                    gen = Gen.Feminin;
                }
                Persoana pers = new Persoana(txtName.Text, txtPrenume.Text, txtEmail.Text, txtTelefon.Text, gr, dataNastere.Value,DateTime.Now,gen);
                adminContacte.AddPersoana(pers);
                MessageBox.Show("Contactul a fost adaugat cu succes");
                ResetareControale();
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
            rezultat += Validare.Validare1(nume, txtName);
            rezultat += Validare.Validare1(prenume, txtPrenume);
            rezultat += Validare.Validare1(telefon, txtTelefon);
            rezultat += Validare.Validare1(email, txtEmail);
            if (txtName.Text == "Nume")
            {
                txtName.ForeColor = Color.Red;
                rezultat++;
            }
            if (txtPrenume.Text == "Prenume") {
                txtPrenume.ForeColor = Color.Red;
                rezultat++;
            }
            return rezultat == 0;
        }



        private void ResetareControale()
        {
            txtName.Text = "Nume";
            txtPrenume.Text = "Prenume";
            txtTelefon.Text = "Telefon";
            txtEmail.Text = "Email";
            gbGrup.BackColor = Color.Transparent;
            foreach(CheckBox ck in gbGrup.Controls)
            {
                ck.Checked = false;   
            }
            dataNastere.Value = DateTime.Now;
        }
    }
}
