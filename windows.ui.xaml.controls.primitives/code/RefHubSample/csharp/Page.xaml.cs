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


namespace RefHubSample
{
    public partial class Page : UserControl
    {
        
        public Page()
        {
            InitializeComponent();
           

            
        }

        //<Snippet2>
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (txt1 != null)
            {
                ComboBox box = (ComboBox)sender;
                int index = (sender as ComboBox).SelectedIndex;
                Grid.SetColumnSpan(txt1, index + 1);
            }
        }
        //</Snippet2>
       
    }
}
