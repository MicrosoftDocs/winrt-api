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

namespace transforms_ovw_interactive_transforms
{
    public partial class Page : UserControl
    {
        public Page()
        {
            InitializeComponent();
        }
        // <Snippettransforms_ovw_interactive_transforms_code>
        private void HandlePointerPressed(object sender, PointerRoutedEventArgs e)
        {
            // Increase ScaleX and ScaleY by 25%.
            myScaleTransform.ScaleX = myScaleTransform.ScaleX * 1.25;
            myScaleTransform.ScaleY = myScaleTransform.ScaleY * 1.25;
        }
        // </Snippettransforms_ovw_interactive_transforms_code>
    }
}
