using BL = MyTestingGround.BusinessLogic;
using DO = MyTestingGround.DomainObjects;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace SOS.ServiceImplementation
{

    public partial class AdventureWorksService
    {
        public override MessageContracts.EmployeeResponse GetEmployees()
        {
            try
            {
                Thread.Sleep(10000);
                // retrieve employees
                BL.Controllers.EmployeeController employeeController = new BL.Controllers.EmployeeController();


                List<DO.IEmployee> employeeList = employeeController.Employees().Where(p =>
                {
                    return (p as DO.Employee).EmployeeID > 160 && (p as DO.Employee).EmployeeID < 170 ? true : false;
                }).ToList();

                // Translate to web service data contracts
                MessageContracts.EmployeeResponse k = new MessageContracts.EmployeeResponse();
                k.Employees = new DataContracts.Employees();


                foreach (DO.IEmployee item in employeeList)
                {
                    DataContracts.Employee emp = new DataContracts.Employee();
                    emp.Id = (item as DO.Employee).EmployeeID;
                    emp.Title = (item as DO.Employee).Title;
                    emp.Gender = (item as DO.Employee).Gender;

                    emp.PurchaseOrders = new List<DataContracts.PurchaseOrder>();
                    var poList = employeeController.RetrieveEmployeePurchaseOrders(item).ToList();

                    foreach (DO.PurchaseOrderHeader po in poList)
                    {
                        DataContracts.PurchaseOrder ppo = new DataContracts.PurchaseOrder();
                        ppo.PurchaseOrderID = po.PurchaseOrderID;

                        emp.PurchaseOrders.Add(ppo);
                    }

                    k.Employees.Add(emp);
                }

                return k;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
           
        }


        /// <summary>
        /// Gets the purchase order details.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public override MessageContracts.PurchaseOrderDetailsResponse GetPurchaseOrderDetails(MessageContracts.PurchaseOrderDetailsRequest request)
        {
            BL.Controllers.OrderController orderController = new BL.Controllers.OrderController();
            IEnumerable<DO.IPurchaseOrderHeader> podetails = orderController.PurchaseOrderDetails(new DO.PurchaseOrderHeader() { PurchaseOrderID = request.PurchaseOrderID });

            // Translate to web service data contracts
            MessageContracts.PurchaseOrderDetailsResponse poDetailResponse = new MessageContracts.PurchaseOrderDetailsResponse();
            DataContracts.PurchaseOrderDetails poDetailList = new DataContracts.PurchaseOrderDetails();


            foreach (DO.PurchaseOrderHeader item in podetails)
            {
                foreach (DO.PurchaseOrderDetail k in item.PurchaseOrderDetails)
                {
                    DataContracts.PurchaseOrderDetail poDetail = new DataContracts.PurchaseOrderDetail();
                    poDetail.DueDate = k.DueDate;
                    poDetail.LineTotal = k.LineTotal;
                    poDetail.OrderQty = k.OrderQty;
                    poDetail.ProductID = k.ProductID;
                    poDetail.ReceivedQty = k.ReceivedQty;
                    poDetail.UnitPrice = k.UnitPrice;

                    poDetailList.Add(poDetail);
                }
            }

            poDetailResponse.PurchaseOrderDetails = poDetailList;
            return poDetailResponse;
        }
    }    
}

