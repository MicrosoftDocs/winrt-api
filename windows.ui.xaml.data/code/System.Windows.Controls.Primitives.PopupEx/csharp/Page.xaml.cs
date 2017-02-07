using System;
using System.Collections.Generic;
using System.Linq;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Shapes;
using Windows.UI.Xaml.Controls.Primitives;

namespace Popup2
{
    public partial class Page : UserControl
    {
        public Page()
        {
            InitializeComponent();
        }
         // <snippet11>
        // Create the popup object.
        Popup p = new Popup();
        private void showPopup_Click(object sender, RoutedEventArgs e)
        {
            // Create some content to show in the popup. Typically you would 
            // create a user control.
            Border border = new Border();
            border.BorderBrush = new SolidColorBrush(Colors.Red);
            border.BorderThickness = new Thickness(5.0);
           
            StackPanel panel1 = new StackPanel();
            panel1.Background = new SolidColorBrush(Colors.Gray);
           
            Button button1 = new Button();
            button1.Content = "Close";
            button1.Margin = new Thickness(5.0);
            button1.Click += new RoutedEventHandler(button1_Click);
            TextBlock textblock1 = new TextBlock();
            textblock1.Text = "The popup control";
            textblock1.Margin = new Thickness(5.0);
            panel1.Children.Add(textblock1);
            panel1.Children.Add(button1);
            border.Child = panel1;
           
            // Set the Child property of Popup to the border 
            // which contains a stackpanel, textblock and button.
            p.Child = border;

            // Set where the popup will show up on the screen.
            p.VerticalOffset = 25;
            p.HorizontalOffset = 25;
            
            // Open the popup.
            p.IsOpen = true;
           
        }

        void button1_Click(object sender, RoutedEventArgs e)
        {
            // Close the popup.
            p.IsOpen = false;

        }
        // </snippet11>
    }

}
