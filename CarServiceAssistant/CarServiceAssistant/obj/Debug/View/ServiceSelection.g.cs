﻿#pragma checksum "..\..\..\View\ServiceSelection.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "BC074202001300A7F9DD86FEBE4DEAE6"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using CarServiceAssistant;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interactivity;
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


namespace CarServiceAssistant.View {
    
    
    /// <summary>
    /// ServiceSelection
    /// </summary>
    public partial class ServiceSelection : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 33 "..\..\..\View\ServiceSelection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addService;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\View\ServiceSelection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button selectService;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\View\ServiceSelection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox statusComboBox;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\View\ServiceSelection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button chooseServiceButton;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\View\ServiceSelection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid serviceInfoDataGrid;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\View\ServiceSelection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox descriptionTextBox;
        
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
            System.Uri resourceLocater = new System.Uri("/CarServiceAssistant;component/view/serviceselection.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\ServiceSelection.xaml"
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
            this.addService = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\View\ServiceSelection.xaml"
            this.addService.Click += new System.Windows.RoutedEventHandler(this.addService_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.selectService = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\View\ServiceSelection.xaml"
            this.selectService.Click += new System.Windows.RoutedEventHandler(this.selectService_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.statusComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.chooseServiceButton = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\..\View\ServiceSelection.xaml"
            this.chooseServiceButton.Click += new System.Windows.RoutedEventHandler(this.chooseServiceButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.serviceInfoDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 6:
            this.descriptionTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

