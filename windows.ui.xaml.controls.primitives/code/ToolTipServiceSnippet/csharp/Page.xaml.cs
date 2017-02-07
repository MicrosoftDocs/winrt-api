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

namespace ToolTipServiceSnippet
{
    public partial class Page : UserControl
    {
        public Page()
        {
            InitializeComponent();
        }

        //<snippet2>
        private void Button_Loaded(object sender, RoutedEventArgs e)
        {
            ToolTipService.SetToolTip((Button)sender, 
                "Adding tool tip through code");
        }
        //</snippet2>

       
    }
}
