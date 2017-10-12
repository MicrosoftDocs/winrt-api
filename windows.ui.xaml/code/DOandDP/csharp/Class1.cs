using System;
using System.Text;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Interop;

namespace DOandDP
{
//<SnippetDOMain>
    public abstract class AquariumServices : DependencyObject
    {
        public enum Buoyancy {Floats,Sinks,Drifts}

        public static readonly DependencyProperty BuoyancyProperty = DependencyProperty.RegisterAttached(
          "Buoyancy",
          typeof(Buoyancy),
          typeof(AquariumServices),
          new PropertyMetadata(Buoyancy.Floats)
        );
        public static void SetBuoyancy(DependencyObject element, Buoyancy value)
        {
            element.SetValue(BuoyancyProperty, value);
        }
        public static Buoyancy GetBuoyancy(DependencyObject element)
        {
            return (Buoyancy)element.GetValue(BuoyancyProperty);
        }
    }
    //</SnippetDOMain>

    //<SnippetDOSimpleDP>
    public class Fish : Control
    {
        public static readonly DependencyProperty SpeciesProperty =
        DependencyProperty.Register(
        "Species",
        typeof(String),
        typeof(Fish), null
        );
        public string Species
        {
            get { return (string)GetValue(SpeciesProperty); }
            set { SetValue(SpeciesProperty, (string)value); }
        }
    }
    //</SnippetDOSimpleDP>
    public static class DependencyPropertyUtilities
    {
        //<SnippetDOCheckClear>
        public static bool ClearSetProperty(DependencyObject targetObject, DependencyProperty targetDP)
        {
            if (targetObject == null || targetDP == null)
            {
                throw new ArgumentNullException();
            }
            object localValue = targetObject.ReadLocalValue(targetDP);
            if (localValue == DependencyProperty.UnsetValue)
            {
                return false;
            }
            else
            {
                targetObject.ClearValue(targetDP);
                return true;
            }
        }
        //</SnippetDOCheckClear>
        //<SnippetDPGetMetadata>
        public static object GetDefaultValueForFrameworkDP(DependencyProperty dpIdentifier)
        {
            PropertyMetadata metadataInfo = dpIdentifier.GetMetadata(typeof(FrameworkElement));
            return metadataInfo.DefaultValue;
        }
        //</SnippetDPGetMetadata>
    }
}
