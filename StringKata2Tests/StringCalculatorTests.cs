using NUnit.Framework;
using NUnit.Framework.Constraints;
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
        [InlineAutoData(0, "0")]
        [InlineAutoData(0, "")]
        [InlineAutoData(1, "1")]
        public void ParsesSingle(int expectedSum, string numbers)
        {
            var actual = _sut.Add(numbers);

            Assert.AreEqual(expectedSum, actual);
        }

        [Test]
        [InlineAutoData(3, "1,2")]
        [InlineAutoData(3, "1,1,1")]
        [InlineAutoData(8, "1,4,1,2")]
        [InlineAutoData(2, "1\'\\r\\n\'1")]
        public void Adds(int expectedSum, string numbers)
        {
            var actual = _sut.Add(numbers);

            Assert.AreEqual(expectedSum, actual);
        }







    }

}
