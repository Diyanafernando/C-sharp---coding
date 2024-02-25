using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Question_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the height : ");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the width : ");
            int width = Convert.ToInt32(Console.ReadLine());
             
            CalArea(height , width);
            Console.ReadLine();

        }
        static void CalArea(int height, int width)
        {
            int area;

            area = height * width;
            Console.WriteLine("The area is : " + area);
        }
    }
}