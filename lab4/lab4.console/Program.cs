using System;
using Nau.Lib;

namespace Nau.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomString numbers = new Numbers(new char[] { '1', '2', '3', '5', '5', '7', '5' });
            Demo(numbers);

            CustomString letters = new Letters(new char[] { 'a', 'b', 'c', 'd' });
            Demo(letters);
        }

        private static void Demo(CustomString customString)
        {
            Console.WriteLine("CustomString before RemoveSymbol method");
            Console.WriteLine("Value: " + new string(customString.Value()));
            Console.WriteLine("Length: " + customString.Length());
            customString.RemoveSymbol();
            Console.WriteLine("CustomString after RemoveSymbol method");
            Console.WriteLine("Value: " + new string(customString.Value()));
            Console.WriteLine("Length: " + customString.Length());
            Console.WriteLine("");
        }
    }
}
