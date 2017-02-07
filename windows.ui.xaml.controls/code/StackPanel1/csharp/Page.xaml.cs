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

namespace StackPanel1
{
    public partial class Page : UserControl
    {
        public Page()
        {
            InitializeComponent();
            Rearrange();
        }
        //<Snippet01>
        private void Rearrange()
        {
            TextBlock TB4 = new TextBlock();
            TB4.Text = "Age";
            MyStackPanel.Children.Insert(2, TB4);
            
        }
        //</Snippet01>
    }

}
