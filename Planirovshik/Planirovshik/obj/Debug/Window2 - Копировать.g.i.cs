﻿#pragma checksum "..\..\Window2 - Копировать.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4C10352458896531F950B548C72E5C13039D531C0F25EF4F91AE81F9C4558217"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Planirovshik;
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


namespace Planirovshik {
    
    
    /// <summary>
    /// Window2
    /// </summary>
    public partial class Window2 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\Window2 - Копировать.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Add_Name;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\Window2 - Копировать.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboBox_Priority;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\Window2 - Копировать.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker Date;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\Window2 - Копировать.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Add_Desc;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\Window2 - Копировать.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Cancel;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\Window2 - Копировать.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Submit;
        
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
            System.Uri resourceLocater = new System.Uri("/Planirovshik;component/window2%20-%20%d0%9a%d0%be%d0%bf%d0%b8%d1%80%d0%be%d0%b2%" +
                    "d0%b0%d1%82%d1%8c.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Window2 - Копировать.xaml"
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
            this.Add_Name = ((System.Windows.Controls.TextBox)(target));
            
            #line 24 "..\..\Window2 - Копировать.xaml"
            this.Add_Name.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Add_Name_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ComboBox_Priority = ((System.Windows.Controls.ComboBox)(target));
            
            #line 27 "..\..\Window2 - Копировать.xaml"
            this.ComboBox_Priority.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBox_Priority_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Date = ((System.Windows.Controls.DatePicker)(target));
            
            #line 34 "..\..\Window2 - Копировать.xaml"
            this.Date.SelectedDateChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.Date_Changed);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Add_Desc = ((System.Windows.Controls.TextBox)(target));
            
            #line 37 "..\..\Window2 - Копировать.xaml"
            this.Add_Desc.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Add_Desc_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btn_Cancel = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\Window2 - Копировать.xaml"
            this.btn_Cancel.Click += new System.Windows.RoutedEventHandler(this.btn_Cancel_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btn_Submit = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\Window2 - Копировать.xaml"
            this.btn_Submit.Click += new System.Windows.RoutedEventHandler(this.btn_Submit_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

