﻿#pragma checksum "..\..\..\..\Views\ChatPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8F8927FA19D285801FD194AA873AF062F637A97C"
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
using System.Windows.Controls.Ribbon;
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
using UXModule.Views;
using ViewModel.ChatViewModel;


namespace UXModule.Views {
    
    
    /// <summary>
    /// ChatPage
    /// </summary>
    public partial class ChatPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 73 "..\..\..\..\Views\ChatPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel TopDockPanel;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\..\Views\ChatPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SearchButton;
        
        #line default
        #line hidden
        
        
        #line 109 "..\..\..\..\Views\ChatPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel SearchPanel;
        
        #line default
        #line hidden
        
        
        #line 110 "..\..\..\..\Views\ChatPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BackFromSearchButton;
        
        #line default
        #line hidden
        
        
        #line 111 "..\..\..\..\Views\ChatPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchTextBox;
        
        #line default
        #line hidden
        
        
        #line 117 "..\..\..\..\Views\ChatPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ClearSearchButton;
        
        #line default
        #line hidden
        
        
        #line 121 "..\..\..\..\Views\ChatPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView MessagesListView;
        
        #line default
        #line hidden
        
        
        #line 199 "..\..\..\..\Views\ChatPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.Popup NotFoundPopup;
        
        #line default
        #line hidden
        
        
        #line 210 "..\..\..\..\Views\ChatPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ClientDropdown;
        
        #line default
        #line hidden
        
        
        #line 222 "..\..\..\..\Views\ChatPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MessageTextBox;
        
        #line default
        #line hidden
        
        
        #line 261 "..\..\..\..\Views\ChatPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.Popup EmojiPopup;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.7.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/UXModule;V1.0.0.0;component/views/chatpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\ChatPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.7.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.TopDockPanel = ((System.Windows.Controls.DockPanel)(target));
            return;
            case 2:
            this.SearchButton = ((System.Windows.Controls.Button)(target));
            
