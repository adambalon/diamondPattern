using System;

namespace diamondPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                /// Dev: Adam Balon
                /// 04/14/2022
                /// This is a short program that uses for loops to print a diamond pattern
                /// The challenge for this particular exercise is using only TWO for loops

                //Prompt user for input
                Console.WriteLine("Enter how many rows: ");
                int numRows = Convert.ToInt32(Console.ReadLine());

                //This checks whether the input is odd or even
                while (numRows % 2 != 1)
                {
                    Console.WriteLine("Please enter an odd value");
                    int userInput = Convert.ToInt32(Console.ReadLine());

                    if (userInput % 2 == 1)
                    {
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }

                //Find the center of the diamond pattern
                int totalRun = numRows + 1;
                int midRow = (numRows + 1) / 2;
                int diff = 0;

                //Diamond creation loop
                for (int i = 1; i < totalRun; i++)
                {
                    for (int j = 1; j < totalRun; j++)
                    {
                        if (midRow - diff <= j && j <= midRow + diff)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }

                    Console.WriteLine();
                    if (i < midRow)
                    {
                        diff++;
                    }
                    else
                    {
                        diff--;
                    }
                }
            }
        }
    }
}
