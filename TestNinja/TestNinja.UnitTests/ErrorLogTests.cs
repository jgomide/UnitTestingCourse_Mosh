using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class ErrorLogTests
    {
        [Test]
        public void Log_WhenCalled_SetTheLastErrorProperty()
        {
            var logger = new ErrorLogger();

            logger.Log("a");

            Assert.That(logger.LastError, Is.EqualTo("a"));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void Log_InvalidError_ThrowArgumentNullException(string error)
        {
            var logger = new ErrorLogger();

            //logger.Log(error); CANT DO LIKE THAT WHEN IS EXCEPTION

            Assert.That(() => //SAME SAME
            {
                logger.Log(error);
            }, Throws.ArgumentNullException);
            //Assert.That(() => logger.Log(error), Throws.Exception.TypeOf<DivideByZeroException>); EXAMPLE 
        }

        [Test]
        public void Log_ValidError_RaiseErrorLoggedEvent()
        {
            var logger = new ErrorLogger();

            var id = Guid.Empty;
            logger.ErrorLogged += (sender, args) => { id = args; };
            
            logger.Log("a");
            
            Assert.That(id, Is.Not.EqualTo(Guid.Empty));
        }
    }
}