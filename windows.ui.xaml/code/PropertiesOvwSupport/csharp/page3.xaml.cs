using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Input;


namespace DPO
{
  public partial class Page3 : UserControl
  {
    public Page3()
    {
        InitializeComponent();
    }
    void DoStuff() {
//<SnippetDPBasicPropSet>
      myCanvas.Background = new SolidColorBrush(Colors.Green);
//</SnippetDPBasicPropSet>
    }
//<SnippetResourceProceduralGet>
    void SetBGByResource(object sender, RoutedEventArgs e)
    {
      Button b = sender as Button;
      b.Background = (Brush)this.Resources["RainbowBrush"];
    }
//</SnippetResourceProceduralGet>
  }
}
