using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestPractices.Fundamentals;

namespace NUnit.TestPractices.Tests
{
    [TestFixture]
    public class CustomerControllerTests
    {
        [Test]
        public void GetCustomer_IdIsZero_ReturnNotFound()
        {
            var customerController = new CustomerController();

            var actionResult = customerController.GetCustomer(0);

            Assert.That(actionResult, Is.TypeOf(typeof(NotFound)));
        }

        [Test]
        public void GetCustomer_IdIsZero_ReturnOK()
        {
            var customerController = new CustomerController();

            var actionResult = customerController.GetCustomer(1);

            Assert.That(actionResult, Is.TypeOf<Ok>());
        }
    }
}
