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

            if (p1.compara(p2) == Persoana.MAI_MARE)
            {
                Console.WriteLine(p1.NumeComplet + " este mai mare decat " + p2.NumeComplet);
            }
            else if (p1.compara(p2) == Persoana.MAI_MIC)
            {
                Console.WriteLine(p2.NumeComplet + " este mai mare decat " + p1.NumeComplet);
            }
            else
            {
                Console.WriteLine("Este vorva despre aceeasi persoana!!");
            }
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.ReadKey();
        }
    }
}
