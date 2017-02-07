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

namespace CubicEase
{
    public partial class Page : UserControl
    {
        public Page()
        {
            InitializeComponent();
        }
        // <SnippetCubicEase_code>
        // When the user clicks the rectangle, the animation
        // begins. 
        private void Pointer_Clicked(object sender, PointerRoutedEventArgs e)
        {
            myStoryboard.Begin();
        }
        // </SnippetCubicEase_code>

    }
}
