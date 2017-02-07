using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

namespace rEZ
{
    /// <summary>
    /// A basic page that provides characteristics common to most applications.
    /// </summary>
    public sealed partial class BasicPage1 : Page
    {
        public BasicPage1()
        {
            this.InitializeComponent();
        }

//<SnippetAddHandler>
        private void pageRoot_Tapped(object sender, TappedRoutedEventArgs e)
        {
            //implementation
        }
        private void pageRoot_Loaded_1(object sender, RoutedEventArgs e)
        {
            this.AddHandler(UIElement.TappedEvent, new TappedEventHandler(pageRoot_Tapped), true);
        }
//</SnippetAddHandler>
    }
}
