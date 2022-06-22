---
-api-id: T:Windows.UI.Composition.SpriteVisual
-api-type: winrt class
---

<!-- Class syntax.
public class SpriteVisual : Windows.UI.Composition.ContainerVisual, Windows.UI.Composition.ISpriteVisual, Windows.UI.Composition.ISpriteVisual2
-->

# Windows.UI.Composition.SpriteVisual

## -description
Hosts 2D boxed content of type [CompositionBrush](compositionbrush.md). Any part of the visual not covered by pixels from the brush are rendered as transparent pixels. CompositionBrush can be either a [CompositionBackdropBrush](compositionbackdropbrush.md), [CompositionColorBrush](compositioncolorbrush.md), a [CompositionSurfaceBrush](compositionsurfacebrush.md) or a [CompositionEffectBrush](compositioneffectbrush.md).



## -remarks

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | Shadow |

## -examples


```csharp

SpriteVisual visual = compositor.CreateSpriteVisual();
visual.Brush = compositor.CreateColorBrush  (Colors.White);
          
```



```csharp

SpriteVisual visual = compositor.CreateSpriteVisual();
var surface = graphicsDevice.CreateDrawingSurface(new Size(300, 50), 
                                                  Windows.Graphics.DirectX.DirectXPixelFormat.B8G8R8A8UIntNormalized, 
                                                  CompositionAlphaMode.Ignore); 
visual.Brush = compsositor.CreateSurfaceBrush (surface);
          
```

Adding a Shadow

```csharp

//Create surface brush and load in an image
CompositionSurfaceBrush surfaceBrush = compositor.CreateSurfaceBrush();
surfaceBrush.Surface = await imageLoader.LoadImageFromUriAsync(new Uri("ms-appx:///Assets/cat.jpg"));

//Create sprite visual
SpriteVisual visual = compositor.CreateSpriteVisual();
visual.Brush = surfaceBrush;
visual.Size = new Vector2(270, 200);

//Create drop shadow
DropShadow shadow = compositor.CreateDropShadow();
shadow.BlurRadius = 5;
shadow.Offset = new Vector3(15, 15, -10);
shadow.Color = Colors.DarkGray;

//Associate shadow to visual
visual.Shadow = shadow;        
        
```



## -see-also
[Composition Visual Tree Overview](/windows/uwp/composition/composition-visual-tree), [ContainerVisual](containervisual.md), [IClosable](../windows.foundation/iclosable.md)
