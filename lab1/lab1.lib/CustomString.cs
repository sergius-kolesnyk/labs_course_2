using System;

namespace Nau.Lib
{
    public class CustomString
    {
        private char[] characters;

        public CustomString(char[] characters)
        {
            if (!ValidateInput(characters))
            {
                throw new ArgumentException();
            }
            this.characters = characters;
        }

        public char[] Value()
        {
            return characters;
        }

        public int Length()
        {
            return characters.Length;
        }

        ~CustomString()
        {
            this.characters = null;
        }

        public void Reverse()
        {
            char temp;
            int start = 0;
            int end = Length() - 1;

            while (start < end)
            {
                temp = characters[start];
                characters[start] = characters[end];
                characters[end] = temp;
                start++;
                end--;
            }
        }

        private bool ValidateInput(char[] characters)
        {
            foreach (char c in characters)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }

    }
}
