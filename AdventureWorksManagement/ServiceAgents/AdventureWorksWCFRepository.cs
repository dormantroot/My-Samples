using System;

using AdventureWorksManagement.AdvWorksManagementService;
using AdventureWorksManagement.Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using AdventureWorksManagement.ServiceAgents.Proxy_Adapters;

namespace AdventureWorksManagement.ServiceAgents
{  
     
    /// <summary>
    /// Repository for WCF agents
    /// </summary>
    public class AdventureWorksWCFRepository<T> : IAdventureWorksRepository<IBaseModel> where T: IProxyObjectAdapter
    {
        /// <summary>
        /// WCF service end
        /// </summary>
        private readonly AdvWorksManagementService.EmployeeServiceContractClient servicePoint;

        /// <summary>
        /// Adapter used to translate WCF proxy objects to domain objects
        /// </summary>
        private T proxyobjectAdapter;

        /// <summary>
        /// Initializes a new instance of the <see cref="AdventureWorksWCFRepository"/> class.
        /// </summary>
        public AdventureWorksWCFRepository(T proxyAdapter)
        {
            proxyobjectAdapter = proxyAdapter;            
            servicePoint = new AdventureWorksManagement.AdvWorksManagementService.EmployeeServiceContractClient();
        }

        /// <summary>
        /// Get all employees.
        /// </summary>
        /// <param name="handleEmployees">The handle employees.</param>
        public void GetEmployees(Action<IEnumerable<IBaseModel>> handleEmployees)
        {           
            Collection<IBaseModel> employees;

            servicePoint.GetEmployeesCompleted += (s, e) =>
                {
                    employees = new Collection<IBaseModel>();                 

                    foreach (Employee item in e.Result)
                    {
                        proxyobjectAdapter.Adapt(item,(em) =>
                            {
                                employees.Add(em);
                            });
                    }
                    
                    handleEmployees(employees);
                };

            servicePoint.GetEmployeesAsync();
        }     
    }
}
