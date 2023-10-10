using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 2
            //Create a static class called Math
            //The class has the following methods :
            //Power(2) – Power(n) – SquareRoot – MaxNumber(takes two numbers returns the biggest) – MinNumber
            //Absolute
            //Use google search on how to create these methods mathematically

            Console.WriteLine(NewMath.Square(2));
            Console.WriteLine(NewMath.PowerN(3,4));
            Console.WriteLine(NewMath.MaxNubmer(1,2));
            Console.WriteLine(NewMath.MinNubmer(1, 2));
            Console.WriteLine(NewMath.Abso(5));


        }
    }
}
