using System;

namespace DebugProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main starts");
            CalculateDiscount(10);
            Console.WriteLine("Main Ends");
        }
       
        static void CalculateDiscount(int x)
        {
            int discount = 100;
            if (x == 10)
                discount += 10;
            else if (x == 9)
                discount += 9;
            else if (x == 8)
                discount += 8;
            else
                discount++;


        }

    }
}
