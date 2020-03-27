using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    public enum Grup{ Necunoscut,Prieteni,Servici,Familie };
    class Persoana
    {
        public const int MAI_MARE = 1;
        public const int EGAL = 0;
        public const int MAI_MIC = 1;
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
            //constructor cu datele de initializare intr-un singur sir , despartite prin ,
            string[] date = date_initializare.Split(',');
            Nume = date[0];
            Prenume = date[1];
            Email = date[2];
            NumarTelefon = date[3];
            Enum.TryParse(date[4],out grup);
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

    }
}
