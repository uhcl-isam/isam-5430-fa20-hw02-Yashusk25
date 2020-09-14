using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





namespace CSharp.Assignments.Loop1
{
    /// <summary>
    /// The process of finding the maximum value (i.e., the largest
    /// of a group of values) is used frequently in computer applications.
    /// For example, an app that determines the winner of a sales contest
    /// would input the number of units sold by each salesperson. The
    /// salesperson who sells the most units wins the contest.
    /// Write pseudocode, then a C# app that inputs a series of 10 integers,
    /// then determines and displays the largest integer followed by the
    /// second largest integer.
    /// Your app should use at least the following four variables:
    ///     counter: A counter to count to 10 (i.e., to keep track of
    ///        how many numbers have been input and to determine when all
    ///        10 numbers have been processed).
    ///     number (integer): The integer most recently input by the user.
    ///     largest: The largest number found so far.
    ///     largest2: The second largest number found so far.
    /// </summary>
    public class LargestNumbers
    {
        public static void Main()
        {
            // get first number and assign it to variable largest
            // write your codes here
            int counter=0;;
            
            int largest1=0;
            int largest2=0;
            int number=0;

            for(counter=0; counter < 10; counter++) {
            Console.WriteLine("Please enter the number");
                number=Convert.ToInt32(Console.ReadLine());

            
            

            if(counter==0){
              largest1=number;
            
            }

            else if (counter == 1)
                {
                   if(number>largest1)
                    largest2=number;
                   else
                        {
                      largest2 = largest1;
                        largest1=number;
                    }
            
            }

            else{
                  if(number> largest1 && number>largest2)
                        {
                          largest1 = largest2;
                          largest2 = number;
                    
                    }

                    else if(number> largest1 && number< largest2)
                        largest1 = number;
                
                
                }

            
                
            }
            
            Console.WriteLine("Two largest number enterd was {0}, {1}",largest2, largest1);
            Console.ReadLine();

        }
    }
}
