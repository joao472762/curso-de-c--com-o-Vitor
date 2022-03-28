using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //condition structure
            //it suits to you give coditions to you code
            //if == first term used to decalre a codition
            //else if == use to give another condition to your aplication
            //else == if no condition is satisfied, then else enter in action

            string firstCondition = "if Is True";
            string secondCondition = "else if is True";
            string thirdCondition = "else is True";

            if (firstCondition == "if Is True")
            {
                Console.WriteLine("if you see me it means that " + firstCondition);
            }
            else if (secondCondition == "else if is True")
            {
                Console.WriteLine("if you see me it means that " + secondCondition +
                    "and my if is False");
            }
            else { Console.WriteLine("if you see me it means that" + thirdCondition +
                "and none of the above conditions are satisfied."); }

            Console.ReadLine();
        }
    }
}
