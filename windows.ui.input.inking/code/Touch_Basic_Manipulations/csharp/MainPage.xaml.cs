using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Touch_Basic_Manipulations
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        // <SnippetGlobals>
        // Global translation transform used for changing the position of 
        // the Rectangle based on input data from the touch contact.
        private TranslateTransform dragTranslation;
        // </SnippetGlobals>

        // <SnippetInitialize>
        public MainPage()
        {
            this.InitializeComponent();

            // Listener for the ManipulationDelta event.
            touchRectangle.ManipulationDelta += touchRectangle_ManipulationDelta;
            // New translation transform populated in 
            // the ManipulationDelta handler.
            dragTranslation = new TranslateTransform();
            // Apply the translation to the Rectangle.
            touchRectangle.RenderTransform = this.dragTranslation;
        }
        // </SnippetInitialize>

        // <SnippettestRectangle_ManipulationDelta>
        // Handler for the ManipulationDelta event.
        // ManipulationDelta data is loaded into the
        // translation transform and applied to the Rectangle.
        void touchRectangle_ManipulationDelta(object sender,
            ManipulationDeltaRoutedEventArgs e)
        {
            // Move the rectangle.
            dragTranslation.X += e.Delta.Translation.X;
            dragTranslation.Y += e.Delta.Translation.Y;
        }
        // </SnippettestRectangle_ManipulationDelta>
    }
}
