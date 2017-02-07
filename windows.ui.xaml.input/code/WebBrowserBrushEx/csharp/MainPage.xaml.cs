//<snippetCodeBehind>
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

namespace WebBrowserBrushEx
{
    public partial class MainPage : UserControl
    {
        DispatcherTimer dt = new DispatcherTimer();
        public MainPage()
        {
            InitializeComponent();
            dt.Interval = new TimeSpan(100);
            dt.Tick += new Windows.UI.Xaml.EventHandler(dt_Tick);
        }

        void dt_Tick(object sender, object e)
        {
            htmlBrush.Redraw();

        }

        bool animating = false;

        private void LayoutRoot_PointerMoved(object sender, PointerRoutedEventArgs e)
        {
            dt.Start();
            if (!animating)
            {
                WB1.Visibility = Visibility.Collapsed;
                brush.Visibility = Visibility.Visible;
                Spin.Begin();
                animating = true;
            }
        }

        private void brush_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            Spin.Stop();
            WB1.Visibility = Visibility.Visible;
            brush.Visibility = Visibility.Collapsed;
            animating = false;
        }
    }
}
//</snippetCodeBehind>
