using System;
using NUnit.Framework;
using TestNinja.Fundamentals;


namespace TestNinja.UnitTests
{
    [TestFixture]
    public class DemeritPointsCalculatorTests
    {
        [Test]
        [TestCase(-1)]
        [TestCase(301)]
        
        public void CalculateDemeritPoints_SpeedIsOutOfRange_ReturnThrowArgumentOutOfRangeException(int speed)
        {
            var demeritPointsCalculator = new DemeritPointsCalculator();
            
            Assert.That(() => demeritPointsCalculator.CalculateDemeritPoints(speed), 
                Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
            
            /*try Example old fashion
            {
                demeritPointsCalculator.CalculateDemeritPoints(-1);
                Assert.Fail("An exception was not thrown for an invalid argument."); 
            }
            catch (ArgumentOutOfRangeException ex){
                //Do nothing, test passes if Assert.Fail() was not called
            }*/
        }
        
        [Test]    
        [TestCase(0, 0)]
        [TestCase(64, 0)]
        [TestCase(65, 0)]
        [TestCase(67, 0)]
        [TestCase(70, 1)]
        [TestCase(75, 2)]
        public void CalculateDemeritPoints_WhenCalled_ReturnDemeritPoints(int speed, int expectedResult)
        {
            var demeritPointsCalculator = new DemeritPointsCalculator();
            
            var result = demeritPointsCalculator.CalculateDemeritPoints(speed);
            
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}