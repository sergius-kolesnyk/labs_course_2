using System;

namespace Nau.Lib
{
    public class Numbers : CustomString
    {
        public Numbers(char[] characters) : base(characters) { }

        public override int Length()
        {
            return characters.Length;
        }

        public override void RemoveSymbol()
        {
            base.RemoveSymbol('5');
        }

        public override char[] Value()
        {
            return characters;
        }

        protected override bool ValidateInput(char[] characters)
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
