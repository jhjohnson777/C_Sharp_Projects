using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part 1:
            // Defines a new array.
            string[] vehicles = new [] { "Volvo", "Ford", "Chevrolet", "Porsche", "Nissan" };

            // Asks for user input.
            Console.WriteLine("Please type a descriptor for a car brand.");
            // Stores response in variable named description.
            string description = Console.ReadLine();

            // Redefines each index as current string plus user input.
            for (int i = 0; i < vehicles.Length; i++)
            {
                vehicles[i] = vehicles[i] + " " + description;
            }
            
            // Foreach loop used to print each new string in the array.
            foreach (string item in vehicles)
            {
                Console.WriteLine(item);
            }
            
            // Part 2: 
            // While true with no addition code triggers a inifinite loop.
            // Switching to a counter with a less than comparison gives an end point.
            int x = 0;
            while (x < 5)
            {
                Console.WriteLine("Hello, World");
                x++;
            }

            // Part 3:
            // while loop using a < operator
            int y = 0;
            while (y < 15)
            {
                Console.WriteLine(y);
                y++;
            }

            // while loop using <= operator
            int s = 0;
            while (s <= 20)
            {
                Console.WriteLine(s);
                s++;
            }

            // Part 4:
            // A list of strings
            List<string> stringList = new List<string>() { "Bill", "Bob", "Joe", "Jimmy", "John" };
            // creation of a bool variable to indicate when a match is found
            bool found = false;
            // do this code while a match is not found
            do
            {
                // request for user input
                Console.WriteLine("Please enter a name from the list.");
                // stores user input
                string userInput = Console.ReadLine();

                // if the list contains user input, print the index number and stop the loop
                if (stringList.Contains(userInput))
                {
                    Console.Write(stringList.IndexOf(userInput));
                    found = true;
                }
                // if not, states its not found and starts a request for user input again
                else
                {
                    Console.WriteLine("The name you entered is not on the list.");
                }
            }
            while (found == false);

            // Part Five:
            // Create a list of strings
            List<string> nameList = new List<string>() { "Jimmy", "Jack", "Bobby", "Phil", "Bart", "Jack" };

            // Request for user input
            Console.WriteLine("\nType in a name you'd like to find from the list.");
            string searched = Console.ReadLine();

            // uses bool from earlier to flag if word is found or not
            found = false;
            // for loop to iterate through nameList
            for (int i = 0; i < nameList.Count; i++)
            {
                // if name is found, write index and change bool to true
                if (nameList[i] == searched)
                {
                    Console.WriteLine(i);
                    found = true;
                }
            }
            // if bool remains false write Your entry was not found
            if (found == false)
            {
                Console.WriteLine("Your entry was not found.");
            }
            
            
            // Part Six:
            // Creates a list called words
            List<string> words = new List<string>() { "words", "lists", "school", "car", "school", "bus" };

            // creates an empty list used for comparison
            List<string> dupWords = new List<string>();
            // iterate for each word in list words
            foreach (string word in words)
            {
                // Compares word to dupWords list. If word is in dupWords list, the word has been seen before.
                if (dupWords.Contains(word))
                {
                    Console.WriteLine(word + " - This has been seen before.");
                }
                // If its not found in dupWords the word has not been seen before and adds the word to the dupWords list
                else
                {
                    Console.WriteLine(word + " - This has not been seen before.");
                    dupWords.Add(word);
                }
            }


            Console.ReadLine();

        }
    }
}
