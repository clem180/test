﻿#pragma checksum "..\..\..\..\Controlleur\Catalogues\GestionDesCatalogues.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8D6797B0AF3DCA8A71569D85E664AFEF323DE2CF"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using E4Lisa.Controlleur.Catalogues;
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


namespace E4Lisa.Controlleur.Catalogues {
    
    
    /// <summary>
    /// GestionDesCatalogues
    /// </summary>
    public partial class GestionDesCatalogues : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\..\Controlleur\Catalogues\GestionDesCatalogues.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Titre;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\Controlleur\Catalogues\GestionDesCatalogues.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid ListMenu;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\Controlleur\Catalogues\GestionDesCatalogues.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Creer;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\Controlleur\Catalogues\GestionDesCatalogues.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Ajouter;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\Controlleur\Catalogues\GestionDesCatalogues.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Suprimer;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\Controlleur\Catalogues\GestionDesCatalogues.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Rechercher;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\Controlleur\Catalogues\GestionDesCatalogues.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid afficheList;
        
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
            System.Uri resourceLocater = new System.Uri("/E4Lisa;component/controlleur/catalogues/gestiondescatalogues.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Controlleur\Catalogues\GestionDesCatalogues.xaml"
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
            this.Creer = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\..\..\Controlleur\Catalogues\GestionDesCatalogues.xaml"
            this.Creer.Click += new System.Windows.RoutedEventHandler(this.Creer_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Ajouter = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\..\..\Controlleur\Catalogues\GestionDesCatalogues.xaml"
            this.Ajouter.Click += new System.Windows.RoutedEventHandler(this.Modifier_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Suprimer = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\..\..\Controlleur\Catalogues\GestionDesCatalogues.xaml"
            this.Suprimer.Click += new System.Windows.RoutedEventHandler(this.Suprimer_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Rechercher = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\..\..\Controlleur\Catalogues\GestionDesCatalogues.xaml"
            this.Rechercher.Click += new System.Windows.RoutedEventHandler(this.Rechercher_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.afficheList = ((System.Windows.Controls.Grid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

