using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Shapes;

namespace ButtonBaseClickEventEx
{
    public partial class Page : UserControl
    {
        public Page()
        {
            InitializeComponent();
        }

        //<snippet41>
        void submitButtonClick(object sender, RoutedEventArgs e)
        {
            textBlock1.Text = "You clicked the Submit button.";
        }
        //</snippet41>

       
    }
}
