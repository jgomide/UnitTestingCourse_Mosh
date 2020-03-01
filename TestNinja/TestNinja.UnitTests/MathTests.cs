using System.Diagnostics;
using System.Text.RegularExpressions;
using TestNinja.Fundamentals;
using NUnit.Framework;
using System.IO;
using System.Linq;

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
        
        [Test]
        public void GetOddNumbers_LimitIsGreaterThanZero_ReturnOddNumbersUpToLimit()
        {
            var result = _math.GetOddNumbers(5);
            
            //in this case should write only one of this case
            //case1
            //Assert.That(result, Is.Not.Empty);
            //case2
            //Assert.That(result.Count(), Is.EqualTo(3));
            //case3
            //Assert.That(result, Does.Contain(1));
            //Assert.That(result, Does.Contain(3));
            //Assert.That(result, Does.Contain(5));
            //case4 BEST CASE IN THIS SITUATION
            Assert.That(result, Is.EquivalentTo(new [] {1,3,5}));
            
            //other options for Arrays if necessary
            //Assert.That(result, Is.Ordered);
            //Assert.That(result,Is.Unique);
        }
    }
}
