﻿#pragma checksum "..\..\..\Pages\AddFilmPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9CEDDC5D90F0055CDA46BEB393EA7B4CB9336D15791088D25BCD72688D5B9C46"
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


namespace MyFilm.Pages {
    
    
    /// <summary>
    /// AddFilmPage
    /// </summary>
    public partial class AddFilmPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\..\Pages\AddFilmPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddButton;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Pages\AddFilmPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox namefilmtext;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Pages\AddFilmPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox yearfilmtext;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Pages\AddFilmPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox countryfilmtext;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Pages\AddFilmPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox genrefilmtext;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Pages\AddFilmPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox timefilmtext;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\Pages\AddFilmPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox directorfilmtext;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Pages\AddFilmPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox actorfilmtext;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Pages\AddFilmPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox aboutfilmtext;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\Pages\AddFilmPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox pathfilmtext;
        
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
            System.Uri resourceLocater = new System.Uri("/MyFilm;component/pages/addfilmpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\AddFilmPage.xaml"
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
            
            #line 27 "..\..\..\Pages\AddFilmPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_Next);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 28 "..\..\..\Pages\AddFilmPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_Back);
            
            #line default
            #line hidden
            return;
            case 3:
            this.AddButton = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\Pages\AddFilmPage.xaml"
            this.AddButton.Click += new System.Windows.RoutedEventHandler(this.Button_Click_AddImage);
            
            #line default
            #line hidden
            return;
            case 4:
            this.namefilmtext = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.yearfilmtext = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.countryfilmtext = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.genrefilmtext = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.timefilmtext = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.directorfilmtext = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.actorfilmtext = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.aboutfilmtext = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            this.pathfilmtext = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

