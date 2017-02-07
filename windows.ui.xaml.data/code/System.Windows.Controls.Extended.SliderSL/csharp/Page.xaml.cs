// <snippet10>
using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;

namespace SliderSnippets
{
    public partial class Page : UserControl
    {
        public Page()
        {
            InitializeComponent();
        }

        // <snippet11>
        private void slider2_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            string msg = String.Format("Current value: {0}", e.NewValue);
            this.textBlock1.Text = msg;
        }
        // </snippet11>
        
    }
}
// </snippet10>