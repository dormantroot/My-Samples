using MyTestingGround.DataAccess.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MyTestingGround.DomainObjects;
using System.Collections.Generic;

namespace ServiceTests
{
    
    
    /// <summary>
    ///This is a test class for EmployeeRepositoryTest and is intended
    ///to contain all EmployeeRepositoryTest Unit Tests
    ///</summary>
    [TestClass()]
    public class EmployeeRepositoryTest
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


        /// <summary>
        ///A test for EmployeeRepository Constructor
        ///</summary>
        [TestMethod()]
        public void EmployeeRepositoryConstructorTest()
        {
            EmployeeRepository target = new EmployeeRepository();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Add
        ///</summary>
        [TestMethod()]
        public void AddTest()
        {
            //EmployeeRepository target = new EmployeeRepository(); // TODO: Initialize to an appropriate value
            //IEmployee entity = null; // TODO: Initialize to an appropriate value
            //target.Add(entity);
            //Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for FindAll
        ///</summary>
        [TestMethod()]
        public void FindAllEmployees()
        {
            EmployeeRepository target = new EmployeeRepository(); // TODO: Initialize to an appropriate value
            ICollection<IEmployee> actual;            
            actual = target.FindAll();
            Assert.IsNotNull(actual, "Should find atleast one employee from the list.");           
        }

        /// <summary>
        ///A test for Remove
        ///</summary>
        [TestMethod()]
        public void RemoveTest()
        {
            //EmployeeRepository target = new EmployeeRepository(); // TODO: Initialize to an appropriate value
            //IEmployee entity = null; // TODO: Initialize to an appropriate value
            //target.Remove(entity);
            //Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
