﻿#pragma checksum "..\..\BubbledLabelClick.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "CB9ED0596EEB9605F91428612BE2B249"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3620
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


namespace RoutedEvents {
    
    
    /// <summary>
    /// BubbledLabelClick
    /// </summary>
    public partial class BubbledLabelClick : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\BubbledLabelClick.xaml"
        internal System.Windows.Controls.ListBox lstMessages;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\BubbledLabelClick.xaml"
        internal System.Windows.Controls.CheckBox chkHandle;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/RoutedEvents;component/bubbledlabelclick.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\BubbledLabelClick.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 5 "..\..\BubbledLabelClick.xaml"
            ((RoutedEvents.BubbledLabelClick)(target)).MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.SomethingClicked);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 7 "..\..\BubbledLabelClick.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.SomethingClicked);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 15 "..\..\BubbledLabelClick.xaml"
            ((System.Windows.Controls.Label)(target)).MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.SomethingClicked);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 16 "..\..\BubbledLabelClick.xaml"
            ((System.Windows.Controls.StackPanel)(target)).MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.SomethingClicked);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 17 "..\..\BubbledLabelClick.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.SomethingClicked);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 20 "..\..\BubbledLabelClick.xaml"
            ((System.Windows.Controls.Image)(target)).MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.SomethingClicked);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 22 "..\..\BubbledLabelClick.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.SomethingClicked);
            
            #line default
            #line hidden
            return;
            case 8:
            this.lstMessages = ((System.Windows.Controls.ListBox)(target));
            return;
            case 9:
            this.chkHandle = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 10:
            
            #line 30 "..\..\BubbledLabelClick.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.cmdClear_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
