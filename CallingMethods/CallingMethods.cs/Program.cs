using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            // instanciate new class into the program.
            Numbers numbers = new Numbers();

            // Ask for user input and convert it to int.
            Console.WriteLine("Please enter an integer.");
            int input = Convert.ToInt32(Console.ReadLine());

            // Prints each method return.
            Console.WriteLine(Numbers.AddTwo(input));
            Console.WriteLine(Numbers.SubtractTwo(input));
            Console.WriteLine(Numbers.TimesTwo(input));
            Console.ReadLine();
        }

        

    }
}
