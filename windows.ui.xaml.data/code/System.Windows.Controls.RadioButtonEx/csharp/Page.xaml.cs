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

namespace RadioButtonEx
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
            RadioButton rb = sender as RadioButton;
            choiceTextBlock.Text = "You chose: " + rb.GroupName + ": " + rb.Name;
        }
        //</snippet11>
    }
}
