using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanAssignment.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Taking a string input and converting it and storing it to an integer variable.
            Console.WriteLine("What is your age?");
            int userAge = Convert.ToInt32(Console.ReadLine());

            // Taking a string input and converting it and storing it to a boolean variable
            Console.WriteLine("Have you ever had a DUI? Please answer True or False");
            bool userDUI = Convert.ToBoolean(Console.ReadLine());

            // Taking a string input and converting it and storing it to an integer variable
            Console.WriteLine("How many speeding tickets do you have?");
            int userTicket = Convert.ToInt32(Console.ReadLine());

            // Created a boolean variable based on comparing the data provided above and then
            // printing the response.
            Console.WriteLine("Qualified?");
            bool canInsure = userAge > 15 && userDUI == false && userTicket <= 3;
            string result = canInsure == true ? "You qualify for car insurance." : "You do not qualify.";
            Console.WriteLine(result);

            Console.Read();

        }
    }
}
