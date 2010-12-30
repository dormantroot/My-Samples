using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace MyTestingGroundMVC.ViewData
{
    /// <summary>
    /// 
    /// </summary>
    public class USStatesViewData : BaseViewData
    {
        #region ---------------------- PRIVATE PROPERTIES ----------------------
        IList<String> states;
        #endregion ------------------- PRIVATE PROPERTIES ----------------------

        #region ---------------------- PUBLIC PROPERTIES ----------------------
        /// <summary>
        /// Gets or sets the states.
        /// </summary>
        /// <value>The states.</value>
        public ReadOnlyCollection<String> States { get; set; }

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
        public USStatesViewData()
        {
            // Populate list of states
            states = new List<String>();
            states.Add("Alabama - AL");
            states.Add("Alaska  - AK");
            states.Add("Arizona - AZ");

            States = new ReadOnlyCollection<string>(states);

            // Define a subtitle
            Subtitle = "List of States in the USA";
        }
        #endregion --------------------- CONSTRUCTORS -------------------------

        #region ----------------------- PRIVATE METHODS ------------------------

        #endregion--------------------- PRIVATE METHODS ------------------------

        #region ----------------------- PUBLIC METHODS ------------------------

        #endregion--------------------- PUBLIC METHODS ------------------------
    }
}