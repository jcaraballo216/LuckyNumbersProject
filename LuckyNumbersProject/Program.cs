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
            Console.WriteLine("Weclome to Jerome's Lottery!");
            Console.WriteLine("The JackPot amount is currently 120,000.");
            Console.WriteLine("You will be asked to enter two numbers to start.");
            Console.WriteLine("Please enter your first number.");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your second number.");
            int secondNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Now you will be asked to input 6 numbers one at a time.");
            //setting the numbers in the array
            int[] luckyNumbers = new int[6];
            for (int i = 0; i <= luckyNumbers.Length - 1; i++)
            {
                Console.WriteLine("Enter your number.");
                luckyNumbers[i] = int.Parse(Console.ReadLine());
                while (luckyNumbers[i] < firstNumber || luckyNumbers[i] > secondNum)
                {

                    Console.WriteLine("Enter a valid number!");
                    break;
                }

            }
            //setting random in array
            Random number = new Random();
            int[] numbers = new int[6];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = number.Next(firstNumber, secondNum);
            }
            foreach (int numOne in numbers)
            {
                Console.WriteLine("Your number: " + (numOne));
            }
            int jackPot = 120000;
            int lottoNumber = 0;
            //hardcode for jackpot
            for (int i = 0; i < luckyNumbers.Length; i++) 
            {
                foreach (int num in luckyNumbers)
                    if (num == numbers[i]) 
                {
                        lottoNumber ++;
                }
                
            }
            Console.WriteLine("You guessed " + lottoNumber + " correctly");
            if (lottoNumber == 6)
            {
                Console.WriteLine("Congrats you have won the JackPot in the amount of " + jackPot);
            }
            else if (lottoNumber >=4)
            {
                Console.WriteLine("Congrats you have won $" + jackPot * .75);
            }
            else if (lottoNumber >= 2)
            {
                Console.WriteLine("Congrats you have won $" + jackPot * .25);
            }
            else if (lottoNumber >= 0)
            {
                Console.WriteLine("You didn't pick that many numbers but you still win $1.00.");
            }
            //making a do-while loop for yes/no question
            string lottoDec;
            do
            {
                Console.WriteLine("Thank you for playing! Would you like to play again! yes/no");
                lottoDec = Console.ReadLine().ToLower();
            }
            while (lottoDec == "no");


            











            



            
           
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
