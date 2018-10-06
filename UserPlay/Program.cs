 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserPlay
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int winningNum = rnd.Next(1, 1000);
            int counter = 1;
            int userGuess;
            do
            {
                userGuess = GetUserGuess();
                if (userGuess < winningNum)
                {
                    Console.WriteLine("Your guess is too low");
                    counter++;
                }
                else
                {
                    Console.WriteLine("Your guess is too high");
                    counter++;
                }
            } while (userGuess != winningNum);
            Console.WriteLine($"You guessed the number. It took you {counter} tries.");


        }

        static int GetUserGuess()
        {
            int userGuess = 0;
            do
            {
                Console.WriteLine("Enter a number between 1-1000");
                try
                {
                    userGuess = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a valid number");
                }
            } while (userGuess < 1 || userGuess > 1000);
            return userGuess;
        }
    }
}
