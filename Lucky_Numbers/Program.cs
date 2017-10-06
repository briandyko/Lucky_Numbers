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

            Console.WriteLine("Now please enter the first number.");
            int firstGuess = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the second number.");
            int secondGuess = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the third number.");
            int thirdGuess = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the fourth number.");
            int fourthGuess = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the fifth number.");
            int fifthGuess = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the sixth number.");
            int sixthGuess = int.Parse(Console.ReadLine());

            int[] userGuesses = new int[6];
                      
            for (int i = 0; i < userGuesses.Length; i++)
            {
                userGuesses[i] = int.Parse(Console.ReadLine()); 
               
            }
            






        }
    }
}
