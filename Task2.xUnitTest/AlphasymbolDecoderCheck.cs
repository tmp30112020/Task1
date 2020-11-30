using Xunit;

namespace Task2.xUnitTest
{
    public class AlphasymbolDecoderCheck
    {
        [Fact]
        public void TestSymbol_a()
        {
            AlphasymbolDecoder nd = new AlphasymbolDecoder();
            Assert.Equal(10, nd.Decode('a'));
        }

        [Fact]
        public void TestSymbol_A()
        {
            AlphasymbolDecoder nd = new AlphasymbolDecoder();
            Assert.Equal(10, nd.Decode('A'));
        }
        [Fact]
        public void TestSymbol_K()
        {
            AlphasymbolDecoder nd = new AlphasymbolDecoder();
            Assert.Equal(21, nd.Decode('K'));
        }
        [Fact]
        public void TestSymbol_k()
        {
            AlphasymbolDecoder nd = new AlphasymbolDecoder();
            Assert.Equal(21, nd.Decode('k'));
        }
        [Fact]
        public void TestSymbol_V()
        {
            AlphasymbolDecoder nd = new AlphasymbolDecoder();
            Assert.Equal(34, nd.Decode('V'));
        }
    }
}
