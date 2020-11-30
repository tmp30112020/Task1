using Xunit;

namespace Task2.xUnitTest
{
   
        public class NumberDecoderCheck
        {
            [Fact]
            public void TestDigit2()
            {
                NumberDecoder nd = new NumberDecoder();
                Assert.Equal(2, nd.Decode('2'));
            }

            [Fact]
            public void TestDigit0()
            {
                NumberDecoder nd = new NumberDecoder();
                Assert.Equal(0, nd.Decode('0'));
            }
        }
}
