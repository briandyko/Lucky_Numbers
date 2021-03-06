﻿using System;
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
            string playAgain;            // declaring this variable to use in do-while loop that allows for play again feature.

            do
            {
                // part 1

                Console.WriteLine("Let's play a game. Think of a range of numbers. Within your chosen range, \n there are 6 very lucky numbers. If you can guess those 6 numbers, you will \n win a jackpot of $100,000,000.\n");
                Console.WriteLine("What would you like the lowest number in the range to be?");

                int lowestNum = int.Parse(Console.ReadLine());

                Console.WriteLine("What would you like the highest number in the range to be?");

                int highestNum = int.Parse(Console.ReadLine());

                int[] userGuesses = new int[6];

                for (int i = 0; i < userGuesses.Length; i++)    // loop that populates userGuesses[]
                {
                    Console.WriteLine("Please enter a number within your chosen range:");
                    userGuesses[i] = int.Parse(Console.ReadLine());

                    while (userGuesses[i] < lowestNum || userGuesses[i] > highestNum)  // valid number loop
                    {
                        Console.WriteLine("Please enter a valid number.");
                        userGuesses[i] = int.Parse(Console.ReadLine());
                    }


                }

                // Part 2


                int[] generatedNumbers = new int[6];
                Random rand = new Random();

                for (int j = 0; j < generatedNumbers.Length; j++)   // random number generator loop that stores values in generatedNumbers[]
                {
                    int newNumber = rand.Next(lowestNum, highestNum) + 1;
                    generatedNumbers[j] = newNumber;
                }

                for (int k = 0; k < generatedNumbers.Length; k++)  // Lucky Number display loop
                {
                    Console.WriteLine("Lucky Number: " + generatedNumbers[k]);
                }

                // part 3
                // jackpot variables

                double jackpot = 100000000;
                double fiveNumJackpot = .75 * jackpot;
                double fourNumJackpot = .25 * jackpot;
                double threeNumJackpot = .05 * jackpot;
                double twoNumJackpot = .0015 * jackpot;
                double oneNumJackpot = .000005 * jackpot;
                double zeroNumJackpot = 0 * jackpot;

                // method used to calculate and display winnings

                int[] diff = userGuesses.Except(generatedNumbers).ToArray();;
                if (diff.Length == 0)
                {
                    Console.WriteLine("You guessed 6 numbers correctly!");
                    Console.WriteLine("You won $" + jackpot + "!");
                }
                else if (diff.Length == 1)
                {
                    Console.WriteLine("You guessed 5 numbers correctly!");
                    Console.WriteLine("You won $" + fiveNumJackpot + "!");
                }
                else if (diff.Length == 2)
                {
                    Console.WriteLine("You guessed 4 numbers correctly!");
                    Console.WriteLine("You won $" + fourNumJackpot + "!");
                }
                else if (diff.Length == 3)
                {
                    Console.WriteLine("You guessed 3 numbers correctly!");
                    Console.WriteLine("You won $" + threeNumJackpot + "!");
                }
                else if (diff.Length == 4)
                {
                    Console.WriteLine("You guessed 2 numbers correctly!");
                    Console.WriteLine("You won $" + twoNumJackpot + "!");
                }
                else if (diff.Length == 5)
                {
                    Console.WriteLine("You guessed 1 number correctly!");
                    Console.WriteLine("You won $" + oneNumJackpot + "!");
                }
                else if (diff.Length == 6)
                {
                    Console.WriteLine("You guessed 0 numbers correctly!");
                    Console.WriteLine("You won $" + zeroNumJackpot + "!");
                }

                // Part 4

                Console.WriteLine("Would you like to play again?");
                playAgain = Console.ReadLine().ToLower().Trim();

            }  // closes do part of loop, starts while section for play again feature

            while (playAgain == "yes");
            
                if (playAgain == "no")
            {
                Console.WriteLine("Thanks for playing!");
            }
                else
            {
                Console.WriteLine("Good job, you broke the game by not entering a \"yes\" or \"no\" response!");
            }
        }
    }


}
    
           