using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumericSequence;
using NumericSequence.Controllers;
using NumericSequence.Models;

namespace NumericSequence.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void GetAllNumbers()
        {
            HomeController controller = new HomeController();
            string str = controller.GetAllNumbers(15);
            Assert.AreEqual("0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15", str);
        }

        [TestMethod]
        public void GetOddNumbers()
        {
            HomeController controller = new HomeController();
            string str = controller.GetOddNumbers(15);
            Assert.AreEqual("1, 3, 5, 7, 9, 11, 13, 15", str);
        }

        [TestMethod]
        public void GetEvenNumbers()
        {
            HomeController controller = new HomeController();
            string str = controller.GetEvenNumbers(15);
            Assert.AreEqual("0, 2, 4, 6, 8, 10, 12, 14", str);
        }

        [TestMethod]
        public void GetCustomisedNumbers()
        {
            HomeController controller = new HomeController();
            string str = controller.GetCustomisedNumbers(20);
            //Assert.AreEqual("Z, 1, 2, C, 4, E, C, 7, 8, C, E, 11, C, 13, 14, Z", str);
            Console.WriteLine(str);
        }

        [TestMethod]
        public void FibonacciNumbers()
        {
            HomeController controller = new HomeController();
            string str = controller.GetFibonacciNumbers(15);
            Assert.AreEqual("0, 1, 1, 2, 3, 5, 8, 13", str);
        }

        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void IndexPost()
        {
            HomeController controller = new HomeController();

            NumberViewModel nVM = new NumberViewModel();
            nVM.InputNumber = -5;
            // Act
            ViewResult result = controller.IndexPost(nVM) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void About()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.AreEqual("Numeric Sequence Calculator", result.ViewBag.Message);
        }

        [TestMethod]
        public void Instructions()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Instructions() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }


        
    }
}
