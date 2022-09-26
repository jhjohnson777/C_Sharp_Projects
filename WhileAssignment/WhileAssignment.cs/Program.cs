using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileAssignment.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            // set var to 0
            int x = 0;
            // while x is less or equal to 15 
            while (x <= 15)
            {
                // write x
                Console.WriteLine(x);
                // increment x
                x++;
            }

            // set var to 1
            int i = 1;
            // do this no matter what
            do
            {
                // write i
                Console.WriteLine(i);
                // increment i
                i++;
            }
            // while i is less than 10
            while (i < 10);
                
            Console.Read();
        }
    }
}
