using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Question_7
{
    internal class Program
    {
        private static double balance = 1000;
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Welcome to the ATM machine !");
                Console.WriteLine("1. Check balance");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice : ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice) 
                {
                    case 1:
                        CheckBalance();
                        break;
                    case 2:
                        DepositMoney();
                        break;
                    case 3:
                        WithdrawMoney();
                        break;
                    case 4:
                        Console.WriteLine("Thank you for using the ATM.Goodbye");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice.Please try again.");
                        break;

                }
                Console.WriteLine();
            }
        }


        static void CheckBalance()
        {
            Console.WriteLine($"Your current balance is: Rs.{balance}");
        }


        static void DepositMoney()
        {
            Console.Write("Enter the amount to deposit: Rs.");
            double amount = double.Parse(Console.ReadLine());
            balance = balance + amount;
            Console.WriteLine($"Rs.{amount} deposited successfully.");
        }


        static void WithdrawMoney()
        {
            Console.Write("Enter the amount to withdraw: Rs.");
            double amount = double.Parse(Console.ReadLine());
            if (amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Rs.{amount} withdrawn successfully.");
            }
            else
            {
                Console.WriteLine("Insufficient funds.");
            }
        }
    }
}
