using System.Windows.Input;
namespace AdventureWorksManagement.ModelView
{
    /// <summary>
    /// Base definition for EmployeeViewModel
    /// </summary>
    public interface IEmployeeViewModel 
    {
        ICommand LoadCommand { get; }  
    }
}
