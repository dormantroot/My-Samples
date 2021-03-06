﻿using MyTestingGround.DataAccess.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MyTestingGround.DomainObjects;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ServiceTests
{
    
    
    /// <summary>
    ///This is a test class for PurchaseOrderHeaderRepositoryEFTest and is intended
    ///to contain all PurchaseOrderHeaderRepositoryEFTest Unit Tests
    ///</summary>
    [TestClass()]
    public class PurchaseOrderHeaderRepositoryEFTest
    {

        private static IPurchaseOrderRepository purchaseOrderHeaderRepository;
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
            purchaseOrderHeaderRepository = new PurchaseOrderRepositoryEF();
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
        public void Given_EmployeeID_Should_Return_Atleast_One_PurchaseOrderHeader()
        {
            int employeeID = 274;
            IEnumerable<IPurchaseOrderHeader> expected = purchaseOrderHeaderRepository.FindWhere((p) =>
            {
                return (p as PurchaseOrderHeader).EmployeeID == employeeID ? true : false;         
            });

           

            Assert.IsNotNull(expected, "Should find atleast one PurchaseOrderHeader for the given employeeID {0 }.",employeeID);
        }

      
    }
}
