using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyTestingGroundMVC.ViewData;
using BL = MyTestingGround.BusinessLogic;
using MyTestingGround.DomainObjects;
using Trirand.Web.Mvc;

namespace MyTestingGroundMVC.Controllers
{
    public class ExamplesController: BaseController
    {
        
        #region ---------------------- PRIVATE PROPERTIES ----------------------

        #endregion ------------------- PRIVATE PROPERTIES ----------------------

        #region ---------------------- PUBLIC PROPERTIES ----------------------

        #endregion ------------------- PUBLIC PROPERTIES ----------------------

        #region ------------------------ CONSTRUCTORS -------------------------

        #endregion --------------------- CONSTRUCTORS -------------------------

        #region ----------------------- PRIVATE METHODS ------------------------

        private void SetUpGrid(JQGrid ordersGrid)
        {
            // Customize/change some of the default settings for this model
            // ID is a mandatory field. Must by unique if you have several grids on one page.
            ordersGrid.ID = "EmployeeJqGrid";

            // Setting the DataUrl to an action (method) in the controller is required.
            // This action will return the data needed by the grid
            ordersGrid.DataUrl = Url.Action("EmployeeJqGridDataRequested");
           
            // Customize search toolbar and other buttons
            ordersGrid.ToolBarSettings.ShowSearchToolBar = false;           
            ordersGrid.ToolBarSettings.ShowEditButton = true;
            ordersGrid.ToolBarSettings.ShowAddButton = true;
            ordersGrid.ToolBarSettings.ShowDeleteButton = true;
            ordersGrid.EditDialogSettings.CloseAfterEditing = true;
            ordersGrid.AddDialogSettings.CloseAfterAdding = true;          
        }

        #endregion--------------------- PRIVATE METHODS ------------------------

        #region ----------------------- PUBLIC METHODS ------------------------

        public ActionResult Index()
        {
            return View();
        }


        /// <summary>
        /// Returns ViewData containing the states
        /// </summary>
        /// <returns></returns>
        public ActionResult States()
        {
            USStatesViewData viewData = CreateViewData<USStatesViewData>();
            //return View("StateListExample", viewData);
            return View("ShowExamples", viewData);
        }



        /// <summary>
        /// Return the employees.
        /// </summary>
        /// <returns></returns>
        public ActionResult Employees()
        {
            // Create Employee view data
            EmployeeViewData viewData = CreateViewData<EmployeeViewData>();

            // Populate view data
            BL.Controllers.EmployeeController employeeController = new BL.Controllers.EmployeeController();
            viewData.Employees = employeeController.Employees().ToList();

            return View("EmployeeExample", viewData);
        }


        /// <summary>
        /// Return employee data in EmployeeJqGridViewData model.
        /// </summary>
        /// <returns></returns>
        public ActionResult EmployeesGridData()
        {
            // Setup the EmployeesJqGridModel
            var employeeJqGridModel = new EmployeeJqGridViewData();
            var employeesGrid = employeeJqGridModel.EmployeeGrid;            

            // Customize
            SetUpGrid(employeesGrid);

            return View("EmployeeExample", employeeJqGridModel);
        }       


        // 
        /// <summary>
        /// This method is called when the EmployeeJqGrid requests data
        /// </summary>
        /// <returns></returns>
        public JsonResult EmployeeJqGridDataRequested()
        {
            // Setup the EmployeesJqGridModel
            var employeeGridModel = new EmployeeJqGridViewData();            
           
            // Retrieve employees
            BL.Controllers.EmployeeController employeeController = new BL.Controllers.EmployeeController();
           
            // return the result of the DataBind method, passing the datasource as a parameter
            // jqGrid for ASP.NET MVC automatically takes care of paging, sorting, filtering/searching, etc
            return employeeGridModel.EmployeeGrid.DataBind(employeeController.Employees().Cast<Employee>().AsQueryable());
        }
        #endregion--------------------- PUBLIC METHODS ------------------------

       


        ///// <summary>
        ///// Adds the employee.
        ///// </summary>
        ///// <returns></returns>
        //public ActionResult AddEmployee()
        //{
        //    // Create Employee view data
        //    EmployeeViewData viewData = CreateViewData<EmployeeViewData>();

        //    // Populate view data
        //    BL.Controllers.EmployeeController employeeController = new BL.Controllers.EmployeeController();
        //    employeeController.AddEmployee(employeeController.Employees().ToList()[0]);
        //    viewData.Employees = employeeController.Employees().ToList();

        //    return View("Index", viewData);
        //}


    }
}
