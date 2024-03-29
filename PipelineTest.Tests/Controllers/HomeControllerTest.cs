﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PipelineTest;
using PipelineTest.Controllers;

namespace PipelineTest.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
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
        public void About()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [TestMethod]
        public void Contact()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        private int thisWillFail = 10;
        private int thisWillSucceed = 9;

        [TestMethod]
        public void FailTest()
        {

            HomeController controller = new HomeController();

            ViewResult result = controller.AddNumbers() as ViewResult;

            Assert.AreEqual(thisWillFail, result.ViewBag.Result);
        }

        [TestMethod]
        public void SucceedTest()
        {

            HomeController controller = new HomeController();

            ViewResult result = controller.AddNumbers() as ViewResult;

            Assert.AreEqual(thisWillSucceed, result.ViewBag.Result);
        }
    }
}
