using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyTestingGround.DomainObjects;

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
        public ICollection<IEmployee> Employees { get; set; }

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
}