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

namespace timer
{
    public partial class Page : UserControl
    {
        public Page()
        {
            InitializeComponent();
        }

        // <snippetCodeBehind>
        public void StartTimer(object o,RoutedEventArgs sender)
        {
            DispatcherTimer myDispatcherTimer = new DispatcherTimer();
            myDispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, 100); // 100 Milliseconds  
            myDispatcherTimer.Tick += new Windows.UI.Xaml.EventHandler(Each_Tick);
            myDispatcherTimer.Start();
        }

        // A variable to count with.
        int i = 0;

        // Raised every 100 miliseconds while the DispatcherTimer is active.
        public void Each_Tick(object o, object sender)
        {
            mytextBlock.Text = "Count up: " + i++.ToString();
        }
        // </snippetCodeBehind>
    }
}
