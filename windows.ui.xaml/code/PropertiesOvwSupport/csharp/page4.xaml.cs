using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Input;
using System.Collections.Generic;

namespace DPO
{
  public partial class SilverlightExampleClass : UserControl
  {
      void MakeANewThing(object sender, RoutedEventArgs e)
      {
//<SnippetAPCode>
          Canvas myC = new Canvas();
      CheckBox myCheckBox = new CheckBox();
      myCheckBox.Content = "Hello";
      myC.Children.Add(myCheckBox);
      Canvas.SetTop(myCheckBox, 75);
//</SnippetAPCode>
      }
//<SnippetDPFormBasic>
      public static readonly DependencyProperty IsSpinningProperty = 
          DependencyProperty.Register(
          "IsSpinning", typeof(Boolean),
          typeof(SilverlightExampleClass), null
          );
      public bool IsSpinning
      {
          get { return (bool)GetValue(IsSpinningProperty); }
          set { SetValue(IsSpinningProperty, value); }
      }
//</SnippetDPFormBasic>
      void DoAqStuff()
      {
//<SnippetCollectionProblemTestCode>
          Aquarium myAq1 = new Aquarium();
          Aquarium myAq2 = new Aquarium();
          Fish f1 = new Fish();
          Fish f2 = new Fish();
          myAq1.AquariumContents.Add(f1);
          myAq2.AquariumContents.Add(f2);
//</SnippetCollectionProblemTestCode>
      }
      void BAQ(object sender, EventArgs e)
      {
          DoAqStuff();
      }
  }
//<SnippetCollectionProblemDefinition>
    public class Fish : Control {
        public Fish()
        {
            
        }
    }
    public class Aquarium : Control
    {
        private static readonly DependencyProperty AquariumContentsProperty = 
            DependencyProperty.Register(
              "AquariumContents",
              typeof(List<FrameworkElement>),
              typeof(Aquarium), null
            );

        public List<FrameworkElement> AquariumContents
        {
            get { return (List<FrameworkElement>)GetValue(AquariumContentsProperty); }
        }
//</SnippetCollectionProblemDefinition>

//<SnippetCollectionProblemCtor>
        public Aquarium() : base()
        {
            SetValue(AquariumContentsProperty, new List<FrameworkElement>()); 
        }
//</SnippetCollectionProblemCtor>

//<SnippetCollectionProblemEndB>
    }
//</SnippetCollectionProblemEndB>
}
