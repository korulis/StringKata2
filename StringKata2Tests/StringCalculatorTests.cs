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
        public void Adds(int expectedSum, string numbers)
        {
            var actual = _sut.Add(numbers);

            Assert.AreEqual(expectedSum, actual);
        }


    }

}
