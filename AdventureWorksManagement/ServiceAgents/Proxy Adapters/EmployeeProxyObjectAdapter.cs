
using AdventureWorksManagement.Model;
using System;
using AdventureWorksManagement.AdvWorksManagementService;
namespace AdventureWorksManagement.ServiceAgents.Proxy_Adapters
{
    /// <summary>
    /// Proxy object adapter using AutoMapper
    /// </summary>
    public class EmployeeProxyObjectAdapter: IProxyObjectAdapter
    {

        /// <summary>
        /// Adapts the specified 'ViewModel' to a 'WCF' type
        /// </summary>
        /// <param name="adaptee">The adaptee.</param>
        /// <param name="adapteePredicate">The adaptee predicate.</param>
        public void Adapt(EmployeeModel adaptee, Action<Employee> adapteePredicate)
        {
          
        }


        /// <summary>
        /// Adapts the specified 'WCF' to a 'ViewModel' type
        /// </summary>
        /// <param name="adaptee">The adaptee.</param>
        /// <param name="adapteePredicate">The adaptee predicate.</param>
        public void Adapt(Employee adaptee,Action<EmployeeModel> adapteePredicate)
        {
            EmployeeModel newEmpModel = new EmployeeModel();
            newEmpModel.FirstName = adaptee.Title;
            newEmpModel.LastName = adaptee.Id.ToString();

            adapteePredicate(newEmpModel);                
        }      
    }
}
