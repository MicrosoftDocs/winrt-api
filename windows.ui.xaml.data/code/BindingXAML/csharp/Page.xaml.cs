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

namespace BindingXAML
{
    public partial class Page : UserControl
    {
        public Page()
        {
            InitializeComponent();
        }
    }

    //<Snippet4>
    public class Dog
    {
        public string DogName { get; set; }
    }

    //</Snippet4>
}
