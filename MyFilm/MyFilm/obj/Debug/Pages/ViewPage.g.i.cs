﻿#pragma checksum "..\..\..\Pages\ViewPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "BA9908C0A2D376BB8F6AE998B754D4C09436E3FCCCDF97A6267077DC3589255D"
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


namespace MyFilm.Pages {
    
    
    /// <summary>
    /// ViewPage
    /// </summary>
    public partial class ViewPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 57 "..\..\..\Pages\ViewPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel mainFilmGrid;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\Pages\ViewPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid filmGrid;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\Pages\ViewPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label nameFilmLable;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\Pages\ViewPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label yearFilmLable;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\..\Pages\ViewPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label countryFilmLable;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\..\Pages\ViewPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label genreFilmLable;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\Pages\ViewPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label directorFilmLable;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\..\Pages\ViewPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label actorFilmLable;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\..\Pages\ViewPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label timeFilmLable;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\..\Pages\ViewPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label aboutFilmLable;
        
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
            System.Uri resourceLocater = new System.Uri("/MyFilm;component/pages/viewpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\ViewPage.xaml"
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
            
            #line 8 "..\..\..\Pages\ViewPage.xaml"
            ((MyFilm.Pages.ViewPage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 22 "..\..\..\Pages\ViewPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_Exit);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 33 "..\..\..\Pages\ViewPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_AddFilm);
            
            #line default
            #line hidden
            return;
            case 4:
            this.mainFilmGrid = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 5:
            this.filmGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 6:
            
            #line 74 "..\..\..\Pages\ViewPage.xaml"
            ((System.Windows.Controls.Label)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Label_MouseDown_Watch1);
            
            #line default
            #line hidden
            return;
            case 7:
            this.nameFilmLable = ((System.Windows.Controls.Label)(target));
            
            #line 83 "..\..\..\Pages\ViewPage.xaml"
            this.nameFilmLable.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Label_MouseDown_Watch1);
            
            #line default
            #line hidden
            return;
            case 8:
            this.yearFilmLable = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.countryFilmLable = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.genreFilmLable = ((System.Windows.Controls.Label)(target));
            return;
            case 11:
            this.directorFilmLable = ((System.Windows.Controls.Label)(target));
            return;
            case 12:
            this.actorFilmLable = ((System.Windows.Controls.Label)(target));
            return;
            case 13:
            this.timeFilmLable = ((System.Windows.Controls.Label)(target));
            return;
            case 14:
            this.aboutFilmLable = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

