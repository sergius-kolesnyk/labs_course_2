using System;

namespace Nau.Lib
{
    public class Letters : CustomString
    {
        public Letters(char[] characters) : base(characters) { }

        public override int Length()
        {
            return characters.Length;
        }

        public override void RemoveSymbol()
        {
            base.RemoveSymbol('a');
        }

        public override char[] Value()
        {
            return characters;
        }

        protected override bool ValidateInput(char[] characters)
        {
            foreach (char c in characters)
            {
                if (!Char.IsLetter(c))
                    return false;
            }
            return true;
        }
    }
}