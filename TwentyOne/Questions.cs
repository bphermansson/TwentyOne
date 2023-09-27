using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    internal class Questions
    {
        public static bool Again() {
            Console.WriteLine("Game over! Again? (y/n)");
            if (Console.ReadLine() != "y")
            {
                Console.WriteLine("Ok, bye!");
                Environment.Exit(0);
            }
            return true;
        }
        public static bool ToHigh(int res)
        {
            bool trueFalse = false;
            if (res > 21)
            {
                trueFalse = true;
            }
            return trueFalse;
        }
    }
}
