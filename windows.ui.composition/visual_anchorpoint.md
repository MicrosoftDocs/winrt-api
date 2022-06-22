---
-api-id: P:Windows.UI.Composition.Visual.AnchorPoint
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Numerics.Vector2 AnchorPoint { get;  set; }
-->

# Windows.UI.Composition.Visual.AnchorPoint

## -description
The point on the visual to be positioned at the visual's offset. Value is normalized with respect to the size of the visual. Animatable.



## -property-value
The point on the visual to be positioned at the visual's offset. Value is normalized with respect to the size of the visual.

## -remarks

## -examples
<!-- sample show XAML interop -->
```csharp

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Composition;
using Windows.UI.Xaml.Hosting;
using System.Numerics;
 
namespace AnchorPointSample
{
    /// <summary>
    /// Using AnchorPoint to Center a Rectangle
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            this.Loaded += MainPage_Loaded;
        }
 
        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            // Get the backing visual for the "CenteredElement" XAML Element
            Visual root = ElementCompositionPreview.GetElementVisual(CenteredElement);
            Compositor compositor = root.Compositor;
 
            // Create a solid color visual
            SpriteVisual mainVisual = compositor.CreateSpriteVisual();
            mainVisual.Size = new Vector2(200, 200);
            mainVisual.Brush = compositor.CreateColorBrush(Windows.UI.Colors.Blue);
 
            // Set the anchor point to center the rectangle
            mainVisual.AnchorPoint = new Vector2(0.5f, 0.5f);
 
            // Insert the rectangle as a child of the XAML element
            ElementCompositionPreview.SetElementChildVisual(CenteredElement, mainVisual);
        }
    }
}

          
```



## -see-also
