
using System;

namespace Multiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = 0;
            int numberTwo = 0;
            int numberThree = 0;
            int result = 0;

            Console.Write("Enter your firstnumber: ");
            numberOne = int.Parse(Console.ReadLine());

            Console.Write("Enter your secondnumber: ");
            numberTwo = int.Parse(Console.ReadLine());

            Console.Write("Enter your thirdnumber: ");
            numberThree = int.Parse(Console.ReadLine());

            result = numberOne * numberTwo *numberThree;


            Console.WriteLine("The answer is : " + result);


        }
    }
}
