using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyNumbersProject
{
    class Program
    {
        static void Main(string[] args)
        //Asking user for info
        {
            Console.WriteLine("Weclome to Jerome's Lottery");
            Console.WriteLine("You will be asked to enter two numbers to start");
            Console.WriteLine("Please enter your first number");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your second number");
            int secondNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Now you will be asked to input 6 numbers one at a time");
            //setting the numbers in the array
            int[] luckyNumbers = new int[6];
            for (int i = 0; i <= luckyNumbers.Length - 1; i++)
            {
                Console.WriteLine("Enter the number");
                luckyNumbers[i] = int.Parse(Console.ReadLine());
                while (luckyNumbers[i] < firstNumber || luckyNumbers[i] > secondNum)
                {

                    Console.WriteLine("Enter a valid number");
                    break;
                }
            }

           

            
            
            
            
            // If the user enters a number that is outside of the range set, prompt the user to give you a valid number. Do this until the user enters a valid number.
            //Part 2

            // The program should randomly generate 6 numbers using a loop

       
            // The randomly generated numbers should be stored in an array
            // Numbers should be displayed to the console as such and using a loop (Numbers below are for example only. Format must be exact):
            //Lucky Number: 12
            //Lucky Number: 47
            //Lucky Number: 28
            //Lucky Number: 3
            //Lucky Number: 19
            //Lucky Number: 35
            //Part 3

            // Hard - code a value for the jackpot amount and let the user know what the jackpot amount is at some point you decide in the program.
            //   The program should count the number of correctly guessed numbers and output to the console to notify the user.Example:
            //You guessed 3 numbers correctly!
            //   The program should calculate the user's winnings based on the number of numbers guessed correctly.

            //   The user's winnings should be output to the console. Example:
            //  You won $256, 877.23!
            //  Part 4


            //   Ask the user if the user would like to play again.
            // If the user says yes, then the program should run again from the beginning.
            // If the user says no, then the program should say "Thanks for playing!"(Must be exact statement).
            //Stretch Tasks:

            //            Make your program ensure none of the generated numbers are repeated.For example, the following is a valid output:
            //Lucky Number: 12
            //Lucky Number: 47
            //Lucky Number: 28
            //Lucky Number: 3
            //Lucky Number: 19
            //Lucky Number: 35
            //But, the following output is invalid because 12 is generated twice.
            //Lucky Number: 12
            //Lucky Number: 47
            //Lucky Number: 28
            //Lucky Number: 3
            //Lucky Number: 19
            //Lucky Number: 12
            //If there is a repeated number, replace it with a new number.Do this until there are no repeated numbers.
        }
    }
}
