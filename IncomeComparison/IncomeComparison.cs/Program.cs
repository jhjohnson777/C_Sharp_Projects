using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeComparison.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            // intro line
            Console.WriteLine("Anonymous Income Comparison.\n\n");

            // first person
            Console.WriteLine("Person 1");

            // collecting person 1 hourly rate and converting to double
            Console.WriteLine("Hourly rate:");
            string inputHR1 = Console.ReadLine();
            double HR1 = Convert.ToDouble(inputHR1);

            // collecting person 1 hours and converting to double
            Console.WriteLine("Hours worked per week:");
            string inputH1 = Console.ReadLine();
            double H1 = Convert.ToDouble(inputH1);

            // annual salary of person 1
            double yearlySal1 = HR1 * H1 * 52;
            decimal yearly1 = Convert.ToDecimal(yearlySal1);

            // second person
            Console.WriteLine("\nPerson 2");

            // collecting person 2 hourly rate and converting to double
            Console.WriteLine("Hourly rate:");
            string inputHR2 = Console.ReadLine();
            double HR2 = Convert.ToDouble(inputHR2);

            // collecting person 2 hours and converting to double
            Console.WriteLine("Hours worked per week:");
            string inputH2 = Console.ReadLine();
            double H2 = Convert.ToDouble(inputH2);

            // annual salary of person 2
            double yearlySal2 = HR2 * H2 * 52;
            decimal yearly2 = Convert.ToDecimal(yearlySal2);

            // Displays annual salaries for person 1 and person 2
            Console.WriteLine("\nAnnual salary of Person 1: $" + yearly1);
            Console.WriteLine("Annual salary of Person 2: $" + yearly2);

            // compares each yearly salary and displays true if P1 makes more than P2 and false if not.
            Console.WriteLine("\nDoes Person 1 make more money than Person 2?");
            bool compareEach = yearly1 > yearly2;
            Console.WriteLine(compareEach);


            Console.ReadLine();
        }
    }
}
