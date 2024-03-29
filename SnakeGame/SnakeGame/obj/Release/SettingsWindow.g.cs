﻿#pragma checksum "..\..\SettingsWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D4992030C3DB5A29EC8CB07BD790BA999A9FB116A11F27C7CDBC9205C4702A2C"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

using SnakeSENSESoftware;
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


namespace SnakeSENSESoftware {
    
    
    /// <summary>
    /// SettingsWindow
    /// </summary>
    public partial class SettingsWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\SettingsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton ExploreImageModeRadio;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\SettingsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton ChangeBackgroundModeRadio;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\SettingsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton NormalSnakeModeRadio;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\SettingsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton EasyDifficultyRadio;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\SettingsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton MediumDifficultyRadio;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\SettingsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton HardDifficultyRadio;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\SettingsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox IsImmortalRadio;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\SettingsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox IsWallHardRadio;
        
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
            System.Uri resourceLocater = new System.Uri("/SnakeSENSESoftware;component/settingswindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\SettingsWindow.xaml"
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
            this.ExploreImageModeRadio = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 2:
            this.ChangeBackgroundModeRadio = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 3:
            this.NormalSnakeModeRadio = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 4:
            this.EasyDifficultyRadio = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 5:
            this.MediumDifficultyRadio = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 6:
            this.HardDifficultyRadio = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 7:
            this.IsImmortalRadio = ((System.Windows.Controls.CheckBox)(target));
            
            #line 55 "..\..\SettingsWindow.xaml"
            this.IsImmortalRadio.Unchecked += new System.Windows.RoutedEventHandler(this.IsImmortalRadio_UnChecked);
            
            #line default
            #line hidden
            
            #line 55 "..\..\SettingsWindow.xaml"
            this.IsImmortalRadio.Checked += new System.Windows.RoutedEventHandler(this.IsImmortalRadio_Checked);
            
            #line default
            #line hidden
            return;
            case 8:
            this.IsWallHardRadio = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 9:
            
            #line 66 "..\..\SettingsWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 67 "..\..\SettingsWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

