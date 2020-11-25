using System;

namespace Nau.Lib
{
    public class CustomString
    {
        public char[] Value { get; set; }

        public CustomString(char[] characters)
        {
            Value = characters;
        }

        public int Length()
        {
            return Value.Length;
        }

        public void RemoveDoubleSymbols(char symbol)
        {
            var characters = Value;

            int i = 0;
            int j = 0;
            while (i != characters.Length)
            {
                while (i + 1 < characters.Length && characters[i] == symbol && characters[i + 1] == symbol)
                {
                    i++;
                }

                characters[j] = characters[i];
                j++;
                i++;
            }
            char[] newArray = new char[j];
            Array.Copy(characters, newArray, j);
            Value = newArray;
        }

        public void Trim()
        {
            var characters = Value;
            int from = 0;
            int to = characters.Length;

            for (int i = 0; i < characters.Length; i++)
            {
                if (!Char.IsWhiteSpace(characters[i]))
                {
                    from = i;
                    break;
                }
            }

            for (int i = characters.Length - 1; i >= 0; i--)
            {
                if (!Char.IsWhiteSpace(characters[i]))
                {
                    to = i;
                    break;
                }
            }

            char[] newArray = new char[to];
            Array.Copy(characters, from, newArray, 0, to);
            Value = newArray;
        }

    }
}
