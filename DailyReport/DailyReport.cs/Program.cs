using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            // First two lines. Single line of code with a line break.
            Console.WriteLine("The Tech Academy.\nStudent Daily Report.");

            // Asks your name and stores response as a string in var yourName.
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();

            // Asks your current course and stores response as a string in var yourCourse.
            Console.WriteLine("What course are you on?");
            string yourCourse = Console.ReadLine();

            // Asks your current page number. Takes string input and casts it to store response as a 
            // short data type in var courseNum.
            Console.WriteLine("What page number?");
            string inputCourseNum = Console.ReadLine();
            short courseNum = Convert.ToInt16(inputCourseNum);

            // Asks if your need help as a true or false question. String input is then converted to a boolean
            // value and stored as var needHelp. 
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false.\"");
            string inputNeedHelp = Console.ReadLine();
            bool needHelp = Convert.ToBoolean(inputNeedHelp);

            // Asks if your have any experiences your liked like to share. Stores response as a string in var yourExp.
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string yourExp = Console.ReadLine();

            // Asks if you have any other feedback. Stores response as string in var yourFeedback.
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string yourFeedback = Console.ReadLine();

            // Asks how many hours you studied and takes string response and casts it as a double to handle decimals.
            Console.WriteLine("How many hours did you study?");
            string inputYourHours = Console.ReadLine();
            double yourHours = Convert.ToDouble(inputYourHours);

            // Final printed output
            Console.WriteLine("Thank you for you answers. An instructor will respond to this shortly. Have a great day!");
            // ReadLine so program pauses instead of instantly closing.
            Console.ReadLine();

           


            
        }
    }
}
