using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods.cs
{
    class Numbers
    {
        // Public method to add 2 to the users input.
        public static int AddTwo(int input)
        {
            int answer1 = input + 2;
            return answer1;
        }

        // Public method to subtract 2 from the users input.
        public static int SubtractTwo(int input)
        {
            int answer2 = input - 2;
            return answer2;
        }

        // Public method to multiply users input by 2.
        public static int TimesTwo(int input)
        {
            int answer3 = input * 2;
            return answer3;
        }
    }
}
