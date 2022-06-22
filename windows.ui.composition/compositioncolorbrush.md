---
-api-id: T:Windows.UI.Composition.CompositionColorBrush
-api-type: winrt class
---

<!-- Class syntax.
public class CompositionColorBrush : Windows.UI.Composition.CompositionBrush, Windows.UI.Composition.ICompositionColorBrush
-->

# Windows.UI.Composition.CompositionColorBrush

## -description
Paints a [SpriteVisual](spritevisual.md) with a solid color.



## -remarks

## -examples


```csharp

SpriteVisual visual= compositor.CreateSpriteVisual();
visual.Brush = compositor.CreateColorBrush  (Colors.White);
          
```



```csharp

using Windows.UI.Composition;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Hosting;
using System.Numerics;
 
…
public sealed partial class MainPage : Page
    {
        Compositor _compositor;
        ContainerVisual _root;
        SpriteVisual _visual;
 
        public MainPage()
        {
            this.InitializeComponent();
            this.Loaded += MainPage_Loaded;
        }
 
        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            // Get compositor and create a solid color visual
            _root = ElementCompositionPreview.GetContainerVisual(MainGrid) as ContainerVisual;
            _compositor = _root.Compositor;
 
            // Create a solid color visual
            _visual = _compositor.CreateSpriteVisual();
            _visual.Brush = _compositor.CreateColorBrush( Windows.UI.Colors.Blue );
            _visual.Size = new Vector2(250, 250);
 
            // Set hard border mode to disable anti-aliasing
            _visual.BorderMode = CompositionBorderMode.Hard;
 
            // Set backface-visibility to hidden in event of 3D rotation
            _visual.BackfaceVisibility = CompositionBackfaceVisibility.Hidden;
 
            // Set composite mode to DestinationInvert to do color subtraction blending
            _visual.CompositeMode = CompositionCompositeMode.DestinationInvert;
 
            _root.Children.InsertAtTop(_visual);
 
	     // Create a child visual of the solid color visual
            SpriteVisual childVisual = _compositor.CreateSpriteVisual();
            childvisual.Brush = _compositor.CreateColorBrush( Windows.UI.Colors.Orange );
            childVisual.Size = new Vector2(250, 20);
            _visual.Children.InsertAtTop(childVisual);
 
        }
	 
	 private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Show or hide visual and subtree
            if (_visual.IsVisible)
            {
                _visual.IsVisible = false;
            }
            else
            {
                _visual.IsVisible = true;
            }
        }
 
    }
          
          
```

Animating the Color property using a key frame animation.

```csharp

void ColorAnimation(SpriteVisual targetVisual)
{
  //
  // Create a key frame animation for the targetBrush.Color property
  //
  var animation = _compositor.CreateColorKeyFrameAnimation(); 
  animation.InsertKeyFrame(0.0f, Color.FromArgb(255, 0, 255, 0));
  animation.InsertKeyFrame(1.0f, Colors.Purple);
  targetVisual.Brush.StartAnimation("Color", animation);
}
          
          
```

Animating the Color property using an [ExpressionAnimation](expressionanimation.md).

```csharp

void ColorExpression(SpriteVisual targetVisual, float screenWidth )
{
  var expression = _compositor.CreateExpressionAnimation("ColorLerp(ColorFrom, ColorTo, target.Offset.X / Width");
  expression.SetReferenceParameter("target", targetVisual);
  expression.SetColorParameter("ColorFrom", Colors.Green);
  expression.SetColorParameter("ColorTo", Colors.Purple);
  expression.SetFloatParameter("Width", screenWidth);
  targetVisual.Brush.StartAnimation("Color", expression);
}
          
          
```



## -see-also
[Composition Brushes Overview](/windows/uwp/graphics/composition-brushes), [Composition Effects Overview](/windows/uwp/composition/composition-effects), [CompositionBrush](compositionbrush.md), [IClosable](../windows.foundation/iclosable.md)
