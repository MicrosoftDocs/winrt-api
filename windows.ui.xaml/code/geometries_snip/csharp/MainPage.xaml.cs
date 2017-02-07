using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Graphics.Display;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;

namespace geometries
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        // View state management for switching among Full, Fill, Snapped, and Portrait states

        private DisplayPropertiesEventHandler _displayHandler;
        private TypedEventHandler<ApplicationLayout, ApplicationLayoutChangedEventArgs> _layoutHandler;

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            if (_displayHandler == null)
            {
                _displayHandler = Page_OrientationChanged;
                _layoutHandler = Page_LayoutChanged;
            }
            DisplayProperties.OrientationChanged += _displayHandler;
            ApplicationLayout.GetForCurrentView().LayoutChanged += _layoutHandler;
            SetCurrentOrientation(this);
        }

        private void Page_Unloaded(object sender, RoutedEventArgs e)
        {
            DisplayProperties.OrientationChanged -= _displayHandler;
            ApplicationLayout.GetForCurrentView().LayoutChanged -= _layoutHandler;
        }

        private void Page_LayoutChanged(object sender, ApplicationLayoutChangedEventArgs e)
        {
           SetCurrentOrientation(this);
        }

        private void Page_OrientationChanged(object sender)
        {
            SetCurrentOrientation(this);
        }

        private void SetCurrentOrientation(Control viewStateAwareControl)
        {
           VisualStateManager.GoToState(viewStateAwareControl, this.GetViewState(), false);
        }

        private String GetViewState()
        {
            var orientation = DisplayProperties.CurrentOrientation;
            if (orientation == DisplayOrientations.Portrait ||
                orientation == DisplayOrientations.PortraitFlipped) return "Portrait";
            var layout = ApplicationLayout.Value;
            if (layout == ApplicationLayoutState.Filled) return "Fill";
            if (layout == ApplicationLayoutState.Snapped) return "Snapped";
            return "Full";
        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    theframe.Navigate("geometries.path_syntax_example");
        //}

        //private void Button_Click_1(object sender, RoutedEventArgs e)
        //{
        //    theframe.Navigate("geometries.PolyBezierSegment");
        //}

        //private void Button_Click_2(object sender, RoutedEventArgs e)
        //{
        //    theframe.Navigate("geometries.GeometryOvw1");
        //}
        private void ChangeSnippet_Click(object sender, RoutedEventArgs e)
        {
            Button srcButton = sender as Button;

            if (null != srcButton)
            {
                
                string pageName = "geometries." + srcButton.Name;
                theframe.Navigate(pageName);
              //  theframe.Navigate(srcButton.Name);
            }
        }
    }
}
