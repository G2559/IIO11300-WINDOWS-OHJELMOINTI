﻿#pragma checksum "..\..\Copy of MainWindowV2.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9F062A4AB34C079757B43A1BC8E0916C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
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


namespace H10ADOBlanco {
    
    
    /// <summary>
    /// MainWindowV2
    /// </summary>
    public partial class MainWindowV2 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\Copy of MainWindowV2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnGet3;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\Copy of MainWindowV2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnGetAll;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\Copy of MainWindowV2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbCities;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\Copy of MainWindowV2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel spLowest;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\Copy of MainWindowV2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbMessages;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\Copy of MainWindowV2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgCustomers;
        
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
            System.Uri resourceLocater = new System.Uri("/ADONET;component/copy%20of%20mainwindowv2.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Copy of MainWindowV2.xaml"
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
            this.btnGet3 = ((System.Windows.Controls.Button)(target));
            
            #line 8 "..\..\Copy of MainWindowV2.xaml"
            this.btnGet3.Click += new System.Windows.RoutedEventHandler(this.btnGet3_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnGetAll = ((System.Windows.Controls.Button)(target));
            
            #line 9 "..\..\Copy of MainWindowV2.xaml"
            this.btnGetAll.Click += new System.Windows.RoutedEventHandler(this.btnGetAll_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.cbCities = ((System.Windows.Controls.ComboBox)(target));
            
            #line 10 "..\..\Copy of MainWindowV2.xaml"
            this.cbCities.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cbCities_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.spLowest = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 5:
            this.lbMessages = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.dgCustomers = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

