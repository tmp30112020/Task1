namespace Task2
{
    public class AlphasymbolDecoder : ICharDecoder
    {
        public int Decode(char character)
        {
            int pos = (int)character % 32 - 1;
            var calc = (pos - 1) / 10 + ((pos - 1) < 0 ? 0 : 1);
            return (pos + 10 + calc);
        }
    }
}
