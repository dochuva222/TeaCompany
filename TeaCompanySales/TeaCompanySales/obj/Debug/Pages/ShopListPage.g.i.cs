﻿#pragma checksum "..\..\..\Pages\ShopListPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6762C5D563B5858B68344A1DE330C743927B543FC2BDD7E5A4604A169F9E8AB4"
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
using TeaCompanySales.Pages;


namespace TeaCompanySales.Pages {
    
    
    /// <summary>
    /// ShopListPage
    /// </summary>
    public partial class ShopListPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\Pages\ShopListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBSearch;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Pages\ShopListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView LVShops;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\Pages\ShopListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BAdd;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\Pages\ShopListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BDelete;
        
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
            System.Uri resourceLocater = new System.Uri("/TeaCompanySales;component/pages/shoplistpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\ShopListPage.xaml"
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
            
            #line 10 "..\..\..\Pages\ShopListPage.xaml"
            ((TeaCompanySales.Pages.ShopListPage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TBSearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 23 "..\..\..\Pages\ShopListPage.xaml"
            this.TBSearch.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TBSearch_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.LVShops = ((System.Windows.Controls.ListView)(target));
            
            #line 31 "..\..\..\Pages\ShopListPage.xaml"
            this.LVShops.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.LVShops_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BAdd = ((System.Windows.Controls.Button)(target));
            
            #line 66 "..\..\..\Pages\ShopListPage.xaml"
            this.BAdd.Click += new System.Windows.RoutedEventHandler(this.BAdd_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BDelete = ((System.Windows.Controls.Button)(target));
            
            #line 69 "..\..\..\Pages\ShopListPage.xaml"
            this.BDelete.Click += new System.Windows.RoutedEventHandler(this.BDelete_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
