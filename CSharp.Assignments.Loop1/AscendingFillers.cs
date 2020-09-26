using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Assignments.Loop1
{
    /// <summary>
    /// Create an application that reads a bunch of non-negative integers line-by-line until a negative integer or the end-of-line (CTRL-Z) has reached. The app will print out the sum of all the fillers that will make all the values entered so far will appear in increasing order, where each value is larger than the previous number. That is each filler is added to each input, such that the numbers will all appear in increasing order (e.g. 1, 2, 3, 10). The only exception is when the element is 0, where the current number and the subsequent numbers will restart from zero.
    /// </summary>
    /// <param name="a"></param>
    /// <remarks>In essence, this app will calculate the sum of all these values added to the original numbers such that our projected numbers will appear in increasing order.</remarks>
    /// <returns>The sum of all the fillers</returns>
    public class AscendingFillers
    {
        public static void Main()
        {
            // Complete your loop codes here.
            var test = new AscendingFillers();

            Console.WriteLine("Please enter sequece of integer value");

            var inputValues = Console.ReadLine();

            var parsedIntegerValue = test.ValidateParams(inputValues);

            test.CalculateSequentialValue(parsedIntegerValue);

        }



        private void CalculateSequentialValue(IList<int> inputValues)

        {

            int outputSum = 0;

            for (int i = 0; i < inputValues.Count; i++)

            {

                if ((i + 1) != inputValues.Count && inputValues[i] == inputValues[i + 1])

                {

                    outputSum += 1;

                    inputValues[i + 1] += 1;

                }

                else

                {

                    if ((i + 1) != inputValues.Count)

                    {

                        if (inputValues[i] < inputValues[i + 1])

                        {

                            continue;

                        }

                        else

                        {

                            if (inputValues[i + 1] != 0)

                            {

                                var difference = (inputValues[i] - inputValues[i + 1]) + 1;

                                inputValues[i + 1] += difference;

                                outputSum += difference;

                            }

                        }

                    }

                }

            }



            Console.WriteLine($"The output sum {outputSum}");

        }



        private List<int> ValidateParams(string inputValues)

        {

            if (string.IsNullOrEmpty(inputValues))

            {

                Console.WriteLine($"Input cannot be empty {inputValues}");

               // CloseConsoleApp();

            }



            var values = inputValues.Split(',');

            var validIntegerValues = new List<int>();



            foreach (var value in values)

            {

                if (int.TryParse(value, out int parsedIntegerValue))

                {

                    if (parsedIntegerValue < 0)

                    {

                        Console.WriteLine($"Input contains invalid input {values}");

                       // CloseConsoleApp();

                    }

                    else

                    {

                        validIntegerValues.Add(parsedIntegerValue);

                    }

                }



            }



            return validIntegerValues;

        }



       

    }
}
    

