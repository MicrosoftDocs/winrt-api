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
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI;

namespace GetLayoutInfo
{
    public partial class Page : UserControl
    {
        public Page()
        {
            InitializeComponent();
        }

        //<Snippet2>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Get Layout Slot of Rectangle
            Windows.Foundation.Rect r1 = LayoutInformation.GetLayoutSlot(rect1);
            RectangleGeometry rg1 = new RectangleGeometry();
            rg1.Rect = r1;
            Path mypath = new Path();
            mypath.Data = rg1;
            mypath.Stroke = new SolidColorBrush(Colors.Red);
            mypath.StrokeThickness = 4;
            LayoutRoot.Children.Add(mypath);
        }
        //</Snippet2>

    }
}
