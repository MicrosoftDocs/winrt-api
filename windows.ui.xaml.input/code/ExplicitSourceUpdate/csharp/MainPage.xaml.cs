using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;

namespace ExplicitSourceUpdate
{
    public partial class MainPage : UserControl
    {
        //<snippetCode>
        public class TestData
        {
            public String Test { get; set; }
        }

        TestData data;
        
        public MainPage()
        {
            InitializeComponent();
            data = new TestData { Test = "one" };
            textBox1.DataContext = data;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BindingExpression expression = textBox1.GetBindingExpression(TextBox.TextProperty);
            MessageBox.Show("Before UpdateSource, Test = " + data.Test);
            expression.UpdateSource();
            MessageBox.Show("After UpdateSource, Test = " + data.Test);
        }
        //</snippetCode>
    }

}
