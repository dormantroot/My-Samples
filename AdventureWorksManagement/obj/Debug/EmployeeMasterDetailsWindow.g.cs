﻿#pragma checksum "C:\My Development\My Testing Ground\MyTesting Ground\AdventureWorksManagement\EmployeeMasterDetailsWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B347E403E3F1499F010D06D651ADBC1F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.235
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace AdventureWorksManagement {
    
    
    public partial class EmployeeMasterDetailsWindow : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.DataGrid dataGrid1;
        
        internal System.Windows.Controls.Button button1;
        
        internal System.Windows.Controls.BusyIndicator busyIndicator1;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/AdventureWorksManagement;component/EmployeeMasterDetailsWindow.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.dataGrid1 = ((System.Windows.Controls.DataGrid)(this.FindName("dataGrid1")));
            this.button1 = ((System.Windows.Controls.Button)(this.FindName("button1")));
            this.busyIndicator1 = ((System.Windows.Controls.BusyIndicator)(this.FindName("busyIndicator1")));
        }
    }
}

