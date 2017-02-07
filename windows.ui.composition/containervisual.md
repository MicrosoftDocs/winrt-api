---
-api-id: T:Windows.UI.Composition.ContainerVisual
-api-type: winrt class
---

<!-- Class syntax.
public class ContainerVisual : Windows.UI.Composition.Visual, Windows.UI.Composition.IContainerVisual
-->

# Windows.UI.Composition.ContainerVisual

## -description
A node in the visual tree that can have children.

## -remarks

## -examples


```csharp

//
// Set up Windows.UI.Composition Compositor, root ContainerVisual, and associate with
// the CoreWindow.
//

_compositor = new Compositor();

_root = _compositor.CreateContainerVisual();
_view.CompositionRootVisual = _root;


//
// Create a simple scene.
//

var child = _compositor.CreateSpriteVisual();
child.Brush = _compositor.CreateColorBrush(Color.FromArgb(0xFF, 0x00, 0xCC, 0x00));
child.Offset = new Vector2(50.0f, 50.0f);
child.Size = new Vector2(200, 200);

_root.Children.InsertAtTop(child);
          
```

```cpp

_compositor = ref new Compositor();
    
_root = _compositor->CreateContainerVisual();
_view->CompositionRootVisual = _root;

//
// Create a simple scene.
//

auto child = _compositor->CreateSpriteVisual();
child->Brush = _compositor->CreateColorBrush(ColorHelper::FromArgb(0xFF, 0x00, 0xCC, 0x00));
child->Offset = float2(50.0f, 50.0f);
child->Size = float2(200, 200);

_root->Children->InsertAtTop(child);
          
          
```



## -see-also
[Visual](visual.md), [IClosable](../windows.foundation/iclosable.md), [Composition visual without framework sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=620483)