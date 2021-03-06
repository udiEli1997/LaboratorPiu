﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NivelModele;
using NivelAccesDate;
using System.Collections;

namespace Agenda
{
    class Program
    {
        public static Persoana citirePersoana()
        {
            string nume, prenume, email, numar, grup1;
            Grup grup;
            Console.WriteLine("Introduceti numele Persoanei: ");
            nume = Console.ReadLine();
            Console.WriteLine("Introduceti prenumele Persoanei: ");
            prenume = Console.ReadLine();
            Console.WriteLine("Introduceti email-lul Persoanei: ");
            email = Console.ReadLine();
            Console.WriteLine("Introduceti numarul de telefon al Persoanei: ");
            numar = Console.ReadLine();
            Console.WriteLine("Introduceti grupul Persoanei: ");
            grup1 = Console.ReadLine();
            Enum.TryParse(grup1, out grup);
            return  new Persoana(nume, prenume, email, numar, grup);
        }

        static void meniu()
        {
            Console.WriteLine("L. Listare Persoane");
            Console.WriteLine("A. Adaugare Persoana");
            Console.WriteLine("M. Modificare  Persoana");
            Console.WriteLine("X. Incheiere Program");
            Console.WriteLine("Introduceti optiunea dumneavoastra: ");

        }

        static void AfisarePersoane(ArrayList persoane)
        {
            foreach(Persoana pers in persoane)
            {
                Console.WriteLine(pers);
            }
        }

        static int CautaPersoana(ArrayList persoane, string nume, string prenume)
        {
            int i = 0;
            foreach(Persoana pers in persoane)
            {
                if(pers.NumeComplet.Equals(nume+" " + prenume))
                {
                    return i;
                }
                i++;
            }
            return -1;
        }

        static void ModificarePersoana(Persoana[] persoane,int idPersoana)
        {
            Console.WriteLine("Introduceti noul email: ");
            string email = Console.ReadLine();
            Console.WriteLine("Introduceti nou numar de telefon: ");
            string numar = Console.ReadLine();
            Console.WriteLine("Introduceti noul sau grup(Necunoscut,Prieteni,Servici,Familie): ");
            string grup = Console.ReadLine();
            if (!email.Equals(""))
            {
                persoane[idPersoana].Email = email;
            }
            if (!numar.Equals(""))
            {
                persoane[idPersoana].NumarTelefon = numar;
            }
            if (!grup.Equals(""))
            {
                Grup grup1;
                bool succes = Enum.TryParse(grup, out grup1);
                if (succes)
                {
                    persoane[idPersoana].Grup = grup1;
                } 
            }

        }
        static void Main(string[] args)
        {
            bool ok = true;
            ArrayList persoane;
            IStocareData adminPersoane = StocareFactory.GetAdministratorStocare();
            int nrPersoane;
            persoane = adminPersoane.GetPersoane();
            string optiune;
            while (ok==true)
            {
                meniu();
                optiune = Console.ReadLine();
                switch (optiune)
                {
                    case "L":
                        AfisarePersoane(persoane);
                        break;
                    case "A":
                        Persoana pers = citirePersoana();
                        persoane.Add(pers);
                        adminPersoane.AddPersoana(pers);
                        break;
                    case "M":
                        Console.WriteLine("Introduceti numele persoanei de cautat: ");
                        string nume = Console.ReadLine();
                        Console.WriteLine("Introduceti prenumele persoanei de cautat: ");
                        string prenume = Console.ReadLine();
                        int gasit = CautaPersoana(persoane,nume, prenume);
                        /*
                        if (gasit != -1)
                        {
                            ModificarePersoana(persoane, gasit);
                            adminPersoane.UpdatePersoana(persoane, nrPersoane);
                        }
                        else
                        {
                            Console.WriteLine("Nu exista persoana cautata!!");
                        }
                        */
                        break;
                    case "X":
                        ok = false;
                        break;
                }
            }


            Console.ReadKey();
        }
    }
}
