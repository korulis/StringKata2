using NUnit.Framework;
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
        public void Zero()
        {
            var actual = _sut.Add(string.Empty);

            Assert.AreEqual(0, actual);
        }



        [Test]
        public void TemplateTest()
        {
            var actual = _sut.Add(string.Empty);
        }
    }
}
