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

namespace StylingTemplatingOverview
{
    public partial class ButtonStages : UserControl
    {
        public ButtonStages()
        {
            InitializeComponent();
        }

        //<SnippetClickHandler>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("The button has been clicked.");
        }
        //</SnippetClickHandler>
    }
}
