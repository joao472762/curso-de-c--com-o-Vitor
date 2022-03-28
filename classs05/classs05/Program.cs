using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classs05
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //using the comand ReadLine
            //ReadLine it suits to you get a value who is inside WriteLine or Write
            int age;

            Console.Write("how many years you have: ");
         
            int age2 = int.Parse(Console.ReadLine());
            Console.WriteLine(" you have " +  " years  and too" + age2);


            Console.ReadLine();
        }
    }
}