            #line 80 "..\..\..\..\Views\ChatPage.xaml"
            this.SearchButton.Click += new System.Windows.RoutedEventHandler(this.SearchButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.SearchPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 4:
            this.BackFromSearchButton = ((System.Windows.Controls.Button)(target));
            
            #line 110 "..\..\..\..\Views\ChatPage.xaml"
            this.BackFromSearchButton.Click += new System.Windows.RoutedEventHandler(this.BackFromSearchButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.SearchTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 114 "..\..\..\..\Views\ChatPage.xaml"
            this.SearchTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.SearchTextBox_TextChanged);
            
            #line default
            #line hidden
            
            #line 115 "..\..\..\..\Views\ChatPage.xaml"
            this.SearchTextBox.GotFocus += new System.Windows.RoutedEventHandler(this.SearchTextBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 116 "..\..\..\..\Views\ChatPage.xaml"
            this.SearchTextBox.KeyDown += new System.Windows.Input.KeyEventHandler(this.SearchTextBox_KeyDown);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ClearSearchButton = ((System.Windows.Controls.Button)(target));
            
            #line 117 "..\..\..\..\Views\ChatPage.xaml"
            this.ClearSearchButton.Click += new System.Windows.RoutedEventHandler(this.ClearSearchButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.MessagesListView = ((System.Windows.Controls.ListView)(target));
            return;
            case 10:
            this.NotFoundPopup = ((System.Windows.Controls.Primitives.Popup)(target));
            return;
            case 11:
            this.ClientDropdown = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 12:
            this.MessageTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 227 "..\..\..\..\Views\ChatPage.xaml"
            this.MessageTextBox.GotFocus += new System.Windows.RoutedEventHandler(this.MessageTextBox_GotFocus);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 236 "..\..\..\..\Views\ChatPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.EmojiPopupButton_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            this.EmojiPopup = ((System.Windows.Controls.Primitives.Popup)(target));
            return;
            case 15:
            
            #line 264 "..\..\..\..\Views\ChatPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Emoji_Click);
            
            #line default
            #line hidden
            return;
            case 16:
            
            #line 265 "..\..\..\..\Views\ChatPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Emoji_Click);
            
            #line default
            #line hidden
            return;
            case 17:
            
            #line 266 "..\..\..\..\Views\ChatPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Emoji_Click);
            
            #line default
            #line hidden
            return;
            case 18:
            
            #line 267 "..\..\..\..\Views\ChatPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Emoji_Click);
            
            #line default
            #line hidden
            return;
            case 19:
            
            #line 268 "..\..\..\..\Views\ChatPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Emoji_Click);
            
            #line default
            #line hidden
            return;
            case 20:
            
            #line 269 "..\..\..\..\Views\ChatPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Emoji_Click);
            
            #line default
            #line hidden
            return;
            case 21:
            
            #line 270 "..\..\..\..\Views\ChatPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Emoji_Click);
            
            #line default
            #line hidden
            return;
            case 22:
            
            #line 271 "..\..\..\..\Views\ChatPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Emoji_Click);
            
            #line default
            #line hidden
            return;
            case 23:
            
            #line 272 "..\..\..\..\Views\ChatPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Emoji_Click);
            
            #line default
            #line hidden
            return;
            case 24:
            
            #line 273 "..\..\..\..\Views\ChatPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Emoji_Click);
            
            #line default
            #line hidden
            return;
            case 25:
            
            #line 274 "..\..\..\..\Views\ChatPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Emoji_Click);
            
            #line default
            #line hidden
            return;
            case 26:
            
            #line 275 "..\..\..\..\Views\ChatPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Emoji_Click);
            
            #line default
            #line hidden
            return;
            case 27:
            
            #line 276 "..\..\..\..\Views\ChatPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Emoji_Click);
            
            #line default
            #line hidden
            return;
            case 28:
            
            #line 277 "..\..\..\..\Views\ChatPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Emoji_Click);
            
            #line default
            #line hidden
            return;
            case 29:
            
            #line 278 "..\..\..\..\Views\ChatPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Emoji_Click);
            
            #line default
            #line hidden
            return;
            case 30:
            
            #line 279 "..\..\..\..\Views\ChatPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Emoji_Click);
            
            #line default
            #line hidden
            return;
            case 31:
            
            #line 280 "..\..\..\..\Views\ChatPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Emoji_Click);
            
            #line default
            #line hidden
            return;
            case 32:
            
            #line 281 "..\..\..\..\Views\ChatPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Emoji_Click);
            
            #line default
            #line hidden
            return;
            case 33:
            
            #line 282 "..\..\..\..\Views\ChatPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Emoji_Click);
            
            #line default
            #line hidden
            return;
            case 34:
            
            #line 283 "..\..\..\..\Views\ChatPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Emoji_Click);
            
            #line default
            #line hidden
            return;
            case 35:
            
            #line 284 "..\..\..\..\Views\ChatPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Emoji_Click);
            
            #line default
            #line hidden
            return;
            case 36:
            
            #line 285 "..\..\..\..\Views\ChatPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Emoji_Click);
            
            #line default
            #line hidden
            return;
            case 37:
            
            #line 286 "..\..\..\..\Views\ChatPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Emoji_Click);
            
            #line default
            #line hidden
            return;
            case 38:
            
            #line 287 "..\..\..\..\Views\ChatPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Emoji_Click);
            
            #line default
            #line hidden
            return;
            case 39:
            
            #line 288 "..\..\..\..\Views\ChatPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Emoji_Click);
            
            #line default
            #line hidden
            return;
            case 40:
            
            #line 289 "..\..\..\..\Views\ChatPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Emoji_Click);
            
            #line default
            #line hidden
            return;
            case 41:
            
            #line 290 "..\..\..\..\Views\ChatPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Emoji_Click);
            
            #line default
            #line hidden
            return;
            case 42:
            
            #line 291 "..\..\..\..\Views\ChatPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Emoji_Click);
            
            #line default
            #line hidden
            return;
            case 43:
            
            #line 292 "..\..\..\..\Views\ChatPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Emoji_Click);
            
            #line default
            #line hidden
            return;
            case 44:
            
            #line 293 "..\..\..\..\Views\ChatPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Emoji_Click);
            
            #line default
            #line hidden
            return;
            case 45:
            
            #line 294 "..\..\..\..\Views\ChatPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Emoji_Click);
            
            #line default
            #line hidden
            return;
            case 46:
            
            #line 295 "..\..\..\..\Views\ChatPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Emoji_Click);
            
            #line default
            #line hidden
            return;
            case 47:
            
            #line 296 "..\..\..\..\Views\ChatPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Emoji_Click);
            
            #line default
            #line hidden
            return;
            case 48:
            
            #line 297 "..\..\..\..\Views\ChatPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Emoji_Click);
            
            #line default
            #line hidden
            return;
            case 49:
            
            #line 298 "..\..\..\..\Views\ChatPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Emoji_Click);
            
            #line default
            #line hidden
            return;
            case 50:
            
            #line 299 "..\..\..\..\Views\ChatPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Emoji_Click);
            
            #line default
            #line hidden
            return;
            case 51:
            
            #line 300 "..\..\..\..\Views\ChatPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Emoji_Click);
            
            #line default
            #line hidden
            return;
            case 52:
            
            #line 301 "..\..\..\..\Views\ChatPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Emoji_Click);
            
            #line default
            #line hidden
            return;
            case 53:
            
            #line 302 "..\..\..\..\Views\ChatPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Emoji_Click);
            
            #line default
            #line hidden
            return;
            case 54:
            
            #line 303 "..\..\..\..\Views\ChatPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Emoji_Click);
            
            #line default
            #line hidden
            return;
            case 55:
            
            #line 304 "..\..\..\..\Views\ChatPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Emoji_Click);
            
            #line default
            #line hidden
            return;
            case 56:
            
            #line 305 "..\..\..\..\Views\ChatPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Emoji_Click);
            
            #line default
            #line hidden
            return;
            case 57:
            
            #line 306 "..\..\..\..\Views\ChatPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Emoji_Click);
            
            #line default
            #line hidden
            return;
            case 58:
            
            #line 307 "..\..\..\..\Views\ChatPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Emoji_Click);
            
            #line default
            #line hidden
            return;
            case 59:
            
            #line 308 "..\..\..\..\Views\ChatPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Emoji_Click);
            
            #line default
            #line hidden
            return;
            case 60:
            
            #line 309 "..\..\..\..\Views\ChatPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Emoji_Click);
            
            #line default
            #line hidden
            return;
            case 61:
            
            #line 310 "..\..\..\..\Views\ChatPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Emoji_Click);
            
            #line default
            #line hidden
            return;
            case 62:
            
            #line 311 "..\..\..\..\Views\ChatPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Emoji_Click);
            
            #line default
            #line hidden
            return;
            case 63:
            
            #line 312 "..\..\..\..\Views\ChatPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Emoji_Click);
            
            #line default
            #line hidden
            return;
            case 64:
            
            #line 313 "..\..\..\..\Views\ChatPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Emoji_Click);
            
            #line default
            #line hidden
            return;
            case 65:
            
            #line 314 "..\..\..\..\Views\ChatPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Emoji_Click);
            
            #line default
            #line hidden
            return;
            case 66:
            
            #line 315 "..\..\..\..\Views\ChatPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Emoji_Click);
            
            #line default
            #line hidden
            return;
            case 67:
            
            #line 316 "..\..\..\..\Views\ChatPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Emoji_Click);
            
            #line default
            #line hidden
            return;
            case 68:
            
            #line 317 "..\..\..\..\Views\ChatPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Emoji_Click);
            
            #line default
            #line hidden
            return;
            case 69:
            
            #line 318 "..\..\..\..\Views\ChatPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Emoji_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.7.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 8:
            
            #line 171 "..\..\..\..\Views\ChatPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OptionsButton_Click);
            
            #line default
            #line hidden
            break;
            case 9:
            
            #line 175 "..\..\..\..\Views\ChatPage.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.Delete_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}
