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

namespace change_targetname_1
{
    public partial class Page : UserControl
    {
        public Page()
        {
            InitializeComponent();
        }
        // <SnippetChange_targetname_1_cs>
        private void Start_Animation(object sender, PointerRoutedEventArgs e)
        {

            // If the Storyboard is running and you try to change
            // properties of its animation objects programmatically, 
            // an error will occur.
            myStoryboard.Stop();

            // Get a reference to the rectangle that was clicked.
            Rectangle myRect = (Rectangle)sender;

            // Change the TargetName of the animation to the name of the
            // rectangle that was clicked.
            myDoubleAnimation.SetValue(Storyboard.TargetNameProperty, myRect.Name);

            // Begin the animation.
            myStoryboard.Begin();
        }
        // </SnippetChange_targetname_1_cs>

    }
}
