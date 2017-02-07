using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Input.Inking;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Ink_Basic_Customization
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        // <SnippetSetInitialStrokeAttributes>
        public MainPage()
        {
            this.InitializeComponent();

            // Set supported inking device types.
            inkCanvas.InkPresenter.InputDeviceTypes = 
                Windows.UI.Core.CoreInputDeviceTypes.Mouse | 
                Windows.UI.Core.CoreInputDeviceTypes.Pen;

            // Set initial ink stroke attributes.
            InkDrawingAttributes drawingAttributes = new InkDrawingAttributes();
            drawingAttributes.Color = Windows.UI.Colors.Black;
            drawingAttributes.IgnorePressure = false;
            drawingAttributes.FitToCurve = true;
            inkCanvas.InkPresenter.UpdateDefaultDrawingAttributes(drawingAttributes);
        }
        // </SnippetSetInitialStrokeAttributes>

        // <SnippetSetColorStrokeAttribute>
        // Update ink stroke color for new strokes.
        private void OnPenColorChanged(object sender, SelectionChangedEventArgs e)
        {
            if (inkCanvas != null)
            {
                InkDrawingAttributes drawingAttributes = 
                    inkCanvas.InkPresenter.CopyDefaultDrawingAttributes();

                string value = ((ComboBoxItem)PenColor.SelectedItem).Content.ToString();

                switch (value)
                {
                    case "Black":
                        drawingAttributes.Color = Windows.UI.Colors.Black;
                        break;
                    case "Red":
                        drawingAttributes.Color = Windows.UI.Colors.Red;
                        break;
                    default:
                        drawingAttributes.Color = Windows.UI.Colors.Black;
                        break;
                };

                inkCanvas.InkPresenter.UpdateDefaultDrawingAttributes(drawingAttributes);
            }
        }
        // </SnippetSetColorStrokeAttribute>
    }
}
