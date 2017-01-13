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
        [InlineAutoData(3, "1,2")]
        public void SimpleSum(int expected, string arg)
        {
            var actual = _sut.Add(arg);

            Assert.AreEqual(expected, actual);
        }




        [Test]
        public void TemplateTest()
        {
            var arg = string.Empty;
            var actual = _sut.Add(arg);
        }
    }
}
