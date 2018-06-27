---
-api-id: T:Windows.UI.Xaml.Media.Animation.PointerUpThemeAnimation
-api-type: winrt class
---

<!-- Class syntax.
public class PointerUpThemeAnimation : Windows.UI.Xaml.Media.Animation.Timeline, Windows.UI.Xaml.Media.Animation.IPointerUpThemeAnimation
-->

# Windows.UI.Xaml.Media.Animation.PointerUpThemeAnimation

## -description
Represents a preconfigured animation that runs after a pointer down is detected on an item or element and the tap action is released.

## -xaml-syntax
```xaml
<PointerUpThemeAnimation .../>
```

## -remarks
Setting the [Duration](timeline_duration.md) property has no effect on this object as the duration is preconfigured.

[PointerUpThemeAnimation](pointerupthemeanimation.md) overrides the current values of [Projection](../windows.ui.xaml/uielement_projection.md) and [RenderTransform](../windows.ui.xaml/uielement_rendertransform.md) and sets them to their default values.

> **Windows 8.1 and prior**
> [Projection](../windows.ui.xaml/uielement_projection.md) and [RenderTransform](../windows.ui.xaml/uielement_rendertransform.md) are not affected by [PointerDownThemeAnimation](pointerdownthemeanimation.md).

## -examples
See the code example in [PointerDownThemeAnimation](pointerdownthemeanimation.md).

## -see-also
[Timeline](timeline.md), [Animating pointer clicks](http://msdn.microsoft.com/library/b100b9c1-dfd7-43ac-99ed-a742a029c39b), [Guidelines and checklist for pointer click animations](http://msdn.microsoft.com/library/eeb10a2c-629a-4705-8468-4d019d74ddff)