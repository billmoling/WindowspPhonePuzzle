﻿#pragma checksum "E:\Develop\Windows Phone\WindowsPhonePuzzle\WindowsPhonePuzzle\PuzzlePage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "BCFC6E4A5E6B811CD4433F4B3A48F32E"
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


namespace WindowsPhonePuzzle {
    
    
    public partial class PuzzlePage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Media.Animation.Storyboard WinTransition;
        
        internal System.Windows.Media.Animation.Storyboard ResetWinTransition;
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Button SolveButton;
        
        internal System.Windows.Controls.StackPanel StatusPanel;
        
        internal System.Windows.Controls.TextBlock TotalMovesTextBlock;
        
        internal System.Windows.Controls.Border CongratsBorder;
        
        internal System.Windows.Controls.Border border;
        
        internal System.Windows.Controls.Image PreviewImage;
        
        internal System.Windows.Controls.Canvas GameContainer;
        
        internal System.Windows.Controls.TextBlock TapToContinueTextBlock;
        
        internal System.Windows.Controls.Button LoadButton;
        
        internal System.Windows.Controls.Button SaveButton;
        
        internal System.Windows.Controls.Button ClearStorageButton;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/WindowsPhonePuzzle;component/PuzzlePage.xaml", System.UriKind.Relative));
            this.WinTransition = ((System.Windows.Media.Animation.Storyboard)(this.FindName("WinTransition")));
            this.ResetWinTransition = ((System.Windows.Media.Animation.Storyboard)(this.FindName("ResetWinTransition")));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.SolveButton = ((System.Windows.Controls.Button)(this.FindName("SolveButton")));
            this.StatusPanel = ((System.Windows.Controls.StackPanel)(this.FindName("StatusPanel")));
            this.TotalMovesTextBlock = ((System.Windows.Controls.TextBlock)(this.FindName("TotalMovesTextBlock")));
            this.CongratsBorder = ((System.Windows.Controls.Border)(this.FindName("CongratsBorder")));
            this.border = ((System.Windows.Controls.Border)(this.FindName("border")));
            this.PreviewImage = ((System.Windows.Controls.Image)(this.FindName("PreviewImage")));
            this.GameContainer = ((System.Windows.Controls.Canvas)(this.FindName("GameContainer")));
            this.TapToContinueTextBlock = ((System.Windows.Controls.TextBlock)(this.FindName("TapToContinueTextBlock")));
            this.LoadButton = ((System.Windows.Controls.Button)(this.FindName("LoadButton")));
            this.SaveButton = ((System.Windows.Controls.Button)(this.FindName("SaveButton")));
            this.ClearStorageButton = ((System.Windows.Controls.Button)(this.FindName("ClearStorageButton")));
        }
    }
}

