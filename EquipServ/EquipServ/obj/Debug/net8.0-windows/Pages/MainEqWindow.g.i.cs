﻿#pragma checksum "..\..\..\..\Pages\MainEqWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "FF176CA1136BC655E74770D0A4F4BD41026B4DB6"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using EquipServ.Pages;
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


namespace EquipServ.Pages {
    
    
    /// <summary>
    /// MainEqWindow
    /// </summary>
    public partial class MainEqWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 21 "..\..\..\..\Pages\MainEqWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button informationService;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\Pages\MainEqWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button announceService;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\Pages\MainEqWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MainPagee;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\Pages\MainEqWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addRequest;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\Pages\MainEqWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox searchTextBox;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\Pages\MainEqWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView allRequests;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.3.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/EquipServ;V1.0.0.0;component/pages/maineqwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\MainEqWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.3.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 20 "..\..\..\..\Pages\MainEqWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CloseAway);
            
            #line default
            #line hidden
            return;
            case 2:
            this.informationService = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\..\Pages\MainEqWindow.xaml"
            this.informationService.Click += new System.Windows.RoutedEventHandler(this.toInformation);
            
            #line default
            #line hidden
            return;
            case 3:
            this.announceService = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\..\Pages\MainEqWindow.xaml"
            this.announceService.Click += new System.Windows.RoutedEventHandler(this.toAnnounce);
            
            #line default
            #line hidden
            return;
            case 4:
            this.MainPagee = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\..\Pages\MainEqWindow.xaml"
            this.MainPagee.Click += new System.Windows.RoutedEventHandler(this.toMainPage);
            
            #line default
            #line hidden
            return;
            case 5:
            this.addRequest = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\..\Pages\MainEqWindow.xaml"
            this.addRequest.Click += new System.Windows.RoutedEventHandler(this.toAddRequest);
            
            #line default
            #line hidden
            return;
            case 6:
            this.searchTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 31 "..\..\..\..\Pages\MainEqWindow.xaml"
            this.searchTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.search);
            
            #line default
            #line hidden
            return;
            case 7:
            this.allRequests = ((System.Windows.Controls.ListView)(target));
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.3.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 8:
            
            #line 66 "..\..\..\..\Pages\MainEqWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.changeEx);
            
            #line default
            #line hidden
            break;
            case 9:
            
            #line 78 "..\..\..\..\Pages\MainEqWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.change);
            
            #line default
            #line hidden
            break;
            case 10:
            
            #line 81 "..\..\..\..\Pages\MainEqWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.addExecutor);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

