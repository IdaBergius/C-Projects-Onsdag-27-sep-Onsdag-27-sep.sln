using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moms
{
    class Program

        //merblaaaa

    {

        static public int totalPris;

        static void Main(string[] args)
        {

            Console.WriteLine("Vad kostar din vara?");
            int pris = int.Parse(Console.ReadLine());

            totalPris = Moms(pris);
            Console.WriteLine("Totalpriset blir" + totalPris + " kr");


        }

        static int Moms(int pris)
        {
            int totalPris = pris + pris;
            return totalPris;

        }

        // int i = Addera(1, 2)
        //Console.WriteLine1();

        //static int Moms(decimal belopp)
        //return a + b;
    }
}
