using MyTestingGround.DataAccess.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MyTestingGround.DomainObjects;
using System.Collections.Generic;
using System.Linq;

namespace ServiceTests
{
    
    
    /// <summary>
    ///This is a test class for EmployeeRepositoryTest and is intended
    ///to contain all EmployeeRepositoryTest Unit Tests
    ///</summary>
    [TestClass()]
    public class EmployeeRepositoryTest
    {

        private static  IEmployeeRepository employeeRepository;
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
            employeeRepository = new EmployeeRepositoryEF(); 
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


              /// <summary>
        ///A test for FindAll
        ///</summary>
        [TestMethod()]
        public void FindAllEmployees()
        {
            IEmployeeRepository target = new EmployeeRepositoryEF(); // TODO: Initialize to an appropriate value
            IList<IEmployee> k = target.FindAll().ToList<IEmployee>();
            Assert.IsNotNull(k, "Should find atleast one employee from the list.");           
        }     
    }
}
