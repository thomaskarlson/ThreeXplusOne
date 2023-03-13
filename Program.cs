using System;
using System.Numerics;

namespace ThreeXplusOne
{
    internal class Program
    {
        private static ulong startingNumber = 1;
        private static HailstoneNumber _hailstoneNumber = new(startingNumber);

        private static void Main(string[] args)
        {
            Console.WriteLine("The Simplest Math Problem No One Can Solve");
            Console.WriteLine("https://www.youtube.com/watch?v=094y1Z2wpJg \n\n");

            Console.Write("Pick a number, any number: ");
            var inp = Console.ReadLine();
            if (BigInteger.TryParse(inp, out BigInteger startingNumber))
            {
                var number = new HailstoneNumber(startingNumber);
                Console.WriteLine($"Number set    : {number.NumberSetString()}");
                Console.WriteLine($"Height        : {number.MaxHeight}");
                Console.WriteLine($"Stopping time : {number.StoppingTime}");
            }
        }
    }
}