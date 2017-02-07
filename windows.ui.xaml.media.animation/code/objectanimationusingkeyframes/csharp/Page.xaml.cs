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

namespace objectanimationusingkeyframes
{
    public partial class Page : UserControl
    {
        public Page()
        {
            InitializeComponent();
        }
        // <SnippetObjectanimationusingkeyframes_cs>
        // When the rectangle loads, begin the animation.
        private void Rectangle_Loaded(object sender, RoutedEventArgs e)
        {
            myStoryboard.Begin();
        }
        // </SnippetObjectanimationusingkeyframes_cs>
    }
}
