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

namespace WebBrowserScriptEx
{
    //<snippetCodeBehind>
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void WB1_ScriptNotify(object sender, NotifyEventArgs e)
        {
            Button1.Content = e.Value;
            Button1.IsEnabled = false;
     
        }
       
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            object results = WB1.InvokeScript("LoadSearch", new string[] { "Silverlight" });
        }
    }
    //</snippetCodeBehind>
}
