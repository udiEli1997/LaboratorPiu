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
            Console.WriteLine(p1);
            Console.ReadKey();
        }
    }
}
