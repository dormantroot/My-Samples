using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyTestingGroundMVC.ViewData;
using BL = MyTestingGround.BusinessLogic;

namespace MyTestingGroundMVC.Controllers
{
    public class ExamplesController: BaseController
    {
        //
        // GET: /Examples/

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
        /// Return state from the specified position
        /// in the list.
        /// </summary>
        /// <param name="position">The position.</param>
        /// <returns></returns>
        public ActionResult Employees()
        {
            // Create Employee view data
            EmployeeViewData viewData = CreateViewData<EmployeeViewData>();

            // Populate view data
            BL.Controllers.EmployeeController employeeController = new BL.Controllers.EmployeeController();
            viewData.Employees = employeeController.Employees().ToList();

            return View("ShowExamples", viewData);
        }


        public ActionResult GridData()
        {
            var jsonData = new
            {
                total = 1, // we'll implement later 
                page = 1,
                records = 3, // implement later 
                rows = new[]{
                  new {id = 1, cell = new[] {"1", "-7", "Is this a good question?"}},
                  new {id = 2, cell = new[] {"2", "15", "Is this a blatant ripoff?"}},
                  new {id = 3, cell = new[] {"3", "23", "Why is the sky blue?"}}
                }
            };
            return Json(jsonData);
        }


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
