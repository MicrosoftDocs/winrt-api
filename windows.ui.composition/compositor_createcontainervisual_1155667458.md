---
-api-id: M:Windows.UI.Composition.Compositor.CreateContainerVisual
-api-type: winrt method
---

<!-- Method syntax
public Windows.UI.Composition.ContainerVisual CreateContainerVisual()
-->

# Windows.UI.Composition.Compositor.CreateContainerVisual

## -description
Creates an instance of [ContainerVisual](containervisual.md).

## -returns
Returns the created [ContainerVisual](containervisual.md) object.

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

ref class MyClass
{
    Compositor ^ _compositor;
    CompositionTarget ^ _target;
    ContainerVisual ^ _root;
 
    void Initialize()
    {
        //
        // Set up Composition.
        //
 
        _compositor = ref new Compositor();
        _target = _compositor->CreateTargetForCurrentView();
        _root = _compositor->CreateContainerVisual();
        _target->Root = _root;
 
        
        //
        // Create a simple scene.
        //
        
        auto child = _compositor->CreateSpriteVisual();
        child->Brush = _compositor.CreateColorBrush(ColorHelper::FromArgb(0xFF, 0x00, 0xCC, 0x00));
        child->Offset = float2(50.0f, 50.0f);
        child->Size = float2(200, 200);
        
        _root->Children->InsertAtTop(child);
    }
}
          
```



## -see-also
