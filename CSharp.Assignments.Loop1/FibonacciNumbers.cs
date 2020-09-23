using System;
namespace CSharp.Assignments.Loop1
{
    /// <summary>
    /// The Main app will prompt the user for the last number of the Fibonacci numbers.
    /// Then, the app will write a sequence of numbers in a Fibonacci sequence up to the last number.
    /// Fibonacci numbers are the numbers in the following integer sequence, called the Fibonacci sequence, 
    /// and characterized by the fact that every number after the first two is the sum of the two preceding ones.
    /// The first two numbers are 0 and 1 so the numbers will be 0 1 1 2 3 5 8 13 21 34 55 89...
    /// </summary>
    public class FibonacciNumbers
    {
        public static void Main()
        {


            Console.WriteLine("Enter the last number of Fibonacci Sequence of numbers.");
            int count = Convert.ToInt32(Console.ReadLine());
            int n1 = 0, n2 = 1, n=1000, sum;



            if (n < 1)
                return;

            for (int i = 0; i < n; i++) //loop starts from 2 because 0 and 1 are already printed    
            {
                
                Console.Write(n1+" ");
                sum = n1 + n2;
                n1 = n2;
                n2 = sum;


            }
            Console.WriteLine();
        }
    }

}
