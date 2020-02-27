using System.Diagnostics;
using System.Text.RegularExpressions;
using TestNinja.Fundamentals;
using NUnit.Framework;
using System.IO;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class MathTests
    {
        private Math _math;

        //Setup
        //TearDown

        [SetUp]
        public void SetUp()
        {
            _math = new Math();
        }

        [Test]
        //[Ignore("Because I wanted to!")]
        public void Add_WhenCalled_ReturnTheSumOfArguments()
        {
            //var math = new Math();

            //Debug.Assert(_math != null, nameof(_math) + " != null");
            var result = _math.Add(1, 2);

            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        [TestCase(2, 1,2)]
        [TestCase(1, 2, 2)]
        [TestCase(1, 1, 1)]
        public void Max_WhenCalled_ReturnTheGreaterArgument(int a, int b, int expectedResult)
        {
            //var math = new Math();

            var result = _math.Max(a, b);

            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
