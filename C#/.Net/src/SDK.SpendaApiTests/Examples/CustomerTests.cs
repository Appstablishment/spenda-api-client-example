using Microsoft.VisualStudio.TestTools.UnitTesting;
using SDK.SpendaApi.Examples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.SpendaApi.Examples.Tests
{
    [TestClass()]
    public class CustomerTests : BaseTests
    {
        [TestMethod()]
        public void CustomerTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetAllCustomersTest()
        {
            LoginAndGetToken();
            //var request = new RestRequest("/api/login", Method.POST);
            //  AddHeaders(ref request);

        }

        [TestMethod()]
        public void GetCustomerSearchByNameRefNumberTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetCustomerByIdTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void CreateCustomerTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void UpdateCustomerTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void getCustomerObjectTest()
        {
            Assert.Fail();
        }
    }
}