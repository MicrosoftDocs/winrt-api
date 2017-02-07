// <SnippetPage1Code>
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace AppBarSample
{
    public sealed partial class Page1 : Page
    {
        Page rootPage = null;

        public Page1()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            rootPage = (Page)e.Parameter;
        }
    }
}
// </SnippetPage1Code>
