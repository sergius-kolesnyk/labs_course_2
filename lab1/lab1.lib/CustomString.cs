using System;

namespace Nau.Lib
{
    public class CustomString
    {

        private int[] value;

        public CustomString(int[] value)
        {
            this.value = value;
        }

        public int[] Value()
        {
            return value;
        }

        public int Size()
        {
            return value.Length;
        }

        ~CustomString()
        {
            this.value = null;
            Console.WriteLine($"The {ToString()} destructor is executing.");
        }

        public void Reverse()
        {
            int temp;
            int start = 0;
            int end = Size() - 1;

            while (start < end)
            {
                temp = value[start];
                value[start] = value[end];
                value[end] = temp;
                start++;
                end--;
            }
        }

    }
}
