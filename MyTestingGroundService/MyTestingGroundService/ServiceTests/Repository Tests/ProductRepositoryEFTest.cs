using MyTestingGround.DataAccess.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MyTestingGround.DomainObjects;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ServiceTests
{
    
    
    /// <summary>
    ///This is a test class for ProductRepositoryEFTest and is intended
    ///to contain all ProductRepositoryEFTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ProductRepositoryEFTest
    {

        private static IProductRepository productRepository;
        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        [ClassInitialize()]
        public static void MyClassInitialize(TestContext testContext)
        {
            productRepository = new ProductRepositoryEF();
        }
        
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        [TestMethod()]
        public void Given_ProductID_Should_Return_Product_Details()
        {
            int productID = 320;

            IEnumerable<IProduct> product = productRepository.FindWhere((p) =>{
                return (p as Product).ProductID == productID ? true : false;
            }
            );

            Assert.IsNotNull(product, "Should find atleast one product with the given product ID {0 }.", productID);
        }      
    }
}
