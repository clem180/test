﻿#pragma checksum "..\..\..\..\Windows\Catalogues\GestiondescataloguesRechercher.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B96D84EDCD8FAB104CCDF977CB35F9D52030A123"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using E4Lisa.Windows.Catalogues;
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


namespace E4Lisa.Windows.Catalogues {
    
    
    /// <summary>
    /// GestiondescataloguesRechercher
    /// </summary>
    public partial class GestiondescataloguesRechercher : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\..\Windows\Catalogues\GestiondescataloguesRechercher.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Titre;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\Windows\Catalogues\GestiondescataloguesRechercher.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid ListMenu;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\Windows\Catalogues\GestiondescataloguesRechercher.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Ajouter;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\Windows\Catalogues\GestiondescataloguesRechercher.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Suprimer;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\Windows\Catalogues\GestiondescataloguesRechercher.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AficherProduitCatalogue;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\Windows\Catalogues\GestiondescataloguesRechercher.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid afficheList;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\..\Windows\Catalogues\GestiondescataloguesRechercher.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid ListCatalogueRechercher;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\..\Windows\Catalogues\GestiondescataloguesRechercher.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid ListProduitCatalogue;
        
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
            System.Uri resourceLocater = new System.Uri("/E4Lisa;component/windows/catalogues/gestiondescataloguesrechercher.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Windows\Catalogues\GestiondescataloguesRechercher.xaml"
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
            this.Titre = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.ListMenu = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.Ajouter = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\..\Windows\Catalogues\GestiondescataloguesRechercher.xaml"
            this.Ajouter.Click += new System.Windows.RoutedEventHandler(this.Modifier_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Suprimer = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\..\..\Windows\Catalogues\GestiondescataloguesRechercher.xaml"
            this.Suprimer.Click += new System.Windows.RoutedEventHandler(this.Suprimer_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.AficherProduitCatalogue = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\..\..\Windows\Catalogues\GestiondescataloguesRechercher.xaml"
            this.AficherProduitCatalogue.Click += new System.Windows.RoutedEventHandler(this.AficherProduitCatalogue_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.afficheList = ((System.Windows.Controls.Grid)(target));
            return;
            case 7:
            this.ListCatalogueRechercher = ((System.Windows.Controls.Grid)(target));
            return;
            case 8:
            this.ListProduitCatalogue = ((System.Windows.Controls.Grid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
