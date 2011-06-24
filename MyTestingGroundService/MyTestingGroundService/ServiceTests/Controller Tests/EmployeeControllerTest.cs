using MyTestingGround.BusinessLogic.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MyTestingGround.DomainObjects;
using System.Collections.Generic;
using System.Linq;

namespace ServiceTests
{
    
    
    /// <summary>
    ///This is a test class for EmployeeControllerTest and is intended
    ///to contain all EmployeeControllerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class EmployeeControllerTest
    {

        private static EmployeeController employeeController;
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
            employeeController = new EmployeeController();
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
        public void Purchase_Orders_Should_Exist_For_Given_Employee()
        {
            int employeeID = 274;
            EmployeeController target = new EmployeeController();
            IEnumerable<IEmployee> employeeList = target.Employees();
            IEnumerable<IPurchaseOrderHeader> orders = target.RetrieveEmployeePurchaseOrders(employeeList.Cast<Employee>().Where(p => p.EmployeeID == employeeID).FirstOrDefault());

            Assert.IsNotNull(orders, "Employee with this ID {0 } should have some purchase orders.", employeeID);          
        }
    }
}
