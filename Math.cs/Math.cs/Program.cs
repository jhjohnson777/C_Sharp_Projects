using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 7;
            int num2 = 5;
            int total = num1 + num2;
            Console.WriteLine(total);

            int diff = num1 - num2;
            Console.WriteLine(diff);

            int mult = num1 * num2;
            Console.WriteLine(mult);

            int div = num1 / num2;
            Console.WriteLine(div);

            string fName = "Jack";
            string lName = "Johnson";
            Console.WriteLine(fName + " " + lName);

            int newTotal = 5 + 10;
            int otherTotal = 12 + 22;
            int combined = total + otherTotal;
            Console.WriteLine(combined);

            int difference = 10 - 5;
            Console.WriteLine("Ten minus five = " + difference);

            bool trueOrFalse = 12 < 5;
            Console.WriteLine(trueOrFalse.ToString());

            int roomTemperature = 70;
            int currentTemperature = 70;

            bool isWarm = currentTemperature == roomTemperature;
            Console.WriteLine(isWarm);
            

            Console.ReadLine();
        }
    }
}
