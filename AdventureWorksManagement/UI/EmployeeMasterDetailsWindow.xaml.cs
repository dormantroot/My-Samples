using System;
using System.Windows.Controls;
using System.Collections.Generic;


namespace AdventureWorksManagement.UI
{
    public partial class EmployeeMasterDetailsWindow : UserControl
    {
        public EmployeeMasterDetailsWindow()
        {
           
            try
            {
                InitializeComponent();
                //ObservableCollection<EmployeeModel> k = new ObservableCollection<EmployeeModel>() 
                //    {new EmployeeModel(){FirstName="Frodo", 
                //                   LastName=" Baggins"}, 
                //    new EmployeeModel(){FirstName="Pippin", 
                //                   LastName="Thomas"}, 
                //    new EmployeeModel(){FirstName="John", 
                //                   LastName="Doe"}, 
                //    new EmployeeModel(){FirstName="Tim", 
                //                   LastName="Kiriev"}};

                //dataGrid1.DataContext = Customer.GetSampleCustomerList();
                //CustomersListBox.DataContext = k;           
               
            }
            catch (Exception ex)
            {
                
                
            }
          
        }
    }

    public class Customer
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Address { get; set; }
        public Boolean IsNew { get; set; }

        // A null value for IsSubscribed can indicate 
        // "no preference" or "no response".
        public Boolean? IsSubscribed { get; set; }

        public Customer(String firstName, String lastName,
            String address, Boolean isNew, Boolean? isSubscribed)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
            this.IsNew = isNew;
            this.IsSubscribed = isSubscribed;
        }

        public static List<Customer> GetSampleCustomerList()
        {
            return new List<Customer>(new Customer[4] {
                new Customer("A.", "Zero", 
                    "12 North Third Street, Apartment 45", 
                    false, true), 
                new Customer("B.", "One", 
                    "34 West Fifth Street, Apartment 67", 
                    false, false),
                new Customer("C.", "Two", 
                    "56 East Seventh Street, Apartment 89", 
                    true, null),
                new Customer("D.", "Three", 
                    "78 South Ninth Street, Apartment 10", 
                    true, true)
            });
        }
    }
}
