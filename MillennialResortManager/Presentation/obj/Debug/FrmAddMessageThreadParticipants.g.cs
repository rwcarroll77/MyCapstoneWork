﻿#pragma checksum "..\..\FrmAddMessageThreadParticipants.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4258CF1005325A63C67205CD297770546BF2ABD4"
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
    /// FrmAddMessageThreadParticipants
    /// </summary>
    public partial class FrmAddMessageThreadParticipants : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\FrmAddMessageThreadParticipants.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Presentation.CtrlThreadParticipantAdder ctrlParticipantSelector;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\FrmAddMessageThreadParticipants.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnThreadParticipantAddSubmit;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\FrmAddMessageThreadParticipants.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnThreadParticipantAddCancel;
        
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
            System.Uri resourceLocater = new System.Uri("/Presentation;component/frmaddmessagethreadparticipants.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\FrmAddMessageThreadParticipants.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            this.ctrlParticipantSelector = ((Presentation.CtrlThreadParticipantAdder)(target));
            return;
            case 2:
            this.btnThreadParticipantAddSubmit = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\FrmAddMessageThreadParticipants.xaml"
            this.btnThreadParticipantAddSubmit.Click += new System.Windows.RoutedEventHandler(this.BtnThreadParticipantAddSubmit_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnThreadParticipantAddCancel = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\FrmAddMessageThreadParticipants.xaml"
            this.btnThreadParticipantAddCancel.Click += new System.Windows.RoutedEventHandler(this.BtnThreadParticipantAddCancel_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

