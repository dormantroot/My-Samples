
using AdventureWorksManagement.ServiceAgents;
using AdventureWorksManagement.Model;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight;
using System.Threading;

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
       private String message;
       private ObservableCollection<IBaseModel> employees;
       private bool isBusy;
     
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
               return message;
           }
           set
           {
               message = value;
               RaisePropertyChanged("Message");
           }
       }

       /// <summary>
       /// Gets the load command.
       /// </summary>
       public ICommand LoadCommand { get; private set; }



       /// <summary>
       /// Gets or sets a value indicating whether this ViewModel is busy.
       /// </summary>
       /// <value>
       ///   <c>true</c> if this ViewModel is busy; otherwise, <c>false</c>.
       /// </value>      
       public bool IsBusy
       {
           get
           {
               return isBusy;
           }

           set
           {
               isBusy = value;
               AllowInteraction = value;
               RaisePropertyChanged("IsBusy");
              
           }
       }

       /// <summary>
       /// Gets a value indicating whether any of the controls tied to this ViewModel
       /// is allowed to interact.
       /// </summary>
       /// <value>
       ///   <c>true</c> if interaction allowed; otherwise, <c>false</c>.
       /// </value>
       public bool AllowInteraction
       {
           get {return !isBusy;}
           set
           {
               bool dummy = value;
               RaisePropertyChanged("AllowInteraction");
           }
       }

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
           IsBusy = false;
           Message = String.Empty;
       }

       /// <summary>
       /// Loads this instance.
       /// </summary>
       private void Load()
       {
           try
           {
               if (IsBusy)
               {
                   return;
               }

               IsBusy = true;
               Message = "Loading...";

              
               // get customers
               serviceAgent.GetEmployees((p) =>
               {                   
                  Employees = new ObservableCollection<IBaseModel>(p);
                  Message = String.Empty;
                  IsBusy = false;
               });
               
           }
           catch (Exception ex)
           {
               Message = ex.Message;
           }
       }
      
       #endregion--------------------- PRIVATE METHODS ------------------------

       #region ----------------------- PUBLIC METHODS ------------------------
      
       #endregion--------------------- PUBLIC METHODS ------------------------     
     
    }
}
