﻿#pragma checksum "..\..\Admin_log.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1A44710A489D4CD6DB2E2F3BCA7124B748344608"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using кп;


namespace кп {
    
    
    /// <summary>
    /// Admin_log
    /// </summary>
    public partial class Admin_log : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\Admin_log.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal кп.Admin_log menulog;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\Admin_log.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grid;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\Admin_log.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Menu menu;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\Admin_log.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem m1;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\Admin_log.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem m3;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\Admin_log.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem edit_users;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\Admin_log.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem recipes;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\Admin_log.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem add_prod;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\Admin_log.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem exit;
        
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
            System.Uri resourceLocater = new System.Uri("/кп;component/admin_log.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Admin_log.xaml"
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
            this.menulog = ((кп.Admin_log)(target));
            return;
            case 2:
            this.grid = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.menu = ((System.Windows.Controls.Menu)(target));
            return;
            case 4:
            this.m1 = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 5:
            this.m3 = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 6:
            this.edit_users = ((System.Windows.Controls.MenuItem)(target));
            
            #line 17 "..\..\Admin_log.xaml"
            this.edit_users.Click += new System.Windows.RoutedEventHandler(this.edit_users_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.recipes = ((System.Windows.Controls.MenuItem)(target));
            
            #line 18 "..\..\Admin_log.xaml"
            this.recipes.Click += new System.Windows.RoutedEventHandler(this.recipes_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.add_prod = ((System.Windows.Controls.MenuItem)(target));
            
            #line 19 "..\..\Admin_log.xaml"
            this.add_prod.Click += new System.Windows.RoutedEventHandler(this.add_prod_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.exit = ((System.Windows.Controls.MenuItem)(target));
            
            #line 20 "..\..\Admin_log.xaml"
            this.exit.Click += new System.Windows.RoutedEventHandler(this.exit_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

