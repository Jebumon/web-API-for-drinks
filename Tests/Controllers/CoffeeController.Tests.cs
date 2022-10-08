using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using API_Interactive_Lab_1.Controllers;
using NUnit.Framework;
using FluentAssertions;
using API_Interactive_Lab_1.Models;

namespace API_Interactive_Lab_1.Tests.Controllers
{
    public class CoffeeControllerTests : ControllerBase
    {
        [Test]
        public void TestCoffeLover()
        {
            string expectedResponse = "I like coffee!";
            var controller = new CoffeeController();
            var response = controller.GetLoveCoffee();
            Assert.AreEqual(expectedResponse, response);
        }

        [Test]
        public void TestCoffe_No_Params()
        {
            Coffee expectedObject = new Coffee { Name = "latte", Id = -1};
            var controller = new CoffeeController();
            var response = controller.Get(null);
            Assert.AreEqual(expectedObject.Name, response.Name);
            Assert.AreEqual(expectedObject.Id, response.Id);
        }

        [Test]
        public void TestCoffe_With_Name()
        {
            string name = "Hot choclate";
            Coffee expectedObject = new Coffee { Name = name, Id = 7 };
            var controller = new CoffeeController();
            var response = controller.Get(name);
            Assert.AreEqual(expectedObject.Name, response.Name);
            Assert.AreEqual(expectedObject.Id, response.Id);
        }
    }
}
