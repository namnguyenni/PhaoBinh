#pragma checksum "..\..\..\..\Controls\FileDialogs\SaveFileAddOn.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "BBF8B7F6DB4B7DC2A2B3254FC3CD108A8E1D59898EFE94A599741E9E4951765A"
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
using devDept.Controls.Wpf;


namespace devDept.Controls.Wpf {
    
    
    /// <summary>
    /// SaveFileAddOn
    /// </summary>
    public partial class SaveFileAddOn : devDept.Controls.Wpf.ControlAddOnBase, System.Windows.Markup.IComponentConnector {
        
        
        #line 7 "..\..\..\..\Controls\FileDialogs\SaveFileAddOn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox SelectedOnlyCb;
        
        #line default
        #line hidden
        
        
        #line 8 "..\..\..\..\Controls\FileDialogs\SaveFileAddOn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox PurgeCb;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\..\Controls\FileDialogs\SaveFileAddOn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton GeometryRb;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\..\Controls\FileDialogs\SaveFileAddOn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton TessellationRb;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\Controls\FileDialogs\SaveFileAddOn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton GeomAndTessRb;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\Controls\FileDialogs\SaveFileAddOn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox CompressCb;
        
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
            System.Uri resourceLocater = new System.Uri("/devDept.CustomControls;component/controls/filedialogs/savefileaddon.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Controls\FileDialogs\SaveFileAddOn.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            this.SelectedOnlyCb = ((System.Windows.Controls.CheckBox)(target));
            
            #line 7 "..\..\..\..\Controls\FileDialogs\SaveFileAddOn.xaml"
            this.SelectedOnlyCb.Click += new System.Windows.RoutedEventHandler(this.SelectedOnlyCb_OnClick);
            
            #line default
            #line hidden
            return;
            case 2:
            this.PurgeCb = ((System.Windows.Controls.CheckBox)(target));
            
            #line 8 "..\..\..\..\Controls\FileDialogs\SaveFileAddOn.xaml"
            this.PurgeCb.Click += new System.Windows.RoutedEventHandler(this.PurgeCb_OnClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.GeometryRb = ((System.Windows.Controls.RadioButton)(target));
            
            #line 11 "..\..\..\..\Controls\FileDialogs\SaveFileAddOn.xaml"
            this.GeometryRb.Checked += new System.Windows.RoutedEventHandler(this.GeometryRb_OnChecked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.TessellationRb = ((System.Windows.Controls.RadioButton)(target));
            
            #line 12 "..\..\..\..\Controls\FileDialogs\SaveFileAddOn.xaml"
            this.TessellationRb.Checked += new System.Windows.RoutedEventHandler(this.TessellationRb_OnChecked);
            
            #line default
            #line hidden
            return;
            case 5:
            this.GeomAndTessRb = ((System.Windows.Controls.RadioButton)(target));
            
            #line 13 "..\..\..\..\Controls\FileDialogs\SaveFileAddOn.xaml"
            this.GeomAndTessRb.Checked += new System.Windows.RoutedEventHandler(this.GeomAndTessRb_OnChecked);
            
            #line default
            #line hidden
            return;
            case 6:
            this.CompressCb = ((System.Windows.Controls.CheckBox)(target));
            
            #line 16 "..\..\..\..\Controls\FileDialogs\SaveFileAddOn.xaml"
            this.CompressCb.Click += new System.Windows.RoutedEventHandler(this.CompressCb_OnClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

