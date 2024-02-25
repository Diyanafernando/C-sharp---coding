using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Question_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            int number = int.Parse(Console.ReadLine());

            int sum = 0;

            if (number > 0)
            {
             for (int i = 1; i <= number; i++) 
                {
                 sum += i;

                    Console.Write(sum);
                    Console.ReadLine();
                }
            }

            else
            {
                Console.Write("ERROR");
                Console.ReadLine();
            }
        }
    }
}
