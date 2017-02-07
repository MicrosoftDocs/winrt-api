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

namespace ItemContainerGeneratorEx
{
    public partial class MainPage : UserControl
    {
        //<snippet10>
        public MainPage()
        {
            InitializeComponent();
            string[] myItems = new string[]{"Item 1", "Item 2", "Item 3", "Item 4", "Item 5"};
            myTreeView.DataContext = myItems;
        }
        static int count = 1;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TreeViewItem item = (TreeViewItem)myTreeView.ItemContainerGenerator.ContainerFromIndex(3);
            item.IsExpanded = true;
            if (count < 5)
            {
                item.Items.Add("Child " + count.ToString());
                count++;
            }
        }
        //</snippet10>
    }
}
