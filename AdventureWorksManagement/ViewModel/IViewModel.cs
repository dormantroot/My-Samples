using System.Windows.Input;
namespace AdventureWorksManagement.ViewModel
{
    /// <summary>
    /// Base definition for ViewModel
    /// </summary>
    public interface IViewModel 
    {
        ICommand LoadCommand { get; }  
    }
}
