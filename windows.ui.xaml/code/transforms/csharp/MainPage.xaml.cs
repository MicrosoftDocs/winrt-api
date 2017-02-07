using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;

namespace transforms
{
    partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ChangeSnippet_Click(object sender, RoutedEventArgs e)
        {
            Button srcButton = sender as Button;

            if (null != srcButton)
            {

                string pageName = "transforms." + srcButton.Name;
                theframe.Navigate(pageName);
                //  theframe.Navigate(srcButton.Name);
            }
        }
    }
}
