﻿#pragma checksum "..\..\..\UI\UserWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "BCA1EC639B4ACC47168C4135996F5A97"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MyApplication.UI;
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


namespace MyApplication.UI {
    
    
    /// <summary>
    /// UserWindow
    /// </summary>
    public partial class UserWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\UI\UserWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbName;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\UI\UserWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbSurname;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\UI\UserWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbUsername;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\UI\UserWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbPassword;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\UI\UserWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbUserType;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\UI\UserWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddEditUser;
        
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
            System.Uri resourceLocater = new System.Uri("/MyApplication;component/ui/userwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UI\UserWindow.xaml"
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
            this.tbName = ((System.Windows.Controls.TextBox)(target));
            
            #line 18 "..\..\..\UI\UserWindow.xaml"
            this.tbName.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tbName_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.tbSurname = ((System.Windows.Controls.TextBox)(target));
            
            #line 27 "..\..\..\UI\UserWindow.xaml"
            this.tbSurname.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tbSurname_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.tbUsername = ((System.Windows.Controls.TextBox)(target));
            
            #line 36 "..\..\..\UI\UserWindow.xaml"
            this.tbUsername.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tbUsername_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.tbPassword = ((System.Windows.Controls.TextBox)(target));
            
            #line 49 "..\..\..\UI\UserWindow.xaml"
            this.tbPassword.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tbPassword_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.cbUserType = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.btnAddEditUser = ((System.Windows.Controls.Button)(target));
            
            #line 60 "..\..\..\UI\UserWindow.xaml"
            this.btnAddEditUser.Click += new System.Windows.RoutedEventHandler(this.btnAddEditUser_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

