// <SnippetGlobalPageCode>
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace AppBarSample
{
    public sealed partial class GlobalPage : Page
    {
        public GlobalPage()
        {
            this.InitializeComponent();
        }
 
        // <SnippetNavCommands>
        Page rootPage = null;
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            rootPage = e.Parameter as Page;
            frame1.Navigate(typeof(Page1), this);
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            if (frame1.CanGoBack)
            {
                frame1.GoBack();
            }
            else if (rootPage != null && rootPage.Frame.CanGoBack)
            {
                rootPage.Frame.GoBack();
            }
        }

        private void Page1Button_Click(object sender, RoutedEventArgs e)
        {
            frame1.Navigate(typeof(Page1), this);
        }

        private void Page2Button_Click(object sender, RoutedEventArgs e)
        {
            frame1.Navigate(typeof(Page2), this);
        }
        // </SnippetNavCommands>
    }
}
// </SnippetGlobalPageCode>
