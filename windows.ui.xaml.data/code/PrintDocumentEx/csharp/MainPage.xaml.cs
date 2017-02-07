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
//<snippet11>
using Windows.UI.Xaml.Printing;
using Windows.Graphics.Printing;
//</snippet11>

namespace SLPrint
{
    //<snippet10>
    public partial class MainPage : UserControl
    {
        PrintDocument pd; 
        
        public MainPage()
        {
            InitializeComponent();
            pd = new PrintDocument();
            pd.PrintPage += new EventHandler<PrintPageEventArgs>(pd_PrintPage);
            
        }

        private void PrintButton_Click(object sender, RoutedEventArgs e)
        {
          pd.Print("My Map");
        }

        void pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.PageVisual = mapImage;
        }
    }
    //</snippet10>
}
