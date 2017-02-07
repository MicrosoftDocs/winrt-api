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

namespace animation
{
    public partial class CompletedEvent : UserControl
    {
        public CompletedEvent()
        {
            InitializeComponent();
        }

	// <snippet1>
        private void onCompleted(object sender, object e)
        {
            TextBlock tb = new TextBlock();
            tb.Text = "Storyboard has completed!";
            MainPanel.Children.Add(tb);
        }
	// </snippet1>
    }
}
