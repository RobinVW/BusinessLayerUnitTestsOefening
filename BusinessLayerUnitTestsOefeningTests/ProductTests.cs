using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLayerUnitTestsOefening;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayerUnitTestsOefening.Tests
{
    [TestClass()]
    public class ProductTests
    {
        private Product _product;

        [AssemblyInitialize]
        public static void AssemblyInit(TestContext context)
        {
            // Executes once before the test run. (Optional)
        }

        [ClassInitialize]
        public static void TestFixtureSetup(TestContext context)
        {
            // Executes once for the test class. (Optional)
        }

        [TestInitialize]
        public void Setup()
        {
            _product = new Product("Bier", 2);
        }

        [AssemblyCleanup]
        public static void AssemblyCleanup()
        {
            // Executes once after the test run. (Optional)
        }

        [ClassCleanup]
        public static void TestFixtureTearDown()
        {
            // Runs once after all tests in this class are executed. (Optional)
            // Not guaranteed that it executes instantly after all tests from the class.
        }

        [TestCleanup]
        public void TearDown()
        {
            // Runs after each test. (Optional)
        }
        [TestMethod()]
        public void ProductConstructorTest()
        {
            // Arrange 
            string naam = "Bier";
            int prijs = 2;

            // Act 
            Product actual = new Product(naam, prijs);

            // Assert    
            Assert.AreEqual(_product.Naam, actual.Naam);
            Assert.AreEqual(_product.Prijs, actual.Prijs);
        }


        [TestMethod]
        public void MethodName_condition_expectedValue()
        {
            // Arrange 


            // Act 


            // Assert           

        }
    }
}