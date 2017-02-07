using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Windows.UI;
using Windows.UI.Text;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Shapes;

namespace ContentModelsCodeOnly
{
    public partial class Page : UserControl
    {
       
        public Page()
        {
            InitializeComponent();

            //<snippet11>
            TextBlock tBlock1 = new TextBlock();
            tBlock1.Text = "TextBlock";
            LayoutRoot.Children.Add(tBlock1);
            //</snippet11>

            //<snippet21>
            TextBlock tBlock2 = new TextBlock();
            Run run1 = new Run();
            run1.Text = "Text";
            run1.FontFamily = new FontFamily("Arial");
            run1.FontSize = 20.0;
            tBlock2.Inlines.Add(run1);
            tBlock2.Inlines.Add(new LineBreak());
            run1 = new Run();
            run1.Text = "using Inlines";
            run1.FontFamily = new FontFamily("Courier New");
            run1.FontSize = 14.0;
            run1.FontWeight = FontWeights.Bold;
            tBlock2.Inlines.Add(run1);
            LayoutRoot.Children.Add(tBlock2);
            //</snippet21>

            //<snippet31>
            TextBox tBox1 = new TextBox();
            tBox1.Text = "TextBox with a line of text that wraps.";
            tBox1.FontFamily = new FontFamily("Arial");
            tBox1.TextWrapping = TextWrapping.Wrap;
            tBox1.Width = 100.0;
            LayoutRoot.Children.Add(tBox1);
            //</snippet31>

            //<snippet41>
            Button button1 = new Button();
            button1.Width = 50;
            button1.Height = 30;
            StackPanel panel1 = new StackPanel();
            panel1.Orientation = Orientation.Horizontal;
            Rectangle rect1 = new Rectangle();
            rect1.Width = 10;
            rect1.Fill = new SolidColorBrush(Colors.Green);
            TextBlock tb3 = new TextBlock();
            tb3.Margin = new Thickness(2);
            tb3.Text = "Green";
            tb3.TextAlignment = TextAlignment.Center;
            panel1.Children.Add(tb3);
            panel1.Children.Add(rect1);
            button1.Content = panel1;
            LayoutRoot.Children.Add(button1);
            //</snippet41>

            //<snippet61>
            ComboBox cb1 = new ComboBox();
            cb1.Items.Add("Item 1");
            cb1.Items.Add("Item 2");
            cb1.Items.Add("Item 3");
            LayoutRoot.Children.Add(cb1);
            //</snippet61>

        }
    }
}
