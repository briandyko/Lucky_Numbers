using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lucky_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // part 1

            Console.WriteLine("Let's play a game. Think of a range of numbers. If you can guess the 6 numbers I am thinking of in your range, you will win big $$$$$$.");
            Console.WriteLine("What would you like the lowest number in the range to be?");

            int lowestNum = int.Parse(Console.ReadLine());

            Console.WriteLine("What would you like the highest number in the range to be?");

            int highestNum = int.Parse(Console.ReadLine());

            int[] userGuesses = new int[6];

            for (int i = 0; i < userGuesses.Length; i++)
            {
                Console.WriteLine("Please enter a number within the range");
                userGuesses[i] = int.Parse(Console.ReadLine());

                while(userGuesses[i] < lowestNum || userGuesses[i] > highestNum)
                {
                    Console.WriteLine("Please enter a valid number.");
                    userGuesses[i] = int.Parse(Console.ReadLine());
                }


            }

            // Part 2


            int[] generatedNumbers = new int[6];
            Random rand = new Random();

            for (int j = 0; j < generatedNumbers.Length; j++)
            {
                int newNumber = rand.Next(lowestNum, highestNum) + 1;
                generatedNumbers[j] = newNumber;
             }

          

            for(int k = 0;  k < generatedNumbers.Length; k++)
            {
                Console.WriteLine("Lucky Number: " + generatedNumbers[k]);
            }
        }
    }
}
