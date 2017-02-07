// <SnippetPage2Code>
using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace AppBarSample
{
    public sealed partial class Page2 : Page
    {
        Page rootPage = null;

        public Page2()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            rootPage = (Page)e.Parameter;
        }
    }
}
// </SnippetPage2Code>
