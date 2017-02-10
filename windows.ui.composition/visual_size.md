---
-api-id: P:Windows.UI.Composition.Visual.Size
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Numerics.Vector2 Size { get;  set; }
-->

# Windows.UI.Composition.Visual.Size

## -description
The width and height of the visual. Animatable.

## -property-value
The width and height of the visual.

## -remarks
This property is animatable and can be associated with a [KeyFrameAnimation](keyframeanimation.md) or [ExpressionAnimation](expressionanimation.md) using [CompositionObject::StartAnimation](compositionobject_startanimation.md).

## -examples
```csharp

// Create a simple scene.
Compositor compositor = new Compositor();
SpriteVisual child = compositor.CreateSpriteVisual();
child.Offset = new Vector3(50.0f, 50.0f, 0.0f);
child.Size = new Vector2(200, 200);
child.Brush = compositor.CreateColorBrush(Color.FromArgb(0xFF, 0x00, 0xCC, 0x00));
          
```

```cpp

// Create a simple scene.          
_compositor = ref new Compositor();
auto child = _compositor->CreateSpriteVisual();
child->Offset = Vector3(50.0f, 50.0f, 0.0f);
child->Size = Vector2(200, 200);
child->Brush = _compositor->CreateColorBrush(ColorHelper::FromArgb(0xFF, 0x00, 0xCC, 0x00));
          
```



## -see-also
