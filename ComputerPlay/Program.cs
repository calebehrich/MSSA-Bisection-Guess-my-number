using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerPlay
{
    class Program
    {
        static void Main(string[] args)
        {
            int winningNum = GetWinningNum();
            int compNum;
            int counter = 1;
            int min = 0;
            int max = 1000;
            int feedBack = 0;

            do
            {
                compNum = CompGuess(min, max);
                Console.WriteLine($"The computer guesses {compNum}");
                Console.WriteLine("Is guess right? (enter 1) Is guess higher or lower than your number? (enter 2 for higher and 3 for lower)");
                feedBack = int.Parse(Console.ReadLine());

                if (feedBack == 1)
                {
                    Console.WriteLine($"Computer guessed your number in {counter} tries.");
                }
                else if (feedBack == 2)
                {
                    max = compNum;
                    counter++;
                }
                else
                {
                    min = compNum;
                    counter++;
                }
            } while (compNum != winningNum);
            Console.WriteLine($"The computer guessed your number in {counter} tries");
      
        }

        static int CompGuess(int min, int max)
        {
            int compNum = min + ((max - min) / 2);
            return compNum;
        }
        static int GetWinningNum()
        {
            int winningNum = 0;
            do
            {
                Console.WriteLine("Enter the winning number between 1-1000");
                try
                {
                    winningNum = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a valid number");
                }
            } while (winningNum < 1 || winningNum > 1000);
            return winningNum;
        }
    }
}
