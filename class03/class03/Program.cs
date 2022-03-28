using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ways to decalare a variable in C#
            //put type before your declare your variable like ( int variable = 1)
            //hide the type and just decalre like ( vairable = 1)
            //put the word dynamic how posibly you change the type like ( dynamic variable = ')

            string variable = "can't change the type once declared";
            var variable1 = "can't change the type once declared too";
            dynamic variable2 = "can change the type how many time as i want";

            Console.WriteLine("when i declare like this (string variable) i " + variable);
            Console.WriteLine("when i declare like this (var variable1) i " + variable1);
            Console.WriteLine("when i declare like this (dynamic variable2) i " + variable2);
            variable2 = 93.23f;
            Console.Write(variable2);
            Console.ReadLine();
        }
    }
}
