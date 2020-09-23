using System;
using static System.Console;
namespace CSharp.Assignments.Loop1
{
    /// <summary>
    /// Develop a C# app that will determine whether any of several
    /// department-store customers has exceeded the credit limit on a charge
    /// account. For each customer, the following facts are available:
    ///    1) account number,
    ///    2) balance at the beginning of the month,
    ///    3) total of all items charged by the customer this month,
    ///    4) total of all credits applied to the customer’s account this month and,
    ///    5) allowed credit limit.
    /// The app should input all these facts as integers,
    /// calculate the new balance(= beginning balance + charges – credits),
    /// display the new balance and determine whether the new balance exceeds
    /// the customer’s credit limit.
    /// For those whose credit limit is exceeded, 
    /// the app should display the message "Credit limit exceeded" on a separate line. 
    /// Use sentinel-controlled iteration to obtain the data for each account
    /// (e.g. the iteration will terminate if the account number is a
    /// negative number).
    /// </summary>
    public class CreditLimitCalculator
    {
        public static void Main()
        {
            // read in account number
            // Enter your sentinel loop here
            int counter = 1;
            int end = 0;
            int newbal = 0;
            Console.Write("Please enter your account number: ");
            int acctnum = int.Parse(Console.ReadLine());

            Console.Write("Please enter your balance from the beggining of the month: ");
            int initbal = int.Parse(Console.ReadLine());

            Console.Write("Please enter the total of all items charged on the card this month:");
            int purchs = int.Parse(Console.ReadLine());

            Console.Write("Please enter the total of all credits applied this month: ");
            int credits = int.Parse(Console.ReadLine());

            Console.Write("Please enter the allowed credit limit: ");
            int limit = int.Parse(Console.ReadLine());

            Console.WriteLine("\nThank you…\n");

            //calculates the new balance for this processing phase
            newbal = initbal + purchs - credits;

            
            if (newbal > limit)
            {
                Console.WriteLine($"CREDIT LIMIT EXCEEDED!");
            }

            Console.WriteLine($"\nYour New Balance is { newbal }.");

            
            Console.Write("\nIf you are finished enter; 2.\n To input another account enter; -1: ");

            end = int.Parse(Console.ReadLine());
            
            while (end < 1)
            {

                counter++;

                Console.Write("Please enter your account number: ");
                int _acctnum = int.Parse(Console.ReadLine());

                Console.Write("Please enter your balance from the beggining of the month: ");
                int _initbal = int.Parse(Console.ReadLine());

                Console.Write("Please enter the total of all items charged on the card this month: ");
                int _purchs = int.Parse(Console.ReadLine());
                Console.Write("Please enter the total of all credits applied this month: ");
                int _credits = int.Parse(Console.ReadLine());

                Console.Write("Please enter the allowed credit limit: ");
                int _limit = int.Parse(Console.ReadLine());

                Console.WriteLine("\nThank you…\n");
                int _newbal = _initbal + _purchs  -  _credits;

                if (_newbal > _limit)
                {
                    Console.WriteLine($"CREDIT LIMIT EXCEEDED!");
                }

                Console.WriteLine($"\nYour New Balance is { _newbal }.");

                Console.Write("\nIf you are finished with your entries enter; 2.\n To input another account enter; -1: ");
                end = int.Parse(Console.ReadLine());
            }
            // termination phase

            while (end == 2)
            { end++; }

        }
    
}
    }

