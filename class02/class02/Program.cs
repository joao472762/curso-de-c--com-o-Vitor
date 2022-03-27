using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int = any integer number
            //float = any number with numrbers after of he dot
            //string = any text beteween quotation marks like "helo word"
            //char = only recive one character and only can wirte between simple quotation marks like 'n'
            //boll   = only recive two values (True) and (false)
            //double = any number with two or one number after fo the dot

            int intNumber = 29;
            float FloatNumber = 10.11f;
            double DoubleNumber = 10.11;
            string stringText = "astroword";
            char charText = 'n';
            bool bullTrueOrFalse = false;
            var name = "jay zila";

            Console.WriteLine("the Integare number is " + intNumber);
            Console.WriteLine("the Floating number is  " + FloatNumber);
            Console.WriteLine("the Double number is " + DoubleNumber);
            Console.Write("the String text is " + stringText + '\n');
            Console.WriteLine("the Character text is " + charText);
            Console.WriteLine("the bolean is igua " + bullTrueOrFalse);
           Console.WriteLine(name);


            Console.ReadLine();
          
        }
    }
}
