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

namespace WebBrowserEx
{
    public partial class MainPage : UserControl
    {
       
        public MainPage()
        {
            InitializeComponent();

        }
        //<snippet10>
       
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            WB1.Navigate(new Uri("http://localhost/HTMLPage2.htm"));
           
        }
        //</snippet10>
    }

}
