﻿#pragma checksum "..\..\..\Main Forms\frmEmployee.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A9370A97A8453A654689F3A27F7C2D6D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Windows.Controls;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
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


namespace PresentationLayer.Main_Forms {
    
    
    /// <summary>
    /// frmEmployee
    /// </summary>
    public partial class frmEmployee : System.Windows.Controls.Ribbon.RibbonWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\Main Forms\frmEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Ribbon.Ribbon RibbonWin;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Main Forms\frmEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Ribbon.RibbonButton Save;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Main Forms\frmEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Ribbon.RibbonSplitButton Undo;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Main Forms\frmEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Ribbon.RibbonSplitButton Redo;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Main Forms\frmEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Ribbon.RibbonGroup Employee;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\Main Forms\frmEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Ribbon.RibbonMenuItem ButtonAddEmployee;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\Main Forms\frmEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Ribbon.RibbonMenuItem ButtonEditEmployee;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Main Forms\frmEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Ribbon.RibbonMenuItem ButtonDeleteEmployee;
        
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
            System.Uri resourceLocater = new System.Uri("/PresentationLayer;component/main%20forms/frmemployee.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Main Forms\frmEmployee.xaml"
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
            this.RibbonWin = ((System.Windows.Controls.Ribbon.Ribbon)(target));
            return;
            case 2:
            this.Save = ((System.Windows.Controls.Ribbon.RibbonButton)(target));
            return;
            case 3:
            this.Undo = ((System.Windows.Controls.Ribbon.RibbonSplitButton)(target));
            return;
            case 4:
            this.Redo = ((System.Windows.Controls.Ribbon.RibbonSplitButton)(target));
            return;
            case 5:
            this.Employee = ((System.Windows.Controls.Ribbon.RibbonGroup)(target));
            return;
            case 6:
            this.ButtonAddEmployee = ((System.Windows.Controls.Ribbon.RibbonMenuItem)(target));
            return;
            case 7:
            this.ButtonEditEmployee = ((System.Windows.Controls.Ribbon.RibbonMenuItem)(target));
            return;
            case 8:
            this.ButtonDeleteEmployee = ((System.Windows.Controls.Ribbon.RibbonMenuItem)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
