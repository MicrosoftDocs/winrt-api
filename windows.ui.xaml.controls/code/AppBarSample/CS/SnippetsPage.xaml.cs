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
    public sealed partial class SnippetsPage : Page
    {
        public SnippetsPage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        
        // <SnippetAddButtonCode>
        Button addButton = null;
        
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // Add a button to an AppBar.
           
            if (rightPanel != null)
            {
                // Create the button to add
                addButton = new Button();

                // Apply the button style so that it looks like an AppBar button
                addButton.Style = (Style)App.Current.Resources["AddAppBarButtonStyle"];

                // Add the Click handler for the new button
                addButton.Click += Button_Click;

                // Add the button to the AppBar
                rightPanel.Children.Add(addButton);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Perform action here.
        }
        // </SnippetAddButtonCode>

        // <SnippetRemoveButtonCode>
        protected override void OnNavigatingFrom(NavigatingCancelEventArgs e)
        {
            if (rightPanel != null)
            {
                // Unhook the Click event handler for the button
                addButton.Click -= Button_Click;

                // Remove the button from the AppBar
                rightPanel.Children.Remove(addButton);
            }
        }
        // </SnippetRemoveButtonCode>
        

        // <SnippetAppBarMenuCode>
        private void SortMenuButton_Click(object sender, RoutedEventArgs e)
        {
            // <SnippetAppBarMenu1>
            Popup popUp = new Popup();
            // </SnippetAppBarMenu1>
            // <SnippetAppBarMenu2>
            popUp.IsLightDismissEnabled = true;
            // </SnippetAppBarMenu2>

            // <SnippetAppBarMenu3>
            StackPanel panel = new StackPanel();
            panel.Background = bottomAppBar.Background;
            panel.Height = 140;
            panel.Width = 180;
            // </SnippetAppBarMenu3>

            // <SnippetAppBarMenu4>
            panel.Transitions = new Windows.UI.Xaml.Media.Animation.TransitionCollection();
            panel.Transitions.Add(new Windows.UI.Xaml.Media.Animation.PopupThemeTransition());
            // </SnippetAppBarMenu4>

            // <SnippetAppBarMenu5>
            Button byRatingButton = new Button();
            byRatingButton.Content = "By rating";
            byRatingButton.Style = (Style)App.Current.Resources["TextButtonStyle"];
            byRatingButton.Margin = new Thickness(20, 5, 20, 5);
            byRatingButton.Click += SortButton_Click;
            panel.Children.Add(byRatingButton);
            // </SnippetAppBarMenu5>

            Button byMatchButton = new Button();
            byMatchButton.Content = "By match";
            byMatchButton.Style = (Style)App.Current.Resources["TextButtonStyle"];
            byMatchButton.Margin = new Thickness(20, 5, 20, 5);
            byMatchButton.Click += SortButton_Click;
            panel.Children.Add(byMatchButton);

            Button byDistanceButton = new Button();
            byDistanceButton.Content = "By distance";
            byDistanceButton.Style = (Style)App.Current.Resources["TextButtonStyle"];
            byDistanceButton.Margin = new Thickness(20, 5, 20, 5);
            byDistanceButton.Click += SortButton_Click;
            panel.Children.Add(byDistanceButton);

            // <SnippetAppBarMenu6>
            popUp.Child = panel;
            // </SnippetAppBarMenu6>
            // <SnippetAppBarMenu7>
            popUp.HorizontalOffset = Window.Current.CoreWindow.Bounds.Right - panel.Width - 4;
            popUp.VerticalOffset = Window.Current.CoreWindow.Bounds.Bottom - bottomAppBar.ActualHeight - panel.Height - 4;
            // </SnippetAppBarMenu7>

            // <SnippetAppBarMenu8>
            popUp.IsOpen = true;
            // </SnippetAppBarMenu8>
        }

        void SortButton_Click(object sender, RoutedEventArgs e)
        {
            // Sort.
        }
        // </SnippetAppBarMenuCode>
        
        // <SnippetHideAppBarCommandsCode>
        private void ToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            ToggleSwitch toggle = (ToggleSwitch)sender;

            if (toggle.IsOn == true)
            {
                pinCommands.Visibility = Visibility.Visible;
            }
            else
            {
                pinCommands.Visibility = Visibility.Collapsed;
            }
        }
        // </SnippetHideAppBarCommandsCode>
    }
}
