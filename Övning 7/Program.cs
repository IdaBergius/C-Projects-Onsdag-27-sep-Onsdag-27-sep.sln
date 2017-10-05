using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_7
{
    class Program
        
    {
        static public int tal1;
        static public int tal2;
        static public int summa;


        static void Main(string[] args)
        {

            Console.WriteLine("Skriv in ett tal");
            tal1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv in ett till tal");
            tal2 = int.Parse(Console.ReadLine());

            summa = Addera(tal1, tal2);

            Console.WriteLine("Summan av dina tal är" + summa);
            
        }

        static int Addera(int tal1, int tal2)
        {

            int summa2 = tal1 + tal2;
            return summa2;
        }
    }
}
