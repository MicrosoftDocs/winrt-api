using System;
using System.Text;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Input;
using System.Collections.Generic;


namespace AquariumLibrary {

  public partial class SilverlightExampleClass : UserControl {
      void UpdateFish(object sender, EventArgs e)
      {
          Fish f = (Fish) aq.AquariumContents[0];
          f.Species = "Guppy";
      }
      public SilverlightExampleClass()
        {
            InitializeComponent();
        }
  }

  public class Fish : Control {
      public static readonly DependencyProperty SpeciesProperty = 
      DependencyProperty.Register(
      "Species",
      typeof(string),
      typeof(Fish),null
      );
      public string Species {
          get {return (string) GetValue(SpeciesProperty);}
          set {SetValue(SpeciesProperty,(string)value);}
      }
  }
  public class FishCollection : List<Fish>
  {
      public FishCollection() { }
  }
  public class Aquarium : Canvas
  {
    private static readonly DependencyProperty AquariumContentsProperty =
      DependencyProperty.Register(
        "AquariumContents",
        typeof(List<Fish>),
        typeof(Aquarium), null
      );
    public List<Fish>
      AquariumContents
      {
      get {
          return (List<Fish>)GetValue(AquariumContentsProperty); 
      }
    }
    public Aquarium() : base()
    {
        SetValue(AquariumContentsProperty, new List<Fish>());
    }
  }
}

        