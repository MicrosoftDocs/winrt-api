using System;
using System.Collections.Generic;
using System.Linq;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Shapes;

namespace RepeatButtonEx
{
    public partial class Page : UserControl
    {
        public Page()
        {
            InitializeComponent();
        }
        //<snippet11>
        static int Clicks = 0;
        private void RepeatButton_Click(object sender, RoutedEventArgs e)
        {
            Clicks += 1;
            clickTextBlock.Text = "Number of Clicks: " + Clicks;
        }
        //</snippet11>
    }
}
