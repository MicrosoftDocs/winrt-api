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

namespace coloranimation_direct_targeting
{
    public partial class Page : UserControl
    {
        public Page()
        {
            InitializeComponent();
        }
        // <SnippetColoranimation_direct_targeting_cs>
        // Start the animation when the object loads.
        private void Start_Animation(object sender, RoutedEventArgs e)
        {
            colorStoryboard.Begin();
        }
        // </SnippetColoranimation_direct_targeting_cs>

    }
}
