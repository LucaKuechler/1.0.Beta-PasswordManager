﻿#pragma checksum "..\..\..\Backend\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "48AB899566438456ABF50E20892D9F53C1FFE2D8E3E367059E830EF280354CA2"
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
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
using sqliteWPF;


namespace sqliteWPF {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\Backend\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox submit_Mail;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Backend\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SendMail;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Backend\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label output1;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Backend\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label output2;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Backend\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox submit_Username;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\Backend\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox submit_Password;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\Backend\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox MailDropdown;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\Backend\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox submit_Website;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\Backend\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox submit_Notes;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\Backend\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox submit_Name;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\Backend\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox submit_IconID;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\Backend\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SendAccount;
        
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
            System.Uri resourceLocater = new System.Uri("/Password Manager;component/backend/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Backend\MainWindow.xaml"
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
            this.submit_Mail = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.SendMail = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\Backend\MainWindow.xaml"
            this.SendMail.Click += new System.Windows.RoutedEventHandler(this.SendMail_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.output1 = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.output2 = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.submit_Username = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.submit_Password = ((System.Windows.Controls.TextBox)(target));
            
            #line 41 "..\..\..\Backend\MainWindow.xaml"
            this.submit_Password.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.submit_Password_TextChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.MailDropdown = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.submit_Website = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.submit_Notes = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.submit_Name = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.submit_IconID = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            this.SendAccount = ((System.Windows.Controls.Button)(target));
            
            #line 83 "..\..\..\Backend\MainWindow.xaml"
            this.SendAccount.Click += new System.Windows.RoutedEventHandler(this.SendAccount_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

