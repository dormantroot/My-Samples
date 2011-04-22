using System;
using WCF = global::System.ServiceModel;
using BL = MyTestingGround.BusinessLogic;
using DO = MyTestingGround.DomainObjects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SOS.ServiceImplementation
{

    public partial class AdventureWorksService
    {
        public override MessageContracts.EmployeeResponse GetEmployees()
        {
            // retrieve employees
            BL.Controllers.EmployeeController employeeController = new BL.Controllers.EmployeeController();
            List<DO.IEmployee> employeeList = employeeController.Employees().ToList();

            // Translate to web service data contracts
            MessageContracts.EmployeeResponse k = new MessageContracts.EmployeeResponse();
            k.Employees = new DataContracts.Employees();


            foreach (DO.IEmployee item in employeeList)
            {
                DataContracts.Employee emp = new DataContracts.Employee();
                emp.Id = (item as DO.Employee).ContactID;
                emp.Title = (item as DO.Employee).Title;
                emp.Gender = (item as DO.Employee).Gender;

                k.Employees.Add(emp);
            }

            return k;
        }
    }

}

