using System;

namespace Nau.Lib
{
    public abstract class CustomString
    {

        protected char[] characters;

        protected CustomString(char[] characters)
        {
            if (!ValidateInput(characters))
            {
                throw new ArgumentException();
            }
            this.characters = characters;
        }

        public abstract int Length();
        public abstract void RemoveSymbol();
        public abstract char[] Value();
        protected abstract bool ValidateInput(char[] symbols);

        protected void RemoveSymbol(char characterToRemove)
        {
            int i = 0;
            int j = 0;
            while (i < characters.Length)
            {
                if (characters[i] != characterToRemove)
                {
                    characters[j] = characters[i];
                    j++;
                }
                i++;
            }

            char[] newCharacters = new char[j];
            Array.Copy(characters, newCharacters, j);
            characters = newCharacters;
        }
    }


}
