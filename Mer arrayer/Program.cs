using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mer_arrayer
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[3] { 1, 2, 3 };

            int input2 = 8;

            PushLeft(array, input2);

        }

        static void PushLeft(int[] input1, int input2)
        {

            for (int i = 0; i < input1.Length -1; i++)
            {
                int temp = input1[i + 1];
                input1[i] = temp;

              
            }

           input1[ input1.Length -1 ]= input2;

            for (int i = 0; i < input1.Length; i++)
            {
                Console.WriteLine(input1[i]);

           
            }


           // numbers[index -1] = numbers[index] HÅKANS LÖSNING

           

            //    int[] array = new int[5] { 1, 2, 3, 4, 5 };

            //    ReverseIntArray(array);



            //}

            //static void ReverseIntArray(int[] input)
            //{



            //    for (int i = input.Length -1; i >=0; i--)
            //    {
            //        Console.WriteLine(input[i]);


        }



        }

    }

