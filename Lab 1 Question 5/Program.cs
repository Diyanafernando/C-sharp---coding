using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Question_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number - ");
            int number = int.Parse(Console.ReadLine());



            for (int i = 1; i <= 12; i++)
            {
                int result = number * i;
                Console.WriteLine(number + "x" + i + "=" + result);
            }
            Console.ReadLine();
        }
    }
}
