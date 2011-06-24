using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SOS.Client.AdvWorksManagementService;

namespace SOS.Client
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            try
            {
                AdvWorksManagementService.EmployeeServiceContractClient servicePoint = new AdvWorksManagementService.EmployeeServiceContractClient();

                //SOS.Client.AdvWorksManagementService.Employees k = servicePoint.GetEmployees();

                SOS.Client.AdvWorksManagementService.PurchaseOrderDetails n = servicePoint.GetPurchaseOrderDetails(1122);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.InnerException);
            }
           
        }
    }
}