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

```cppwinrt
// App.cpp
struct SampleApp : implements<SampleApp, IFrameworkViewSource, IFrameworkView>
{
    ...
    void SetWindow(CoreWindow const& /* window */)
    {
        // Set up Composition.
        m_compositor = Compositor{};
        m_target = m_compositor.CreateTargetForCurrentView();
        m_root = m_compositor.CreateContainerVisual();
        m_target.Root(m_root);

        // Create a simple scene.
        auto child{ m_compositor.CreateSpriteVisual() };
        child.Brush(m_compositor.CreateColorBrush(ColorHelper::FromArgb(0xFF, 0x00, 0xCC, 0x00)));
        child.Offset({ 50.f, 50.f, 0.f });
        child.Size({ 200.f, 200.f });

        m_root.Children().InsertAtTop(child);
    }

private:
    Compositor m_compositor{ nullptr };
    CompositionTarget m_target{ nullptr };
    ContainerVisual m_root{nullptr};
};
```

```cppcx
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

[Visual](visual.md), [IClosable](../windows.foundation/iclosable.md), [Composition visual without framework sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/CompositionVisual)
