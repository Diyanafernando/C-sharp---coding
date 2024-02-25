using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec_2_Question_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add numbers to the array");
            int[] numbers = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i} {numbers[i+1]}:");
                numbers[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Numbers entered :");
            foreach (int num in numbers)
                Console.Write(num + " ");

            int sum = 0;
            foreach (int num in numbers)
                sum += num;
        }
    }
}
