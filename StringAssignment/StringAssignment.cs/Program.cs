using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            // declared three strings
            string oneone = "Hello, ";
            string twotwo = "my name is ";
            string threethree = "Slim Shady.";

            // used .Concat to concatenate the three strings together.
            string concat = string.Concat(oneone, twotwo, threethree);
            Console.WriteLine(concat);
            // used .ToUpper to convert string to all upper case.
            string upper = concat.ToUpper();
            Console.WriteLine(upper);

            // declares new stringbuilder variable
            StringBuilder s = new StringBuilder();

            // appends three strings to Stringbuilder var s
            s.Append("Look at me go. ");
            s.Append("Here I am. ");
            s.Append("OK, now what? ");

            // writes s with all three modifications
            Console.WriteLine(s);

            Console.ReadLine();

        }
    }
}
