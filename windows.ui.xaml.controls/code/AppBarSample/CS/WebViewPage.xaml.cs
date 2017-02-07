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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace AppBarSample
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class WebViewPage : Page
    {
        public WebViewPage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        // <SnippetAppBarOpenClose>
        private void AppBar_Opened(object sender, object e)
        {
            WebViewBrush wvb = new WebViewBrush();
            wvb.SourceName = "contentView";
            wvb.Redraw();
            contentViewRect.Fill = wvb;
            contentView.Visibility = Windows.UI.Xaml.Visibility.Collapsed;     
        }

        private void AppBar_Closed(object sender, object e)
        {
            contentView.Visibility = Windows.UI.Xaml.Visibility.Visible;
            contentViewRect.Fill = new SolidColorBrush(Windows.UI.Colors.Transparent);
        }

        private void Refresh_Click(object sender, RoutedEventArgs e)
        {
            contentView.Navigate(new Uri("http://www.contoso.com"));
            bottomAppBar.IsOpen = false;
        }
        // </SnippetAppBarOpenClose>

    }
}
