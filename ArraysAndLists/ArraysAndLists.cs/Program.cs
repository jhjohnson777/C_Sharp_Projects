using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndLists.cs
{
    class Program
    {
        static void Main()
        {
            // simple string array
            string[] strArray = new string[] { "Jim", "Bill", "Bob", "Joe" };

            // requesting numeric input
            Console.WriteLine("Please choose an index from the array.");
            // converts input from string to int
            int selection = Convert.ToInt32(Console.ReadLine());
            // if number chosen is less than the number of items in the array...
            if (selection < strArray.Length)
            {
                // displays requested selection
                Console.WriteLine(strArray[selection]);
            }
            else
            {
                // if not, this string displays
                Console.WriteLine("That index is not found");
            }

            // Request for user input
            Console.WriteLine("Please choose an index from the array.");
            // takes user input and converts from string to int
            int selection2 = Convert.ToInt32(Console.ReadLine());
            // simple int array
            int[] numArray = new int[] { 1, 5, 6, 22, 87, 365 };
            // if index is found in the array...
            if (selection2 < numArray.Length)
            {
                // display this
                Console.WriteLine(numArray[selection2]);
            }
            else
            {
                // otherwise display this
                Console.WriteLine("Your index could not be found.");
            }

            // request for user input
            Console.WriteLine("Please enter an index.");
            // convert user input from string to int
            int selection3 = Convert.ToInt32(Console.ReadLine());
            // list of strings
            List<string> numbers = new List<string> { "Bill", "Bob", "Joe" };
            // display users request
            Console.WriteLine(numbers[selection3]);

            
            Console.ReadLine();
        }
    }
}
