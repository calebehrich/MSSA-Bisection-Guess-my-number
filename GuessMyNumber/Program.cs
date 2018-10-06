using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyNumber
{
    class Program
    {
        
 
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int userNum = GetUserNumber();
            int compNum;
            int counter = 1;
            int min = 0;
            int max = numbers.Length - 1;
            

            do
            {
                compNum = GetCompNumber(min, max);
                Console.WriteLine($"The computer chose {numbers[compNum]}");
                if (numbers[compNum] < userNum)
                {
                    min = compNum;
                    Console.WriteLine("Choich is too low");
                    counter++;
                    
                }
                else if (numbers[compNum] > userNum)
                {
                    max = compNum;
                    Console.WriteLine("Choice is too high");
                    counter++;  
                }

            } while (numbers[compNum] != userNum);
            Console.WriteLine($"Found the number. It took you {counter} tries");
        }

        static int GetCompNumber(int min, int max)
        {
            int compNum = min + ((max - min) / 2);
            return compNum;
        }

        static int GetUserNumber()
        {
            int numChoice = 0;
            do
            {
                Console.WriteLine("Enter a number between 1-10");
                try
                {
                    numChoice = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a valid number");
                }
            } while (numChoice < 1 || numChoice > 10);
                 return numChoice;
        }
    }
}
