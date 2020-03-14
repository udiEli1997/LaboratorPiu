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
        string nume;
        string prenume;
        string email;
        string numar_telegon;
        Grup grup;

        public Persoana(string _nume,string _prenume,string _email,string _numar,Grup _grup)
        {
            //constructor cu datele de initializare separate
            nume = _nume;
            prenume = _prenume;
            email = _email;
            numar_telegon = _numar;
            grup = _grup;
        }

        public Persoana(string date_initializare)
        {
            //constructor cu datele de initializare intr-un singur sir , despartite prin ,
            string[] date = date_initializare.Split(',');
            nume = date[0];
            prenume = date[1];
            email = date[2];
            numar_telegon = date[3];
            Enum.TryParse(date[4],out grup);
        }

        override
        public string ToString()
        {
            return nume + " " + prenume + " " + " face parte din grupul: " + grup;
        }

    }
}
