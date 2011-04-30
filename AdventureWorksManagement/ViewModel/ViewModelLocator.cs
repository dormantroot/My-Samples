using Microsoft.Practices.Unity;
using GalaSoft.MvvmLight;
using AdventureWorksManagement.ServiceAgents;
using AdventureWorksManagement.Model;
using AdventureWorksManagement.ServiceAgents.Proxy_Adapters;

namespace AdventureWorksManagement.ViewModel
{
    /// <summary>
    /// ViewModel locator
    /// </summary>
    public class ViewModelLocator
    {
        /// <summary>
        /// Gets the Unity container.
        /// </summary>
        public static IUnityContainer Container
        {
            get;
            private set;
        }

        /// <summary>
        /// Initializes the <see cref="ViewModelLocator"/> class.
        /// </summary>
        static ViewModelLocator()
        {           
            // define the Unity container and its settings
            Container = new UnityContainer()
                                  .RegisterType<IBaseModel, EmployeeModel>()
                                  .RegisterType<IProxyObjectAdapter, EmployeeProxyObjectAdapter>()
                                  .RegisterType<IViewModel, EmployeeViewModel>(new ContainerControlledLifetimeManager());
                                 

            if (ViewModelBase.IsInDesignModeStatic)
            {
                // create a dummy Model provider
            }
            else
            {
                Container .RegisterType(typeof(IAdventureWorksRepository<>), typeof(AdventureWorksWCFRepository));
            }

         
        }


        /// <summary>
        /// Gets the employee ViewModel.
        /// </summary>
        public EmployeeViewModel Employee
        {
            get
            {
                return Container.Resolve<EmployeeViewModel>();
            }
        }

        /// <summary>
        /// Cleans up all the resources.
        /// </summary>
        public static void Cleanup()
        {
           
        }
    }
}
