using  AdventureWorksManagement.Model;
using System;

namespace AdventureWorksManagement.ServiceAgents.Proxy_Adapters
{
    /// <summary>
    /// Interface for all proxy adapter class
    /// </summary>
    public interface IProxyObjectAdapter
    {
        void Adapt(EmployeeModel adaptee, Action<AdvWorksManagementService.Employee> adapteePredicate);
        void Adapt(AdvWorksManagementService.Employee adaptee, Action<EmployeeModel> adapteePredicate);
    }
}
