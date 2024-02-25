using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Question_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1;i <= 10;i++) 
            {
              Console.WriteLine("Enter a number : ");
                int number = Convert.ToInt32(Console.ReadLine());

                if (number % 2 == 0)
                {
                    Console.WriteLine("It is an Even Number");
                }
                else
                {
                    Console.WriteLine("It is an Odd Number");
                }
                Console.ReadLine();
            }
        }
    }
}
