﻿#pragma checksum "..\..\..\Main Forms\MainWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A509793BAF3A595831768CBA3A8FF2D6"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace RibbonWin {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Controls.Ribbon.RibbonWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\Main Forms\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Ribbon.Ribbon RibbonWin;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Main Forms\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Ribbon.RibbonButton Save;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Main Forms\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Ribbon.RibbonSplitButton Undo;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Main Forms\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Ribbon.RibbonSplitButton Redo;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\Main Forms\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Ribbon.RibbonGroup ClipboardGroup;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\Main Forms\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Ribbon.RibbonGroup Employee;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\Main Forms\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel UIPanel;
        
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
            System.Uri resourceLocater = new System.Uri("/PresentationLayer;component/main%20forms/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Main Forms\MainWindow.xaml"
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
            this.ClipboardGroup = ((System.Windows.Controls.Ribbon.RibbonGroup)(target));
            return;
            case 6:
            this.Employee = ((System.Windows.Controls.Ribbon.RibbonGroup)(target));
            return;
            case 7:
            this.UIPanel = ((System.Windows.Controls.DockPanel)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
