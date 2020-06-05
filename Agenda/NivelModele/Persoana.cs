//Udisteanu Iulian-Elisei grupa 3123
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
        private const char SEPARATOR_SECUNDAR_FISIER = ' ';
        private const int NUME = 1;
        private const int PRENUME = 2;
        private const int EMAIL = 3;
        private const int NUMAR = 4;
        private const int GRUP = 5;
        Grup grup;

        public string NumeComplet
        {
            get
            {
                return Nume + " " + Prenume;
            }
        }

        public int IdPersoana { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Email { get; set; }

        public string NumarTelefon { get; set; }

        public DateTime DataNasterii { get; set; }

        public DateTime DataActualizare { get; set; }

        public Gen Gen { get; set; }

        public List<string> Grupuri { get; set;}
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
        
        public string GrupuriAsString
        {
            get
            {
                string grupuri = string.Empty;
                
                if((Grup & Grup.Familie) == Grup.Familie)
                {
                    grupuri += Grup.Familie.ToString();    
                }
                
                if ((Grup & Grup.Servici) == Grup.Servici)
                {
                    if (grupuri != "")
                    {
                        grupuri += SEPARATOR_SECUNDAR_FISIER;
                    }
                    grupuri += Grup.Servici.ToString();
                }

                if ((Grup & Grup.Prieteni) == Grup.Prieteni)
                {
                    if (grupuri != "")
                    {
                        grupuri += SEPARATOR_SECUNDAR_FISIER;
                    }
                    grupuri += Grup.Prieteni.ToString();
                }
                
                if (grupuri == "")
                {
                    return Grup.Necunoscut.ToString();
                }
                
                return grupuri;
            }
        }

        public Persoana(string _nume,string _prenume,string _email,string _numar,Grup _grup,DateTime _dataNasterii,DateTime _dataActualizare,Gen _gen)
        {
            //constructor cu datele de initializare separate
            Nume = _nume;
            Prenume = _prenume;
            Email = _email;
            NumarTelefon = _numar;
            grup = _grup;
            DataNasterii = _dataNasterii;
            DataActualizare = _dataActualizare;
            Gen = _gen;
            
        }

        public Persoana(string date_initializare)
        {
            //constructor cu datele de initializare intr-un singur sir , despartite prin ;
            string[] date = date_initializare.Split(SEPARATOR_PRINCIPAL_FISIER);
            IdPersoana = Convert.ToInt32(date[0]);
            Nume = date[NUME];
            Prenume = date[PRENUME];
            Email = date[EMAIL];
            NumarTelefon = date[NUMAR];
            Grupuri = new List<string>();
            grup = Grup.Necunoscut;
            //adauga mai multe elemente in lista de discipline
            Grupuri.AddRange(date[GRUP].Split(SEPARATOR_SECUNDAR_FISIER));
            foreach(var gr in Grupuri)
            {
                grup |= (Grup)Enum.Parse(typeof(Grup), gr);
            }
            //Enum.TryParse(date[GRUP],out grup);
            DataNasterii = DateTime.Parse(date[6]);
            DataActualizare = DateTime.Parse(date[7]);
            Gen = (Gen)Enum.Parse(typeof(Gen), date[8]);
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
            return string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}{0}{7}{0}{8}{0}{9}", SEPARATOR_PRINCIPAL_FISIER,IdPersoana, (Nume ?? " NECUNOSCUT "), (Prenume ?? " NECUNOSCUT "), (Email ?? " NECUNOSCUT "), (NumarTelefon ?? " NECUNOSCUT "), GrupuriAsString,DataNasterii.ToShortDateString(),DataActualizare.ToShortDateString(),Gen.ToString());
        }

    }
}
