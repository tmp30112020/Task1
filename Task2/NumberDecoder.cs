using System;

namespace Task2
{
   public class NumberDecoder : ICharDecoder
    {
        public int Decode(char character)
        {
            return (int)Char.GetNumericValue(character);
        }
    }
}
