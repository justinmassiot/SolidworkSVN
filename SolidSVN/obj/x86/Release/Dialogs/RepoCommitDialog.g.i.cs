﻿#pragma checksum "..\..\..\..\Dialogs\RepoCommitDialog.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F5F7FFFDC3ED740C2C55122724C48E4E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SolidSVN;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace SolidSVN {
    
    
    /// <summary>
    /// RepoCommitDialog
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
    public partial class RepoCommitDialog : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\..\Dialogs\RepoCommitDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock _commit_desc;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\Dialogs\RepoCommitDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal SolidSVN.TreeList _treeList;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\..\Dialogs\RepoCommitDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox release_locks;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\..\Dialogs\RepoCommitDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button commit_button;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\..\Dialogs\RepoCommitDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cancel_button;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\..\Dialogs\RepoCommitDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ProgressBar commit_progress_bar;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/SolidSVN;component/dialogs/repocommitdialog.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Dialogs\RepoCommitDialog.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this._commit_desc = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this._treeList = ((SolidSVN.TreeList)(target));
            return;
            case 3:
            this.release_locks = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 4:
            this.commit_button = ((System.Windows.Controls.Button)(target));
            
            #line 56 "..\..\..\..\Dialogs\RepoCommitDialog.xaml"
            this.commit_button.Click += new System.Windows.RoutedEventHandler(this.on_commit);
            
            #line default
            #line hidden
            return;
            case 5:
            this.cancel_button = ((System.Windows.Controls.Button)(target));
            
            #line 57 "..\..\..\..\Dialogs\RepoCommitDialog.xaml"
            this.cancel_button.Click += new System.Windows.RoutedEventHandler(this.on_cancel);
            
            #line default
            #line hidden
            return;
            case 6:
            this.commit_progress_bar = ((System.Windows.Controls.ProgressBar)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

