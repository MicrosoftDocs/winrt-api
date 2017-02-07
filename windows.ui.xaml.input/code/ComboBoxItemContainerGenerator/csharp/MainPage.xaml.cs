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


namespace ComboBoxItemContainerGenerator
{
    public partial class MainPage : UserControl
    {
        //<snippetCSharpCode>
        public MainPage()
        {
            InitializeComponent();
            System.Collections.ObjectModel.ObservableCollection<FontFamily> fonts = 
                new System.Collections.ObjectModel.ObservableCollection<FontFamily>();
            FontFamily f1 = new FontFamily("Arial");
            fonts.Add(f1);
            FontFamily f2 = new FontFamily("Courier New");
            fonts.Add(f2);
            FontFamily f3 = new FontFamily("Times New Roman");
            CB.DataContext = fonts;
        }

       
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ComboBoxItem selectedItemContainer = 
                (ComboBoxItem)CB.ItemContainerGenerator.ContainerFromItem(CB.SelectedItem);
            if (selectedItemContainer != null)
            {
                selectedItemContainer.FontFamily = (FontFamily)CB.SelectedItem;
               
            }
                
        }
        //</snippetCSharpCode>
    }
}
