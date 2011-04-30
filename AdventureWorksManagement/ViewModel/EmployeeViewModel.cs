
using AdventureWorksManagement.ServiceAgents;
using AdventureWorksManagement.Model;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight;

namespace AdventureWorksManagement.ViewModel
{
    /// <summary>
    /// Employee ViewModel class
    /// </summary>
    public class EmployeeViewModel : ViewModelBase, IViewModel
    {
       #region ---------------------- PRIVATE PROPERTIES ----------------------
       IAdventureWorksRepository<IBaseModel> serviceAgent;

       private String title;
       private String m_Message;
       private ObservableCollection<IBaseModel> employees;
     
       #endregion ------------------- PRIVATE PROPERTIES ----------------------

       #region ---------------------- PUBLIC PROPERTIES ----------------------
       /// <summary>
       /// Gets the employees observable collection.
       /// </summary>
       public ObservableCollection<IBaseModel> Employees
       {
           get
           {
               return employees;
           }

           set
           {
               employees = value;
               RaisePropertyChanged("Employees");
           }
           
       }

       /// <summary>
       /// Gets or sets the title.
       /// </summary>
       /// <value>
       /// The title.
       /// </value>
       public string Title 
       {
           get
           {
               return title;
           }
           set
           {
               title = value;               
           }
       }


       /// <summary>
       /// Gets or sets the message.
       /// </summary>
       /// <value>
       /// The message.
       /// </value>
       public String Message
       {
           get
           {
               return m_Message;
           }
           set
           {
               m_Message = value;
               RaisePropertyChanged("Message");
           }
       }

       /// <summary>
       /// Gets the load command.
       /// </summary>
       public ICommand LoadCommand { get; private set; }

       #endregion ------------------- PUBLIC PROPERTIES ----------------------

       #region ------------------------ CONSTRUCTORS -------------------------
       /// <summary>
       /// Initializes a new instance of the <see cref="EmployeeViewModel"/> class.
       /// </summary>
       /// <param name="agent">The service agent.</param>
       public EmployeeViewModel(IAdventureWorksRepository<IBaseModel> agent)           
       {
           if(agent!= null)
            this.serviceAgent = agent;          

           InitializeCommands();
       }
    
       #endregion --------------------- CONSTRUCTORS -------------------------

       #region ----------------------- PRIVATE METHODS ------------------------
       /// <summary>
       /// Initializes the commands.
       /// </summary>
       private void InitializeCommands()
       {
           LoadCommand = new RelayCommand(Load);         
       }

       /// <summary>
       /// Loads this instance.
       /// </summary>
       private void Load()
       {
           try
           {
               ShowMessage("Loading...");

            
               // get customers
               serviceAgent.GetEmployees((p) =>
               {
                  Employees = new ObservableCollection<IBaseModel>(p);
                  ShowMessage(String.Empty);
               });
               
           }
           catch (Exception ex)
           {
               ShowMessage(ex.Message);
           }
       }


       /// <summary>
       /// Shows the message.
       /// </summary>
       /// <param name="message">The message.</param>
       private void ShowMessage(string message)
       {
           Message = message;          
       }
       #endregion--------------------- PRIVATE METHODS ------------------------

       #region ----------------------- PUBLIC METHODS ------------------------
      
       #endregion--------------------- PUBLIC METHODS ------------------------     
     
    }
}
