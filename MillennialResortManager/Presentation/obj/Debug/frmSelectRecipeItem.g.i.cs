﻿#pragma checksum "..\..\frmSelectRecipeItem.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3B2749AE2D28DFB62E9F057B570D29E1E4659499"
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
    /// frmSelectItem
    /// </summary>
    public partial class frmSelectItem : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 33 "..\..\frmSelectRecipeItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtItemNameSearch;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\frmSelectRecipeItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboItemType;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\frmSelectRecipeItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgItemList;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\frmSelectRecipeItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtQuantity;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\frmSelectRecipeItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtUnitOfMeasure;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\frmSelectRecipeItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnExit;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\frmSelectRecipeItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSubmit;
        
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
            System.Uri resourceLocater = new System.Uri("/Presentation;component/frmselectrecipeitem.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\frmSelectRecipeItem.xaml"
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
            this.txtItemNameSearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 33 "..\..\frmSelectRecipeItem.xaml"
            this.txtItemNameSearch.KeyUp += new System.Windows.Input.KeyEventHandler(this.TxtItemNameSearch_KeyUp);
            
            #line default
            #line hidden
            return;
            case 2:
            this.cboItemType = ((System.Windows.Controls.ComboBox)(target));
            
            #line 35 "..\..\frmSelectRecipeItem.xaml"
            this.cboItemType.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CboItemType_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.dgItemList = ((System.Windows.Controls.DataGrid)(target));
            
            #line 39 "..\..\frmSelectRecipeItem.xaml"
            this.dgItemList.AutoGeneratingColumn += new System.EventHandler<System.Windows.Controls.DataGridAutoGeneratingColumnEventArgs>(this.DgItemList_AutoGeneratingColumn);
            
            #line default
            #line hidden
            
            #line 39 "..\..\frmSelectRecipeItem.xaml"
            this.dgItemList.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DgItemList_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txtQuantity = ((System.Windows.Controls.TextBox)(target));
            
            #line 51 "..\..\frmSelectRecipeItem.xaml"
            this.txtQuantity.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtQuantity_TextChanged);
            
            #line default
            #line hidden
            
            #line 51 "..\..\frmSelectRecipeItem.xaml"
            this.txtQuantity.KeyDown += new System.Windows.Input.KeyEventHandler(this.txtQuantity_KeyDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txtUnitOfMeasure = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.btnExit = ((System.Windows.Controls.Button)(target));
            
            #line 61 "..\..\frmSelectRecipeItem.xaml"
            this.btnExit.Click += new System.Windows.RoutedEventHandler(this.BtnExit_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnSubmit = ((System.Windows.Controls.Button)(target));
            
            #line 62 "..\..\frmSelectRecipeItem.xaml"
            this.btnSubmit.Click += new System.Windows.RoutedEventHandler(this.BtnSubmit_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
