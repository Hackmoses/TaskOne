using System;

namespace Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = 0;
            int numberTwo = 0;

            int result = 0;

            Console.Write("Enter your firstnumber: ");
            numberOne = int.Parse(Console.ReadLine());

            Console.Write("Enter your secondnumber: ");
            numberTwo = int.Parse(Console.ReadLine());

            

            result = numberOne / numberTwo ;


            Console.WriteLine("The answer is : " + result);
        }
    }
}
