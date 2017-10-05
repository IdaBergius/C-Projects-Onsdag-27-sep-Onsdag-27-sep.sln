using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onsdag_27_sep
{
    class Program
    {
        static void Main(string[] args)
        {


            //bool runProgram = true;

            //do
            //{
            //    Console.Clear();
            //    Console.Write("Ange ett tal:");
            //    string input;

            //    try
            //    {
            //      int input2 = int.Parse(input);


            //    }
            //    catch (Exception e)
            //    {
            //        e.Message

            //    }

            //Console.WriteLine("Skriv in ett tal mellan 1 och 100");

            //string input = Console.ReadLine();
            //int tal;
            //bool validInput = int.TryParse(input, out tal);



            //if(validInput)
            //{
            //    Console.WriteLine(tal);


            //}
            //else
            //{
            //    Console.WriteLine("Ogiltig inmatning");

            //}

            //Console.WriteLine("Skriv in ett tal:");
            //string input = Console.ReadLine();

            //int nr;

            //bool validInput = int.TryParse(input, out nr);

            //if(validInput)
            //{ Console.WriteLine(nr); }
            //else
            //{

            //    Console.WriteLine("Försök igen");
            //}

            Console.WriteLine("Skriv in ett tal");
            string input = Console.ReadLine();
            int i = int.Parse(input);

            switch (i)
            {
                case 1:
                    Console.WriteLine();
                    break;

                case 2:
                
                case 3:
                    Console.WriteLine();

                    break;



            }



        }
    }
}
