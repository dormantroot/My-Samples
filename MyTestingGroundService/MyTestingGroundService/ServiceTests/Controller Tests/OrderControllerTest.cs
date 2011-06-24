using MyTestingGround.BusinessLogic.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MyTestingGround.DomainObjects;
using System.Collections.Generic;
using System.Linq;

namespace ServiceTests
{
    
    
    /// <summary>
    ///This is a test class for OrderControllerTest and is intended
    ///to contain all OrderControllerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class OrderControllerTest
    {


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
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
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
        public void Order_Details_Should_Exist_For_The_Given_Purchase_Order_Header()
        {
            int purchaseHeaderID = 1122;
            OrderController target = new OrderController();
            IEnumerable<IPurchaseOrderHeader> details = target.PurchaseOrderDetails(new PurchaseOrderHeader() { PurchaseOrderID = purchaseHeaderID });



            Assert.IsNotNull((details.FirstOrDefault<IPurchaseOrderHeader>() as PurchaseOrderHeader).PurchaseOrderDetails, "Purchase order header with this ID {0 } should have associated purchase details.", purchaseHeaderID);  
        }


        [TestMethod()]
        public void Product_Details_Should_Exist_For_The_Given_Product_Order_ID()
        {
            int productID = 320;
            OrderController target = new OrderController();
            IEnumerable<IProduct> details = target.ProductDetails(new Product() { ProductID = productID });

            Assert.IsNotNull(details, "Product with this ID {0 } should have associated details.", productID);
        }
    }
}
