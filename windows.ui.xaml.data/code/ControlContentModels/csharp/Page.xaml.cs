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

namespace ContentModelsEx
{
    public partial class Page : UserControl
    {

        
        
        public Page()
        {
           
            
            InitializeComponent();
            //<snippet71>
            //<snippet81>
            ObservableCollection<Uri> Uris = new ObservableCollection<Uri>();
            Uris.Add(new Uri("http://www.contoso.com"));
            Uris.Add(new Uri("http://www.tailspintoys.com"));
            Uris.Add(new Uri("http://www.cohowinery.com/"));
            //</snippet81>

            UriBox1.ItemsSource = Uris;
            //</snippet71>

            //<snippet82>
            UriBox2.DataContext = Uris;
            //</snippet82>

            //<snippet91>
            UriGrid1.ItemsSource = Uris;
            //</snippet91>

            //<snippet101>
            UriGrid2.DataContext = Uris;
            //</snippet101>
            
        }

       
    }
}
