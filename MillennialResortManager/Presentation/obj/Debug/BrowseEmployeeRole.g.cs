﻿#pragma checksum "..\..\BrowseEmployeeRole.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "650FF3A5EF12AA84024AB616A38421E2F8D01C3A"
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
    /// BrowseEmployeeRole
    /// </summary>
    public partial class BrowseEmployeeRole : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 35 "..\..\BrowseEmployeeRole.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSearch;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\BrowseEmployeeRole.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnFilter;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\BrowseEmployeeRole.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClearRoles;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\BrowseEmployeeRole.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabControl tabsetMain;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\BrowseEmployeeRole.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem tabRole;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\BrowseEmployeeRole.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgRole;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\BrowseEmployeeRole.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCancel;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\BrowseEmployeeRole.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDeactivate;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\BrowseEmployeeRole.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnUpdate;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\BrowseEmployeeRole.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAdd;
        
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
            System.Uri resourceLocater = new System.Uri("/Presentation;component/browseemployeerole.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\BrowseEmployeeRole.xaml"
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
            
            #line 9 "..\..\BrowseEmployeeRole.xaml"
            ((Presentation.BrowseEmployeeRole)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtSearch = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.btnFilter = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\BrowseEmployeeRole.xaml"
            this.btnFilter.Click += new System.Windows.RoutedEventHandler(this.BtnFilter_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnClearRoles = ((System.Windows.Controls.Button)(target));
            
            #line 56 "..\..\BrowseEmployeeRole.xaml"
            this.btnClearRoles.Click += new System.Windows.RoutedEventHandler(this.BtnClearRoles_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.tabsetMain = ((System.Windows.Controls.TabControl)(target));
            return;
            case 6:
            this.tabRole = ((System.Windows.Controls.TabItem)(target));
            
            #line 69 "..\..\BrowseEmployeeRole.xaml"
            this.tabRole.GotFocus += new System.Windows.RoutedEventHandler(this.TabRole_GotFocus);
            
            #line default
            #line hidden
            return;
            case 7:
            this.dgRole = ((System.Windows.Controls.DataGrid)(target));
            
            #line 80 "..\..\BrowseEmployeeRole.xaml"
            this.dgRole.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.DgRole_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnCancel = ((System.Windows.Controls.Button)(target));
            
            #line 103 "..\..\BrowseEmployeeRole.xaml"
            this.btnCancel.Click += new System.Windows.RoutedEventHandler(this.BtnCancel_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnDeactivate = ((System.Windows.Controls.Button)(target));
            
            #line 104 "..\..\BrowseEmployeeRole.xaml"
            this.btnDeactivate.Click += new System.Windows.RoutedEventHandler(this.BtnDeactivate_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btnUpdate = ((System.Windows.Controls.Button)(target));
            
            #line 105 "..\..\BrowseEmployeeRole.xaml"
            this.btnUpdate.Click += new System.Windows.RoutedEventHandler(this.BtnUpdate_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.btnAdd = ((System.Windows.Controls.Button)(target));
            
            #line 106 "..\..\BrowseEmployeeRole.xaml"
            this.btnAdd.Click += new System.Windows.RoutedEventHandler(this.BtnAdd_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

