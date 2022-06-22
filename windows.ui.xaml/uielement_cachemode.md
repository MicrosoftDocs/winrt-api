---
-api-id: P:Windows.UI.Xaml.UIElement.CacheMode
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Media.CacheMode CacheMode { get;  set; }
-->

# Windows.UI.Xaml.UIElement.CacheMode

## -description
Gets or sets a value that indicates that rendered content should be cached as a composited bitmap when possible.



## -xaml-syntax
```xaml
<uiElement CacheMode="BitmapCache" />
```

## -property-value
A value that indicates that rendered content should be cached as a composited bitmap when possible. If you specify a value of [CacheMode](../windows.ui.xaml.media/cachemode.md), rendering operations from [RenderTransform](uielement_rendertransform.md) and [Opacity](uielement_opacity.md) execute on the graphics processing unit (GPU), if available. The default is **null**, which does not enable a cached composition mode.

## -remarks
Set this value to enable the caching behavior that offloads [RenderTransform](uielement_rendertransform.md) and [Opacity](uielement_opacity.md) bitmaps to the graphics processing unit (GPU). Otherwise, leave it as **null**.

For XAML, the string literal "BitmapCache" is the only enabled value you can use to set CacheMode as an attribute. 

> [!NOTE]
> [BitmapCache](../windows.ui.xaml.media/bitmapcache.md) is the only existing practical derived classes in the Windows Runtime  API that enables this behavior (the [CacheMode](../windows.ui.xaml.media/cachemode.md) type is an intermediate type that exists only for infrastructure and legacy reasons).

If setting CacheMode in code, set it to a new value of [BitmapCache](../windows.ui.xaml.media/bitmapcache.md), like this:

```xaml
<Canvas x:Name="canvas1"/>
```

```csharp
canvas1.CacheMode = new BitmapCache();
```

```cppwinrt
#include <winrt/Windows.UI.Xaml.Media.h>
...
canvas1().CacheMode(Windows::UI::Xaml::Media::BitmapCache{});
```

```cppcx
canvas1->CacheMode = ref new BitmapCache();
```

Do not generally apply CacheMode values to elements without testing and profiling first. Caching to the graphics processing unit (GPU) is intended only for a minority of possible rendering situations for an app, and it's expected that you will profile various combinations of when and where in your UI to apply a CacheMode setting. Overuse of CacheMode can hurt performance rather than help it. It’s best to profile the app surface area to determine which targeted areas are most expensive to render, and to experiment with caching only certain elements based on those results. For more info on how to profile for rendering, see [IsOverdrawHeatMapEnabled](debugsettings_isoverdrawheatmapenabled.md) and "Cache static content" section of the [Optimize your XAML markup](/windows/uwp/debug-test-perf/optimize-xaml-loading) topic.

Avoid using [CacheMode](../windows.ui.xaml.media/cachemode.md) and storyboarded animations together. Caching content where [Opacity](uielement_opacity.md) or [RenderTransform](uielement_rendertransform.md) are animated causes the animations to become dependent animations, even if the animation is zero-duration. To even see those animations run you'd have to set **EnableDependentAnimation** to **true**, and a dependent animation usually invalidates all the performance gains you might get from caching the composition. [Opacity](uielement_opacity.md) often is animated by visual states in control templates, so this is a consideration even if you aren't declaring any of your own storyboarded animations in XAML pages.

## -examples

## -see-also
[IsOverdrawHeatMapEnabled](debugsettings_isoverdrawheatmapenabled.md), [Optimize your XAML markup](/windows/uwp/debug-test-perf/optimize-xaml-loading), [Storyboarded animations](/windows/uwp/graphics/storyboarded-animations)
