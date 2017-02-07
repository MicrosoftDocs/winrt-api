using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;

namespace DPO
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>

    public partial class Page1 : UserControl
    {
        public Page1()
        {
            InitializeComponent();
            DoStuff(null,null);
        }
      void DoStuff(object sender, EventArgs e)
      {
        //<SnippetProceduralPropertySet>
        Canvas myC = new Canvas();
        myC.Width = 200.0;
        //</SnippetProceduralPropertySet>
        //<SnippetProceduralPropertyGet>
        double whatWidth;
        whatWidth = myC.Width;
        //</SnippetProceduralPropertyGet>
        double checkWidth;
        //<SnippetPropertyMixedDeclProcCB>
        checkWidth = myC.Width;
        if (checkWidth == 200.0) { anotherButton.Width = 300.0; }
        //</SnippetPropertyMixedDeclProcCB>
        myC.Height = myC.Width;
        root.Children.Add(myC);
        TextBlock tb = new TextBlock();
        tb.Text = "Hello";
        tb.SetValue(Canvas.LeftProperty, 10.0);
        tb.SetValue(Canvas.TopProperty, 200.0);
        myC.Children.Add(tb);
        TextBlock tb2 = new TextBlock();
        tb2.Text = "Hello";
        tb2.SetValue(Canvas.LeftProperty, 40.0);
        tb2.SetValue(Canvas.TopProperty, 300.0);
        myC.Children.Add(tb2);
      }

    }
}