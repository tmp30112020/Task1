using Xunit;

namespace Task2.xUnitTest
{
    public class ConteinerNumberValidatorCheck
    {
        [Fact]
        public void IsCodeValid_Empty()
        {
            ContainerNumberValidator cv = new ContainerNumberValidator();
            Assert.False(cv.IsValid(""));
        }

        [Fact]
        public void IsCodeValid_EmptySpace()
        {
            ContainerNumberValidator cv = new ContainerNumberValidator();
            Assert.False(cv.IsValid(" "));
        }

        [Fact]
        public void IsCodeValid_TFGU4112227()
        {
            ContainerNumberValidator cv = new ContainerNumberValidator();
            Assert.True(cv.IsValid("TFGU4112227"));
        }

        [Fact]
        public void IsCodeValid_tfgu4112227()
        {
            ContainerNumberValidator cv = new ContainerNumberValidator();
            Assert.True(cv.IsValid("tfgu4112227"));
        }

        [Fact]
        public void IsCodeValid_TFGU41122287()
        {
            ContainerNumberValidator cv = new ContainerNumberValidator();
            Assert.False(cv.IsValid("TFGU41122287"));
        }

        [Fact]
        public void IsCodeValid_TFGU4112227__()
        {
            ContainerNumberValidator cv = new ContainerNumberValidator();
            Assert.True(cv.IsValid("TFGU4112227 "));
        }

        [Fact]
        public void IsCodeValid_TFGU4_12227()
        {
            ContainerNumberValidator cv = new ContainerNumberValidator();
            Assert.False(cv.IsValid("TFGU4$12227"));
        }

        [Fact]
        public void IsCodeValid_TFGU411222B()
        {
            ContainerNumberValidator cv = new ContainerNumberValidator();
            Assert.False(cv.IsValid("TFGU411222B"));
        }

        [Fact]
        public void IsCodeValid_BLXM1122110()
        {
            ContainerNumberValidator cv = new ContainerNumberValidator();
            Assert.False(cv.IsValid("BLXM1122110"));
        }

        [Fact]
        public void IsCodeValid_BLXM1122212()
        {
            ContainerNumberValidator cv = new ContainerNumberValidator();
            Assert.True(cv.IsValid("BLXM1122212"));
        }
    }
}
