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
using Windows.UI.Xaml.Shapes;
using Windows.UI;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace AddDeleteThemeTransition
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BlankPage : Page
    {
        public BlankPage()
        {
            this.InitializeComponent();
        }

        // <SnippetAddDeleteThemeTransition_code>
        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            if (rectangleItems.Items.Count > 0)
                rectangleItems.Items.RemoveAt(0);
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Color rectColor = new Color();
            rectColor.R = 200;
            rectColor.A = 250;
            Rectangle myRectangle = new Rectangle();
            myRectangle.Fill = new SolidColorBrush(rectColor);
            myRectangle.Width = 100;
            myRectangle.Height = 100;
            myRectangle.Margin = new Thickness(10);
            rectangleItems.Items.Add(myRectangle);

        }
        // </SnippetAddDeleteThemeTransition_code>

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }
    }
}
