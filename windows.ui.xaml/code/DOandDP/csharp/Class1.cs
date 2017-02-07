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
        public enum Bouyancy {Floats,Sinks,Drifts}

        public static readonly DependencyProperty BouyancyProperty = DependencyProperty.RegisterAttached(
          "Bouyancy",
          typeof(Bouyancy),
          typeof(AquariumServices),
          new PropertyMetadata(Bouyancy.Floats)
        );
        public static void SetBouyancy(DependencyObject element, Bouyancy value)
        {
            element.SetValue(BouyancyProperty, value);
        }
        public static Bouyancy GetBouyancy(DependencyObject element)
        {
            return (Bouyancy)element.GetValue(BouyancyProperty);
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
