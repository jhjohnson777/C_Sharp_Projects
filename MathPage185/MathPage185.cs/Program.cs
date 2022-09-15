using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathPage185.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Takes user number and converts type to double and multiplies times 50.
            Console.WriteLine("Please enter a number.");
            string userInput1 = Console.ReadLine();
            double input1 = Convert.ToDouble(userInput1);
            double total1 = input1 * 50;
            Console.WriteLine("Your number times 50 = " + total1);

            // Takes user number, converts to double and adds 25.
            Console.WriteLine("Please enter a number.");
            string userInput2 = Console.ReadLine();
            double input2 = Convert.ToDouble(userInput2);
            double total2 = input2 + 25;
            Console.WriteLine("Your number plus 25 = " + total2);

            // Takes user number, converts to double and devides by 12.5.
            Console.WriteLine("Please enter a number.");
            string userInput3 = Console.ReadLine();
            double input3 = Convert.ToDouble(userInput3);
            double total3 = input3 / 12.5;
            Console.WriteLine("Your number divided by 12.5 = " + total3);

            // Converts user input to int and prints boolean response to x > 50.
            Console.WriteLine("Please enter a number.");
            string userInput4 = Console.ReadLine();
            int input4 = Convert.ToInt32(userInput4);
            bool greater = input4 > 50;
            Console.WriteLine(greater);

            // Converts user input to double and prints the remainder when input is divided by 7.
            Console.WriteLine("Please enter a number.");
            string userInput5 = Console.ReadLine();
            double input5 = Convert.ToDouble(userInput5);
            double remainder = input5 % 7;
            Console.WriteLine("Remainder of " + input5 + " divided by 7 = " + remainder);

            Console.ReadLine();
              
        }
    }
}
