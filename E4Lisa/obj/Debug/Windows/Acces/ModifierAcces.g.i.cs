﻿#pragma checksum "..\..\..\..\Windows\Acces\ModifierAcces.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F41687D52C25FB9814C962A913CA534ACB0A3517"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using E4Lisa.Windows.Acces;
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


namespace E4Lisa.Windows.Acces {
    
    
    /// <summary>
    /// ModifierAcces
    /// </summary>
    public partial class ModifierAcces : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\..\..\Windows\Acces\ModifierAcces.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Contenu;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\Windows\Acces\ModifierAcces.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Connexion;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\..\Windows\Acces\ModifierAcces.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker Display_StartSate;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\..\..\Windows\Acces\ModifierAcces.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker Start_Date;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\..\..\Windows\Acces\ModifierAcces.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker Display_EndDate;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\..\..\Windows\Acces\ModifierAcces.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ModifierAces;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\..\..\Windows\Acces\ModifierAcces.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Annuler;
        
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
            System.Uri resourceLocater = new System.Uri("/E4Lisa;component/windows/acces/modifieracces.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Windows\Acces\ModifierAcces.xaml"
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
            this.Contenu = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.Connexion = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.Display_StartSate = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 4:
            this.Start_Date = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 5:
            this.Display_EndDate = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 6:
            this.ModifierAces = ((System.Windows.Controls.Button)(target));
            
            #line 102 "..\..\..\..\Windows\Acces\ModifierAcces.xaml"
            this.ModifierAces.Click += new System.Windows.RoutedEventHandler(this.ModifierAcces_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Annuler = ((System.Windows.Controls.Button)(target));
            
            #line 103 "..\..\..\..\Windows\Acces\ModifierAcces.xaml"
            this.Annuler.Click += new System.Windows.RoutedEventHandler(this.Annuler_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

