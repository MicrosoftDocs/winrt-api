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

namespace animation_ovw_intro
{
    public partial class Page : UserControl
    {
        public Page()
        {
            InitializeComponent();
        }
        // <SnippetAnimation_ovw_intro_code>
        // When the user clicks the Rectangle, the animation
        // begins.
        private void Item_Clicked(object sender, PointerRoutedEventArgs e)
        {
            myStoryboard.Begin();
        }
        // </SnippetAnimation_ovw_intro_code>
    }
}
