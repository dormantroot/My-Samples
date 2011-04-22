using System.Windows.Controls;
using AdventureWorksManagement.ModelView;
using AdventureWorksManagement.AdvWorksManagementService;
using System.Collections.ObjectModel;
namespace AdventureWorksManagement
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();

            //var vm = new EmployeeViewModel();
            //DataContext = vm;

            //EmployeeViewModel k = new EmployeeViewModel();
            //k.GetCustomers();            

            //ObservableCollection<AdventureWorksManagement.AdvWorksManagementService.Employee> kou = new ObservableCollection<Employee>();

            //AdvWorksManagementService.EmployeeServiceContractClient k = new AdvWorksManagementService.EmployeeServiceContractClient();

            //k.GetEmployeesCompleted += (s, e) =>
            //{
            //    if (e.Error != null)
            //    {
            //        textBlock1.Text = e.Error.ToString();
            //    }
            //    else
            //    {
            //         textBlock1.Text = e.Result.Count.ToString();
            //    }

            //};
            //k.GetEmployeesAsync();
        }
    }
}
