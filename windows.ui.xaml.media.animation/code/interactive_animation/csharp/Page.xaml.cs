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

namespace interactive_animation
{
    public partial class Page : UserControl
    {
        public Page()
        {
            InitializeComponent();
        }
        // <SnippetInteractive_animation_cs>
        private void Animation_Begin(object sender, RoutedEventArgs e)
        {
            myStoryboard.Begin();
        }
        private void Animation_Pause(object sender, RoutedEventArgs e)
        {
            myStoryboard.Pause();
        }
        private void Animation_Resume(object sender, RoutedEventArgs e)
        {
            myStoryboard.Resume();
        }
        private void Animation_Stop(object sender, RoutedEventArgs e)
        {
            myStoryboard.Stop();
        }
        // </SnippetInteractive_animation_cs>

        // <SnippetBounceEase_code>
        // When the user clicks the rectangle, the animation
        // begins. 
        private void Pointer_Clicked(object sender, PointerRoutedEventArgs e)
        {
            myStoryboard.Begin();
        }
        // </SnippetBounceEase_code>

    }
}
