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
        public void One()
        {
            var arg = "1";
            var actual = _sut.Add(arg);

            Assert.AreEqual(1, actual);

        }

        [Test]
        public void Two()
        {
            var arg = "2";
            var actual = _sut.Add(arg);

            Assert.AreEqual(2, actual);
        }


        [Test]
        public void TemplateTest()
        {
            var arg = string.Empty;
            var actual = _sut.Add(arg);
        }
    }
}
