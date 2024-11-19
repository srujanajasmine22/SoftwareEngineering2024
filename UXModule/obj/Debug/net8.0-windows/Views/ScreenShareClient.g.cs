﻿#pragma checksum "..\..\..\..\Views\ScreenShareClient.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F45363427821E6263628B505DB59450A04B364FA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
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
using UXModule.Views;


namespace UXModule.Views {
    
    
    /// <summary>
    /// ScreenShareClient
    /// </summary>
    public partial class ScreenShareClient : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\..\Views\ScreenShareClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel SharedScreen;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\Views\ScreenShareClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel NotSharedScreen;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\..\Views\ScreenShareClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock MainText;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\..\Views\ScreenShareClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button StartScreenShare;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\..\..\Views\ScreenShareClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button StopScreenShare;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.7.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/UXModule;component/views/screenshareclient.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\ScreenShareClient.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.7.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.SharedScreen = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 2:
            this.NotSharedScreen = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 3:
            this.MainText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.StartScreenShare = ((System.Windows.Controls.Button)(target));
            
            #line 71 "..\..\..\..\Views\ScreenShareClient.xaml"
            this.StartScreenShare.Click += new System.Windows.RoutedEventHandler(this.OnStartButtonClicked);
            
            #line default
            #line hidden
            return;
            case 5:
            this.StopScreenShare = ((System.Windows.Controls.Button)(target));
            
            #line 101 "..\..\..\..\Views\ScreenShareClient.xaml"
            this.StopScreenShare.Click += new System.Windows.RoutedEventHandler(this.OnStopButtonClicked);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
