using System;
using Nau.Lib;

namespace Nau.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var example = new CustomString(new char[] { '1', '2', '3', '4', '5' });
            var length = example.Length();
            Console.WriteLine("CustomString length: " + length);

            PrintCustoStringValue(example);

            Console.WriteLine("CustomString value after reverse.");
            example.Reverse();

            PrintCustoStringValue(example);
        }

        private static void PrintCustoStringValue(CustomString example)
        {
            Console.Write("CustomString value: ");

            foreach (var item in example.Value())
            {
                Console.Write(item.ToString());
            }
            Console.Write("\n");
        }
    }
}
