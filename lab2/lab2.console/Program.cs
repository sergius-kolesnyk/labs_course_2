using System;
using Nau.Lib;

namespace Nau.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var text0 = new Text();
            var line0 = new CustomString(new char[] { 'L', 'o', 'r', 'e', 'm', ' ', 'i', 'p', 's', 'u', 'm', ' ', 'd', 'o', 'l', 'o', 'r', ' ', 's', 'i', 't', ' ', 'a', 'm', 'e', 't', ',' });
            var line1 = new CustomString(new char[] { 'c', 'o', 'n', 's', 'e', 'c', 't', 'e', 't', 'u', 'r', ' ', 'a', 'd', 'i', 'p', 'i', 's', 'c', 'i', 'n', 'g', ' ', 'e', 'l', 'i', 't', '.' });

            text0.AddLine(line0);
            text0.AddLine(line1);

            PrintText(text0);

            int minLineLength = text0.GetMinLineLength();
            Console.WriteLine("Min line length: " + minLineLength);

            text0.RemoveLine(line0);
            Console.WriteLine("Text after RemoveLine.");
            PrintText(text0);

            minLineLength = text0.GetMinLineLength();
            Console.WriteLine("Min line length: " + minLineLength);


            var text1 = new Text();
            var line2 = new CustomString(new char[] { ' ', 'a', ' ', ' ', 'b', 'c', 'A', 'E', ' ', ' ' });
            var line3 = new CustomString(new char[] { 'A', 'B', 'C', 'D' });

            text1.AddLine(line2);
            text1.AddLine(line3);

            double сonsonantsRate = text1.CountСonsonantsRate();
            Console.WriteLine("Consonants rate: " + сonsonantsRate + "%");

            PrintText(text1);
            text1.RemoveDoubleSymbols(' ');
            Console.WriteLine("Text after RemoveDoubleSymbols.");
            PrintText(text1);

            text1.Trim();
            Console.WriteLine("Text after Trim.");
            PrintText(text1);
        }

        private static void PrintText(Text text)
        {
            foreach (var line in text)
            {
                Console.WriteLine(line.Value);
            }
        }
    }
}
