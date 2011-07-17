
using System.ComponentModel;

namespace AdventureWorksManagement.Model
{
    /// <summary>
    /// Interface for all model elements
    /// </summary>
    public interface IBaseModel
    {
       
    }


    /// <summary>
    /// Employee model
    /// </summary>
    public class EmployeeModel : IBaseModel
    {
       public string Title { get; set; }
       public string ID { get; set; }
       public string Gender { get; set; }
    }
   
}
