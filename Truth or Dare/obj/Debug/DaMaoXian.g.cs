﻿#pragma checksum "C:\Users\hkl\Desktop\30mangoBgAnimation\mangoBgAnimation\mangoBgAnimation\DaMaoXian.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E3EC9017BDBFD870C8BF0E0AD0223736"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;
using mangoBgAnimation;


namespace mangoBgAnimation {
    
    
    public partial class DaMaoXian : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Media.Animation.Storyboard sb_shuffle;
        
        internal System.Windows.Media.Animation.Storyboard sb_next;
        
        internal System.Windows.Media.Animation.Storyboard Storyboard1;
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal mangoBgAnimation.BackGroundControl bgControl;
        
        internal System.Windows.Controls.StackPanel stackPanel;
        
        internal System.Windows.Controls.TextBlock title1;
        
        internal System.Windows.Controls.TextBlock content1;
        
        internal mangoBgAnimation.BackGroundControl bgControl1;
        
        internal System.Windows.Controls.StackPanel stackPanel1;
        
        internal System.Windows.Controls.TextBlock title2;
        
        internal System.Windows.Controls.TextBlock content2;
        
        internal System.Windows.Controls.Button begin;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/mangoBgAnimation;component/DaMaoXian.xaml", System.UriKind.Relative));
            this.sb_shuffle = ((System.Windows.Media.Animation.Storyboard)(this.FindName("sb_shuffle")));
            this.sb_next = ((System.Windows.Media.Animation.Storyboard)(this.FindName("sb_next")));
            this.Storyboard1 = ((System.Windows.Media.Animation.Storyboard)(this.FindName("Storyboard1")));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.bgControl = ((mangoBgAnimation.BackGroundControl)(this.FindName("bgControl")));
            this.stackPanel = ((System.Windows.Controls.StackPanel)(this.FindName("stackPanel")));
            this.title1 = ((System.Windows.Controls.TextBlock)(this.FindName("title1")));
            this.content1 = ((System.Windows.Controls.TextBlock)(this.FindName("content1")));
            this.bgControl1 = ((mangoBgAnimation.BackGroundControl)(this.FindName("bgControl1")));
            this.stackPanel1 = ((System.Windows.Controls.StackPanel)(this.FindName("stackPanel1")));
            this.title2 = ((System.Windows.Controls.TextBlock)(this.FindName("title2")));
            this.content2 = ((System.Windows.Controls.TextBlock)(this.FindName("content2")));
            this.begin = ((System.Windows.Controls.Button)(this.FindName("begin")));
        }
    }
}
