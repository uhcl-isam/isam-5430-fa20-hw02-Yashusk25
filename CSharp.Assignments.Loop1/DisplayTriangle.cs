using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Assignments.Loop1
{
    /// <summary>
    /// Write an app reads two inputs: a character that indicates which pattern to choose ('a' = lower left triangle, 'b' = upper left triangle, 'c' = upper right triangle, 'd' = lower right triangle) and an integer that indicates the number of lines to display. The app will then display the following patterns separately, one below the other. Use for loops to generate patterns. All asterisks (*) should be displayed by a signle statement of the form Console.Write('*'); which causes the asterisks to display side by side. A statement of the form Console.WriteLine(); can be used to move to the next line. A statement of the form COnsole.Write(' '); can be used to display a space for the last two patterns., There should be no other output statements in the app. [Hint: the last two patterns require that each line begin with an appropriate number of blank spaces.
    /// </summary>
    /// <example>
    ///    (a)          (b)         (c)          (d)
    /// *           **********  **********           *
    /// **          *********    *********          **
    /// ***         ********      ********         ***
    /// ****        *******        *******        ****
    /// *****       ******          ******       *****
    /// ******      *****            *****      ******
    /// *******     ****              ****     *******
    /// ********    ***                ***    ********
    /// *********   **                  **   *********
    /// **********  *                    *  **********
    /// </example>
    public class DisplayTriangle
    {
        public static void Main()
        {
            Console.Error.WriteLine("Type 'a' = lower left triangle; 'b' = upper left triangle; 'c' = upper right triangle; 'd' = lower right triangle.");
            char t = Convert.ToChar(Console.ReadLine());
            Console.Error.WriteLine("Enter the number of lines.");
            int n = Convert.ToInt32(Console.ReadLine());

            // Write your codes here.
            int row, col;
            //Console.WriteLine("Enter a number \n");
            //int value = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("Pattern a \n");
            for (row = 1; row <= n; ++row)
            {
                /* Iterate through columns to print star */
                for (col = 1; col <= row; ++col)
                {
                    Console.Write("*");
                }
                /* Move to next line */
                Console.WriteLine("");
            }
            Console.WriteLine("\nPattern B \n");
            for (row = n; row >= 1; --row)
            {
                /* Iterate through columns to print star */
                for (col = 1; col <= row; ++col)
                {
                    Console.Write("*");
                }
                /* Move to next line */
                Console.WriteLine("");
            }
            Console.WriteLine("\nPattern C \n");

            for (row = 1; row <= n; row++)
            {
                /* Print leading spaces */
                for (col = 1; col < row; col++)
                {
                    Console.Write(" ");
                }

                /* Iterate through columns to print star*/
                for (col = row; col <= n; col++)
                {
                    Console.Write("*");
                }

                /* Move to next line */
                Console.WriteLine("");
            }

            Console.WriteLine("\nPattern D \n");

            int k;
            for (row = 1; row <= n; row++)
            {
                for (col = 1; col <= n - row; col++)
                {
                    Console.Write(" ");
                }
                for (k = 1; k <= row; k++)
                {
                    /* Iterate through columns to print star */
                    Console.Write("*");
                }
                /* Move to next line */
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}
    



