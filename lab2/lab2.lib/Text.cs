using System;
using System.Collections;
using System.Collections.Generic;

namespace Nau.Lib
{
    public class Text : IEnumerable<CustomString>
    {
        private const int DEFAULT_SIZE = 10;
        private int length = 0;
        private CustomString[] lines = new CustomString[DEFAULT_SIZE];

        public CustomString[] Lines()
        {
            return lines;
        }

        public void AddLine(CustomString line)
        {
            if (length == lines.Length)
            {
                int capacity = length + length * (20 / 100);
                Array.Copy(lines, lines, capacity);
            }
            lines[length] = line;
            length++;
        }

        public void RemoveLine(CustomString line)
        {
            int index = Array.IndexOf(lines, line);
            CustomString[] tmp = new CustomString[lines.Length - 1];

            int i = 0;
            int j = 0;
            while (i < lines.Length)
            {
                if (i != index)
                {
                    tmp[j] = lines[i];
                    j++;
                }

                i++;
            }

            lines = tmp;
            length--;
        }

        public void Clear()
        {
            for (int i = 0; i < length; i++)
            {
                lines[i] = null;
            }
        }

        public int GetMinLineLength()
        {
            if (length == 0)
            {
                return 0;
            }
            int shortestLineLength = lines[0].Length();

            for (int i = 0; i < length; i++)
            {
                var lineLength = lines[i].Length();
                if (lineLength < shortestLineLength)
                {
                    shortestLineLength = lineLength;
                }
            }

            return shortestLineLength;
        }

        public double CountСonsonantsRate()
        {
            int totalLettersCount = 0;
            int totalConsonantsCount = 0;

            int firstCapitalizeLetter = 65;
            int lastCapitalizeLetter = 90;
            int firstLetter = 97;
            int lastLetter = 122;

            int[] vowels = { 65, 97, 69, 101, 73, 105, 79, 111, 85, 117, 89, 121 };
            for (int i = 0; i < length; i++)
            {
                var lineLength = lines[i].Length();
                for (int j = 0; j < lineLength; j++)
                {
                    int symbol = lines[i].Value[j];
                    if ((symbol >= firstCapitalizeLetter && symbol <= lastCapitalizeLetter) || (firstLetter >= 97 && symbol <= lastLetter))
                    {
                        if (Array.IndexOf(vowels, symbol) == -1)
                        {
                            totalConsonantsCount++;
                        }
                        totalLettersCount++;
                    }
                }
            }
            return (double)totalConsonantsCount / (double)totalLettersCount * 100;
        }

        public void RemoveDoubleSymbols(char symbol)
        {
            for (int i = 0; i < length; i++)
            {
                lines[i].RemoveDoubleSymbols(symbol);
            }
        }

        public void Trim()
        {
            for (int i = 0; i < length; i++)
            {
                lines[i].Trim();
            }
        }

        public IEnumerator<CustomString> GetEnumerator()
        {
            for (int i = 0; i < length; i++)
            {
                yield return lines[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < length; i++)
            {
                yield return lines[i];
            }
        }
    }
}
