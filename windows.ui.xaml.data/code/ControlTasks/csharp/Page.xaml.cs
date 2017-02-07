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
using Windows.UI.Xaml.Controls.Primitives;

namespace MessWithControls
{
    public partial class Page : UserControl
    {
        public Page()
        {
            InitializeComponent();
            //Note-this sample does not run because there are two button1 added to the visual tree..1 in XAML, 1 in code.
            //<snippet11>
            Button button1 = new Button();
            button1.Content = "Click Me too";
            button1.Name = "button1";
            this.LayoutRoot.Children.Add(button1);
            //</snippet11>

            //<snippet61>
           button6.Click += new RoutedEventHandler(button6_Click);
           //</snippet61>

            //<snippet21>
            Button button2 = new Button();
            button2.Height = 50;
            button2.Width = 100;
            button2.Background = new SolidColorBrush(Colors.Blue);
            button2.Content = "Click Me";
            //</snippet21>
        }

        private void myButton2_Click(object sender, RoutedEventArgs e)
        {

        }
        //<snippet51>
        private void button5_Click(object sender, RoutedEventArgs e)
        {

        }
        //</snippet51>
        //<snippet611>
        private void button6_Click(object sender, RoutedEventArgs e)
        {

        }
        //</snippet611>
       
    }
}
