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

PointerUpThemeAnimation overrides the current values of [Projection](../windows.ui.xaml/uielement_projection.md) and [RenderTransform](../windows.ui.xaml/uielement_rendertransform.md) and sets them to their default values.

> **Windows 8.1 and prior**
> [Projection](../windows.ui.xaml/uielement_projection.md) and [RenderTransform](../windows.ui.xaml/uielement_rendertransform.md) are not affected by [PointerDownThemeAnimation](pointerdownthemeanimation.md).

## -examples
See the code example in [PointerDownThemeAnimation](pointerdownthemeanimation.md).

## -see-also
[Timeline](timeline.md), [Animating pointer clicks](/previous-versions/windows/apps/jj649432(v=win.10)), [Guidelines and checklist for pointer click animations](/windows/uwp/style/motion-pointer)
