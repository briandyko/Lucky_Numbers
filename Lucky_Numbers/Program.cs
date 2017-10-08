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

            Console.WriteLine("Let's play a game. Think of a range of numbers. If you can guess the 6 numbers I am thinking of in your range, you will win $100,000,000.");
            Console.WriteLine("What would you like the lowest number in the range to be?");

            int lowestNum = int.Parse(Console.ReadLine());

            Console.WriteLine("What would you like the highest number in the range to be?");

            int highestNum = int.Parse(Console.ReadLine());

            int[] userGuesses = new int[6];

            for (int i = 0; i < userGuesses.Length; i++)
            {
                Console.WriteLine("Please enter a number within the range");
                userGuesses[i] = int.Parse(Console.ReadLine());

                while (userGuesses[i] < lowestNum || userGuesses[i] > highestNum)
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



            for (int k = 0; k < generatedNumbers.Length; k++)
            {
                Console.WriteLine("Lucky Number: " + generatedNumbers[k]);
            }

            // part 3

            double jackpot = 100000000;
            double fiveNumJackpot = .85 * jackpot;  //85,000,000
            double fourNumJackpot = .65 * jackpot; //65,000,000
            double threeNumJackpot = .45 * jackpot; // 45,000,000
            double twoNumJackpot = .25 * jackpot; // 25,000,000
            double oneNumJackpot = .00005 * jackpot;
            double zeroNumJackpot = 0 * jackpot;




            int[] diff = userGuesses.Except(generatedNumbers).ToArray();
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

        }
    }
}
            //int choice = 0;
            //int[] testArray = new int[6];

            //testArray[choice] = userGuesses[choice];



            //if (testArray.Contains(0))
            //{
            //    choice++;
            //}

            //if (testArray.Contains(6) == generatedNumbers.Contains(6))
            //{
            //    Console.WriteLine("You won!");
            //}

            //else if (userGuesses.Contains(5) == generatedNumbers.Contains(6))
            //{
            //    Console.WriteLine("You won 5!");
            //}

            //else if (userGuesses.Contains(4) == generatedNumbers.Contains(6))
            //{
            //    Console.WriteLine("You won 4!");
            //}

            //else if (userGuesses.Contains(3) == generatedNumbers.Contains(6))
            //{
            //    Console.WriteLine("You won 3!");
            //}

            //else if (userGuesses.Contains(2) == generatedNumbers.Contains(6))
            //{
            //    Console.WriteLine("You won 2!");
            //}

            //else if (userGuesses.Contains(1) == generatedNumbers.Contains(6))
            //{
            //    Console.WriteLine("You won 1!");
            //}

            //else
            //{
            //    Console.WriteLine("You lost!");
            //}




            //if (testArray.Contains(6))
            //{
            //    Console.WriteLine("You won the jackpot!");
            //}
            //else if (testArray.Contains(5))
            //{
            //    Console.WriteLine("You won " + fiveNumJackpot);
            //}
            //else if (testArray.Contains(4))
            //{
            //    Console.WriteLine("You won " + fourNumJackpot);
            //}
            //else if (testArray.Contains(3))
            //{
            //    Console.WriteLine("You won " + threeNumJackpot);
            //}
            //else if (testArray.Contains(2))
            //{
            //    Console.WriteLine("You won " + twoNumJackpot);
            //}
            //else if (testArray.Contains(1))
            //{
            //    Console.WriteLine("You won " + oneNumJackpot);
            //}
            //else
            //{
            //    Console.WriteLine("You lost, dude.");
            //}


            //int resultNum = 0;


            //if (userGuesses[p] == generatedNumbers[m])
            //{
            //    resultNum++;
            //}

            //if (p == 6)
            //{

            //    Console.WriteLine("You won the " + jackpot);
            //    break;
            //}

            //else if (p == 5)
            //{
            //    Console.WriteLine("You won " + fiveNumJackpot);
            //    break;
            //}
            //else if (p == 4)
            //{
            //    Console.WriteLine("You won " + fourNumJackpot);
            //    break;
            //}
            //else if (p == 3)
            //{
            //    Console.WriteLine("You won " + threeNumJackpot);
            //    break;
            //}
            //else if (p == 2)
            //{
            //    Console.WriteLine("You won " + twoNumJackpot);
            //    break;
            //}
            //else if (p == 1)
            //{
            //    Console.WriteLine("You won " + oneNumJackpot);
            //    break;
            //}

            //else
            //{
            //    Console.WriteLine("You won nothing");
            //    break;
            //}



        //    for (int m = 0; m < userGuesses.Length; m++)
        //    {
        //        for (int p = 0; p < generatedNumbers.Length; p++)
        //        {


        //            if (generatedNumbers[m] == userGuesses[p])
        //            {
        //                Console.WriteLine("You won +" + jackpot);
        //            }
                
        //        else if (generatedNumbers[m] - userGuesses[p] == 1)
        //            {
        //                Console.WriteLine("You won + " + fiveNumJackpot);
        //            }
        //        else if (generatedNumbers[m] - userGuesses[p] == 2)
        //        {
        //            Console.WriteLine("You won " + fourNumJackpot);
        //        }
        //        else if (generatedNumbers[m] - userGuesses[p] == 3)
        //        {
        //            Console.WriteLine("You won " + threeNumJackpot);
        //        }
        //        else if (generatedNumbers[m] - userGuesses[p] == 4)
        //        {
        //            Console.WriteLine("You won " + twoNumJackpot);
        //        }
        //        else if (generatedNumbers[m] - userGuesses[p] == 5)
        //        {
        //            Console.WriteLine("You won " + oneNumJackpot);
        //        }


        //    }
        //}

        //        if (generatedNumbers[m] == userGuesses[p])
        //        {
        //            Console.WriteLine("You won " + jackpot + "!");
        //        }
        //        else if (generatedNumbers[m] == userGuesses[p - 1])
        //        {
        //            Console.WriteLine("You won " + jackpot + "!");
        //        }
        //        else if (generatedNumbers[m] == userGuesses[p - 2])
        //        {
        //            Console.WriteLine("You won " + jackpot + "!");
        //        }
        //        else if (generatedNumbers[m] == userGuesses[p - 3])
        //        {
        //            Console.WriteLine("You won " + jackpot + "!");
        //        }
        //        else if (generatedNumbers[m] == userGuesses[p - 4])
        //        {
        //            Console.WriteLine("You won " + jackpot + "!");
        //        }
        //        else if (generatedNumbers[m] == userGuesses[p - 5])
        //        {
        //            Console.WriteLine("You won " + jackpot + "!");
        //        }
        //        else
        //        {
        //            Console.WriteLine("You won nothing!!!");
        //        }

        //    }
        //}

        //    //Console.WriteLine("This is a test");
        //        }
        //}
