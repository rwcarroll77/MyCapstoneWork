﻿#pragma checksum "..\..\FrmCheckoutPrompt.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7F24929990B90AE84DD9D863347E95BF6FAB1EA3"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Presentation;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Presentation {
    
    
    /// <summary>
    /// FrmCheckoutPrompt
    /// </summary>
    public partial class FrmCheckoutPrompt : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\FrmCheckoutPrompt.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtVehicleDetails;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\FrmCheckoutPrompt.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtEmployeeId;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\FrmCheckoutPrompt.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEmployeeId;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\FrmCheckoutPrompt.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtFirstName;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\FrmCheckoutPrompt.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtLastName;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\FrmCheckoutPrompt.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dtReturnDate;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\FrmCheckoutPrompt.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCheckout;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Presentation;component/frmcheckoutprompt.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\FrmCheckoutPrompt.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.txtVehicleDetails = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.txtEmployeeId = ((System.Windows.Controls.TextBox)(target));
            
            #line 45 "..\..\FrmCheckoutPrompt.xaml"
            this.txtEmployeeId.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxtEmployeeId_OnTextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnEmployeeId = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\FrmCheckoutPrompt.xaml"
            this.btnEmployeeId.Click += new System.Windows.RoutedEventHandler(this.BtnEmployeeId_OnClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txtFirstName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtLastName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.dtReturnDate = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 7:
            this.btnCheckout = ((System.Windows.Controls.Button)(target));
            
            #line 107 "..\..\FrmCheckoutPrompt.xaml"
            this.btnCheckout.Click += new System.Windows.RoutedEventHandler(this.BtnCheckout_OnClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
