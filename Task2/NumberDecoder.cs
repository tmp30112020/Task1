using System;

namespace Task2
{
    class NumberDecoder : ICharDecoder
    {
        public int Decode(char character)
        {
            return (int)Char.GetNumericValue(character);
        }
    }
}
