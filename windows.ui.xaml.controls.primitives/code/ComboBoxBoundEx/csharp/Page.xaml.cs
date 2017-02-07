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
using System.Collections.ObjectModel;

namespace ComboBoxBoundEx
{
    public partial class Page : UserControl
    {
        //<snippet2>
        public Page()
        {
            InitializeComponent();
            ObservableCollection<FontFamily> fonts = new ObservableCollection<FontFamily>();
            fonts.Add(new FontFamily("Arial"));
            fonts.Add(new FontFamily("Courier New"));
            fonts.Add(new FontFamily("Times New Roman"));
            
            FontsCombo.DataContext = fonts;
       }
       //</snippet2>
    }
}
