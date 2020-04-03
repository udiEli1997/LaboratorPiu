using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NivelModele
{
   
    public class Persoana
    {
        public const int MAI_MARE = 1;
        public const int EGAL = 0;
        public const int MAI_MIC = 1;
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';
        private const int NUME = 0;
        private const int PRENUME = 1;
        private const int EMAIL = 2;
        private const int NUMAR = 3;
        private const int GRUP = 4;
        Grup grup;

        public string NumeComplet
        {
            get
            {
                return Nume + " " + Prenume;
            }
        }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Email { get; set; }

        public string NumarTelefon { get; set; }

        public Grup Grup
        {
            get
            {
                return grup;
            }
            set
            {
                grup = value;
            }
        }
        

        public Persoana(string _nume,string _prenume,string _email,string _numar,Grup _grup)
        {
            //constructor cu datele de initializare separate
            Nume = _nume;
            Prenume = _prenume;
            Email = _email;
            NumarTelefon = _numar;
            grup = _grup;
        }

        public Persoana(string date_initializare)
        {
            //constructor cu datele de initializare intr-un singur sir , despartite prin ;
            string[] date = date_initializare.Split(SEPARATOR_PRINCIPAL_FISIER);
            Nume = date[NUME];
            Prenume = date[PRENUME];
            Email = date[EMAIL];
            NumarTelefon = date[NUMAR];
            Enum.TryParse(date[GRUP],out grup);
        }

        override
        public string ToString()
        {
            return Nume + " " + Prenume + " " + " face parte din grupul: " + Grup;
        }

        public int Compara(Persoana _pers)
        {
            return this.NumeComplet.CompareTo(_pers.NumeComplet);
        }

        public string ConversieLaSir_PentruFisier()
        {
            return string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}", SEPARATOR_PRINCIPAL_FISIER, (Nume ?? " NECUNOSCUT "), (Prenume ?? " NECUNOSCUT "), (Email ?? " NECUNOSCUT "), (NumarTelefon ?? " NECUNOSCUT "), Grup);
        }

    }
}
