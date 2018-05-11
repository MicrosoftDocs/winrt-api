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
//additional using statements
using Windows.UI.Xaml.Data;

namespace BindingInCode
{
    public partial class Page : UserControl
    {
        public Page()
        {
            InitializeComponent();
            
            //<SnippetBindingObject>
            // Create the source string.
            string s = "Hello";
            
            // Create the binding description.
            Binding b = new Binding();
            b.Mode = BindingMode.OneTime;
            b.Source = s;
            
            // Attach the binding to the target.
            TextBlock MyText = new TextBlock();
            MyText.SetBinding(TextBlock.TextProperty, b);
            //</SnippetBindingObject>
        }
    }
}
