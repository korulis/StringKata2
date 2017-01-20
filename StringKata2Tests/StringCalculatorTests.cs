using NUnit.Framework;
using Ploeh.AutoFixture.NUnit3;
using StringKata2;

namespace StringKata2Tests
{
    [TestFixture]
    public class StringCalculatorTests
    {
        private StringCalculator _sut;

        [SetUp]
        public void Init()
        {
            _sut = new StringCalculator();
        }

        [Test]
        [InlineAutoData(0, "")]
        [InlineAutoData(1, "1")]
        [InlineAutoData(2, "2")]
        public void AddSingle(int expected, string input)
        {
            var actual = _sut.Add(input);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        [InlineAutoData(2, "1,1")]
        [InlineAutoData(3, "2,1")]
        [InlineAutoData(2, "2,")]
        [InlineAutoData(4, "2,1,1")]
        public void AddMultiple(int expected, string input)
        {
            var actual = _sut.Add(input);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        [InlineAutoData(6, "1\n2,3")]
        [InlineAutoData(1, "1,\n")]
        public void AddWithLineBreaks(int expected, string input)
        {
            var actual = _sut.Add(input);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        [InlineAutoData(3, "//;\n1;2")]
        //[InlineAutoData(3, "//;\n")]
        public void ChangeDelimiter(int expected, string input)
        {
            var actual = _sut.Add(input);

            Assert.AreEqual(expected, actual);
        }

    }
}
