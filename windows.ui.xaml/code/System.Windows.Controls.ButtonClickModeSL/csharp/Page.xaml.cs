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

namespace ButtonEx
{
    public partial class Page : UserControl
    {
        public Page()
        {
            InitializeComponent();
        }
        //<snippet11>
        void OnClick1(object sender, RoutedEventArgs e)
        {
            btn1.Foreground = new SolidColorBrush(Windows.UI.Colors.Blue);
            text1.Text = "Click event occurs on Hover.";
            text2.Text = "";
            text3.Text = "";
        }

        void OnClick2(object sender, RoutedEventArgs e)
        {
            btn2.Foreground = new SolidColorBrush(Windows.UI.Colors.Green);
            text1.Text = "";
            text2.Text = "Click event occurs on Press.";
            text3.Text = "";
        }

        void OnClick3(object sender, RoutedEventArgs e)
        {
            btn1.Foreground = new SolidColorBrush(Windows.UI.Colors.Green);
            btn2.Foreground = new SolidColorBrush(Windows.UI.Colors.Blue);
            text1.Text = "";
            text2.Text = "";
            text3.Text = "Click event occurs on Release.";
        }
        //</snippet11>
     
    }
}
