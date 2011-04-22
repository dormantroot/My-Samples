using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Trirand.Web.Mvc;
using System.Web.UI.WebControls;
using MyTestingGroundMVC.AdvWorksManagementService;

namespace MyTestingGroundMVC.ViewData
{
    /// <summary>
    /// 
    /// </summary>
    public class EmployeeViewData : BaseViewData
    {
        #region ---------------------- PRIVATE PROPERTIES ----------------------

        #endregion ------------------- PRIVATE PROPERTIES ----------------------

        #region ---------------------- PUBLIC PROPERTIES ----------------------
        /// <summary>
        /// Gets or sets
        /// the employees.
        /// </summary>
        /// <value>The Employees.</value>
        public ICollection<Employee> Employees { get; set; }

        /// <summary>
        /// Gets or sets the subtitle.
        /// </summary>
        /// <value>The subtitle.</value>
        public string Subtitle { get; set; }
        #endregion ------------------- PUBLIC PROPERTIES ----------------------

        #region ------------------------ CONSTRUCTORS -------------------------
        /// <summary>
        /// 
        /// </summary>
        public EmployeeViewData()
        {
            // Define a subtitle
            Subtitle = "List of Employees in Adventure Works";
        }
        #endregion --------------------- CONSTRUCTORS -------------------------

        #region ----------------------- PRIVATE METHODS ------------------------

        #endregion--------------------- PRIVATE METHODS ------------------------

        #region ----------------------- PUBLIC METHODS ------------------------

        #endregion--------------------- PUBLIC METHODS ------------------------
    }


    /// <summary>
    /// JqGridModel version of EmployeeModel.
    /// </summary>
    public class EmployeeJqGridViewData : EmployeeViewData
    {
        #region ---------------------- PRIVATE PROPERTIES ----------------------

        #endregion ------------------- PRIVATE PROPERTIES ----------------------

        #region ---------------------- PUBLIC PROPERTIES ----------------------

        /// <summary>
        /// Gets or sets the employees grid.
        /// </summary>
        /// <value>The employees grid.</value>
        public JQGrid EmployeeGrid { get; set; }

        #endregion ------------------- PUBLIC PROPERTIES ----------------------

        #region ------------------------ CONSTRUCTORS -------------------------

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeJqGridViewData"/> class.
        /// </summary>
        public EmployeeJqGridViewData()
        {
            EmployeeGrid = new JQGrid
            {
                Columns = new List<JQGridColumn>()
                                 {
                                     new JQGridColumn { DataField = "EmployeeID", 
                                                        // always set PrimaryKey for Add,Edit,Delete operations
                                                        // if not set, the first column will be assumed as primary key
                                                        PrimaryKey = true,
                                                        Editable = false,
                                                        Width = 100 },
                                     new JQGridColumn { DataField = "NationalIDNumber", 
                                                        Editable = false
                                                        },
                                     new JQGridColumn { DataField = "Title", 
                                                        Editable = false,
                                                        Width = 200 },
                                     new JQGridColumn { DataField = "BirthDate", 
                                                        Editable = false,                                                        
                                                        DataFormatString = "{0:d}" }                                 
                                 },
                Width = Unit.Pixel(650),
                Height = Unit.Pixel(250)
            };

            EmployeeGrid.ToolBarSettings.ShowRefreshButton = true;
        }
        #endregion --------------------- CONSTRUCTORS -------------------------

        #region ----------------------- PRIVATE METHODS ------------------------

        #endregion--------------------- PRIVATE METHODS ------------------------

        #region ----------------------- PUBLIC METHODS ------------------------

        #endregion--------------------- PUBLIC METHODS ------------------------
    }
}