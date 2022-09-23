using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageExpress.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Asks for user input of package weight
            Console.WriteLine("Please enter the weight on your package.");
            double packWeight = Convert.ToDouble(Console.ReadLine());

            // Based on user input this section uses a if else statement to flag as overweight and end
            // the program, or ask for more dimensions
            if (packWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
                Console.WriteLine("Please enter the package width.");
                double packWidth = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please enter the package height.");
                double packHeight = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please enter the package length.");
                double packLength = Convert.ToDouble(Console.ReadLine());

                // establishes and recasts variables for total dimensions and shipping costs
                double totalPack = packWidth + packHeight + packLength;
                double shipCost = packWidth * packHeight * packLength * packWeight / 100;
                decimal shippingCost = Convert.ToDecimal(shipCost);

                // Final tenary statement to show package is oversized or display the shipping cost.
                string result = totalPack > 50 ? "Package too big to be shipped via Package Express." :
                    "Your estimated total for shipping this package is: $" + shippingCost;
                Console.WriteLine(result);

                
            }

            Console.ReadLine();
        }
    }
}
