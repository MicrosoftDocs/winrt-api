---
-api-id: M:Windows.UI.Composition.Compositor.CreateSurfaceBrush
-api-type: winrt method
---

<!-- Method syntax
public Windows.UI.Composition.CompositionSurfaceBrush CreateSurfaceBrush()
-->

# Windows.UI.Composition.Compositor.CreateSurfaceBrush

## -description
Creates an instance of [CompositionSurfaceBrush](compositionsurfacebrush.md).



## -returns
Returns the created [CompositionSurfaceBrush](compositionsurfacebrush.md) object.

## -remarks

## -examples
```csharp

SpriteVisual visual= compositor.CreateSpriteVisual();

var surface = graphicsDevice.CreateDrawingSurface(new Size(300, 50), 
                       Windows.Graphics.DirectX.DirectXPixelFormat.B8G8R8A8UIntNormalized, 
                       CompositionAlphaMode.Ignore); 

var surfaceBrush = _compositor.CreateSurfaceBrush(surface);
surfaceBrush.HorizontalAlignmentRatio = 0.0;
surfaceBrush.VerticalAlignmentRatio= 0.0;
surfaceBrush.Stretch = CompositionStretch.None;

visual.Brush = surfaceBrush;
          
```



## -see-also
[CreateSurfaceBrush(ICompositionSurface)](compositor_createsurfacebrush_1433438799.md)
