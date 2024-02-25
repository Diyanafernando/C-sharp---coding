using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Question_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a name : ");
            string name = Console.ReadLine();

            Console.Write("Enter marks : ");
            int marks = int.Parse(Console.ReadLine());

            if (marks >= 100) 
            {
              Console.WriteLine("Wrong marks !");
            }
            else if(marks>=75 && marks<=100)
            {
              Console.WriteLine("Grade A");
            }
            else if(marks>=60 && marks<=74) 
            {
              Console.WriteLine("Grade B");
            }
            else if(marks>=50 && marks<=59)
            {
              Console.WriteLine("Grade C");
            }
            else if(marks>=40 && marks<=49)
            {
                Console.WriteLine("Grade D");
            }
            else
            {
                Console.WriteLine("Failed !");
            }

            Console.ReadLine();

        }
    }
}
