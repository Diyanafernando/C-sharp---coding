using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Question_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++) 
            {
                int result = Fibo(i);
             Console.WriteLine(result);

            }
            Console.ReadLine();
        }
        static int Fibo(int i)
        {
            if (i <= 1)
            {
                return i;
            }
            else
            {
                return Fibo(i - 1) + Fibo(i - 2);
            }
        }
    }
}
