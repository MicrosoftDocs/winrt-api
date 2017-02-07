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

namespace CheckboxEx
{
    public partial class Page : UserControl
    {
        public Page()
        {
            InitializeComponent();
        }

        //<snippet11>
        private void HandleCheck(object sender, RoutedEventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            if (cb.Name == "cb1") text1.Text = "Two-state CheckBox checked.";
            else text2.Text = "Three-state CheckBox checked.";
        }

        private void HandleUnchecked(object sender, RoutedEventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            if (cb.Name == "cb1") text1.Text = "Two-state CheckBox unchecked.";
            else text2.Text = "Three-state CheckBox unchecked.";
        }

        private void HandleThirdState(object sender, RoutedEventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            text2.Text = "Three-state CheckBox indeterminate.";
        }
        //</snippet11>
    }
}
