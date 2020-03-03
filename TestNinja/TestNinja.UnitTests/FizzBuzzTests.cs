using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        public void GetOutput_InputDivisibleByThreeAndFive_ReturnFizzBuzz()
        {
            var result = FizzBuzz.GetOutput(15);
            
            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }
        
        [Test]
        public void GetOutput_InputDivisibleByFive_ReturnBuzz()
        {
            var result = FizzBuzz.GetOutput(10);
            
            Assert.That(result, Is.EqualTo("Buzz"));
        }
            
        [Test]
        public void GetOutput_InputDivisibleByThree_ReturnFizz()
        {
            //var fizzBuzz = new FizzBuzz();

            var result = FizzBuzz.GetOutput(9);
            
            Assert.That(result, Is.EqualTo("Fizz"));
        }

        [Test]
        public void GetOutput_InputIndivisible_ReturnInputNumber()
        {
            var result = FizzBuzz.GetOutput(1);
            
            Assert.That(result, Is.EqualTo("1"));

        }
    }
}