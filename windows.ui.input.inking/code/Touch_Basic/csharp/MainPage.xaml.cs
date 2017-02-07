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
using Windows.UI.Xaml.Shapes;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Touch_Basic
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        // <SnippetInitialize>
        public MainPage()
        {
            this.InitializeComponent();

            // Pointer event listeners.
            touchRectangle.PointerPressed += touchRectangle_PointerPressed;
            touchRectangle.PointerReleased += touchRectangle_PointerReleased;
            touchRectangle.PointerExited += touchRectangle_PointerExited;
        }
        // </SnippetInitialize>

        // <SnippetEventHandlers>
        // <SnippettouchRectangle_PointerExited>
        // Handler for pointer exited event.
        private void touchRectangle_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            Rectangle rect = sender as Rectangle;

            // Pointer moved outside Rectangle hit test area.
            // Reset the dimensions of the Rectangle.
            if (null != rect)
            {
                rect.Width = 200;
                rect.Height = 100;
            }
        }
        // </SnippettouchRectangle_PointerExited>
        // <SnippettouchRectangle_PointerReleased>
        // Handler for pointer released event.
        private void touchRectangle_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            Rectangle rect = sender as Rectangle;

            // Reset the dimensions of the Rectangle.
            if (null != rect)
            {
                rect.Width = 200;
                rect.Height = 100;
            }
        }
        // </SnippettouchRectangle_PointerReleased>

        // <SnippettouchRectangle_PointerPressed>
        // Handler for pointer pressed event.
        private void touchRectangle_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            Rectangle rect = sender as Rectangle;

            // Change the dimensions of the Rectangle.
            if (null != rect)
            {
                rect.Width = 250;
                rect.Height = 150;
            }
        }
        // </SnippettouchRectangle_PointerPressed>
        // </SnippetEventHandlers>
    }
}
