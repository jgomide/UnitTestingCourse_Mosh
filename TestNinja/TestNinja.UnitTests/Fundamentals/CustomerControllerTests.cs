using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class CustomerControllerTests
    {
        [Test]
        public void GetCustomer_IdIsZero_ReturnNotFound()
        {
            var controller = new CustomerController();

            var result = controller.GetCustomer(0);
            
            //NotFound Object
            Assert.That(result, Is.TypeOf<NotFound>());
            
            //NotFound Object or one of its derivatives
            //Assert.That(result, Is.InstanceOf<NotFound>());
        }

        [Test] //homework: done! 
        public void GetCustomer_IdIsNotZero_ReturnOk()
        {
            var controller = new CustomerController();

            var result = controller.GetCustomer(1);
            
            Assert.That(result, Is.TypeOf<Ok>());
        }
    }
}