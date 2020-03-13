using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    enum Grup{ Prieteni,Servici,Familie };
    class Persoana
    {
        string nume;
        string prenume;
        string email;
        string numar_telegon;
        Grup grup;

        public Persoana(string _nume,string _prenume,string _email,string _numar,Grup _grup)
        {
            nume = _nume;
            prenume = _prenume;
            email = _email;
            numar_telegon = _numar;
            grup = _grup;
        }

        public Persoana(string date_initializare)
        {
            //urmeaza sa completez
        }

        override
        public string ToString()
        {
            return nume + " " + prenume + " " + " face parte din grupul: " + grup;
        }

    }
}
