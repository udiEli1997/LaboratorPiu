using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Agenda
{
    class Program
    {
        static void Main(string[] args)
        {
            Persoana p1 = new Persoana("Udisteanu,Iulian-Elisei,udisteanu.iulian@outlook.com,0748454948,Prieteni");
            Persoana p2 = new Persoana("Udisteanu,Iulian,udisteanu.iulian@gmail.com,0748454948,Prieteni");

            if (p1.Compara(p2) == Persoana.MAI_MARE)
            {
                Console.WriteLine(p1.NumeComplet + " este mai mare decat " + p2.NumeComplet);
            }
            else if (p1.Compara(p2) == Persoana.MAI_MIC)
            {
                Console.WriteLine(p2.NumeComplet + " este mai mare decat " + p1.NumeComplet);
            }
            else
            {
                Console.WriteLine("Este vorva despre aceeasi persoana!!");
            }
            // am suprascris metoda toString 
            Console.WriteLine(p1);
            Console.WriteLine(p2);

            string nume, prenume, email, numar,grup1;
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
            Persoana persoanaCititta = new Persoana(nume, prenume, email, numar, grup);
            Console.WriteLine(persoanaCititta);
            Console.ReadKey();
        }
    }
}
