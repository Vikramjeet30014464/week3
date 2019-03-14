using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = 3;
            int Finish = 20;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("N\t\tN*10\t\tN*100\t\tN*1000");
            for (int i = start; i <= Finish; i++)
            {
                Console.WriteLine($" {i}\t\t{i * 10}\t\t{i * 100}\t\t{i * 1000}");
         
            }


                Console.WriteLine("End of the for loop...\n*");
                Console.WriteLine();

                int counter = 3;
                Finish = 7;
                while (counter <= Finish)
              {
                    Console.WriteLine($"{counter}\t\t{counter * 10}\t\t{counter * 100}\t\t{counter * 1000}");
                    counter++;
              }
                Console.WriteLine("End of the while loop...\n");
                Console.ReadLine();

            counter = 3;
            do
            {
                Console.WriteLine($"{counter}\t\t{counter * 10}\t\t{counter * 100}\t\t{counter * 1000}");
                counter++;
            }
            while (counter <= Finish);
            

            }
        }
    }