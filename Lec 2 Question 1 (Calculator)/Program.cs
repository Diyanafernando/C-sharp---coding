using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec_2_Question_1__Calculator_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CALCULATOR");
            Console.WriteLine("Enter the first number");
            double num1 = 
                Convert.ToDouble(Console.ReadLine());
            Console.WriteLine());
            Operation(+,-,*,/)
                Console.WriteLine("Enter the operation(+,-,*,/"):);
            char operation =
                Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter the second number : ");
            double num2 =
                Convert.ToDouble(Console.ReadLine());

            double result = 0;

            switch (operation) 
            {
              case '+':
                    result = num1 + num2;
                    break;

              case '-':
                    result = num1 - num2;
                    break;

              case '*':
                    result = num1 * num2;
                    break;

              case '/':
                    if (num2 !== 0) ;
                    result = num1 / num2;
                    else
                        Console.WriteLine("Error :Division by zero");
              return;

                default:

                    Console.WriteLine("Invalid operation entered");
                    return;
                    
            }
        }
    }
}
