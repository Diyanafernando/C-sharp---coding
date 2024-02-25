using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec_1_Question_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number : ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nThe sum of two numbers is : ");
            Console.WriteLine(n1 + n2);
            Console.ReadLine();
        }
    }
}
