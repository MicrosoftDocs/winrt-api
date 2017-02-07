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

namespace GridGetSet
{
    public partial class Page : UserControl
    {
        
        public Page()
        {
            InitializeComponent();

            

        }
        //<Snippet2>
        private void r1_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            Rectangle r = (Rectangle)sender;
            int row = Grid.GetRow(r);
            int col = Grid.GetColumn(r);

            txtRow.Text = row.ToString();
            txtCol.Text = col.ToString();
            
        }
        //</Snippet2>

        
        
    }
}
