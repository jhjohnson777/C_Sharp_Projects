using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            // creates a list of integers
            List<int> numbers = new List<int>() { 5, 16, 22, 4, 9, 12 };

            // Asks for user input
            Console.WriteLine("Please enter a number to divide the numbers in this list by.");
            
            // try to divide the list of numbers by the given input
            try
            {
                int divideBy = Convert.ToInt32(Console.ReadLine());
                foreach (int number in numbers)
                {
                    // writes each answer to the console
                    int answer = number / divideBy;
                    Console.WriteLine(answer);
                }
            }
            // catches format exceptions such as strings
            catch (FormatException)
            {
                Console.WriteLine("Please enter a whole number.");
            }
            // catches errors caused by divided by 0
            catch (DivideByZeroException)
            {
                Console.WriteLine("You cannot divide by zero.");
            }
            // lets you know the program has emerged from the try/catch
            Console.WriteLine("I have emerged");
            
            
            Console.Read();
        }
    }
}
