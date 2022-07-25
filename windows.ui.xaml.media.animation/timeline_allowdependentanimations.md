---
-api-id: P:Windows.UI.Xaml.Media.Animation.Timeline.AllowDependentAnimations
-api-type: winrt property
---

<!-- Property syntax
public bool AllowDependentAnimations { get;  set; }
-->

# Windows.UI.Xaml.Media.Animation.Timeline.AllowDependentAnimations

## -description
Gets or sets a value that determines whether dependent animations should be permitted to run, throughout the app.



## -property-value
**true** if animations can run in the app for dependent animation cases. Otherwise, **false**. The default is **true**.

## -remarks
If you want to set this property value to **false**, do so as part of page or app initialization, for example in an app activation handler. The property is global for the app, and acts like an app setting, even if you set it in a page scope.

A **false** value for AllowDependentAnimations overrides all cases where **EnableDependentAnimation** is set to **true** on individual animations. When AllowDependentAnimations is **false**, no dependent animation will run in your app, they all act as if **EnableDependentAnimation** is **false** on all animations. For animations declared in the app's page XAML, it might seem that it wouldn't be necessary to disable the dependent animations because you have control over them already by not explicitly setting the **EnableDependentAnimation** properties. But the scenario for AllowDependentAnimations is more for app authors who are consuming controls with control templates that might contain dependent animations within them. Such animations might exist in the visual states, if the control authors didn't follow visual state best practices. (The control templates for default Windows Runtime controls don't have dependent animations, so you won't need to use AllowDependentAnimations if you're only using default XAML controls and default templates.)



> [!NOTE]
> If you're using [UIElement.CacheMode](../windows.ui.xaml/uielement_cachemode.md), you may have unintentionally created dependent animations, even when using default XAML controls; for more info, see [UIElement.CacheMode](../windows.ui.xaml/uielement_cachemode.md) and [Optimize animations and media](/windows/uwp/debug-test-perf/optimize-animations-and-media).

## -examples

## -see-also
[Storyboarded animations](/windows/uwp/graphics/storyboarded-animations), [Optimize animations and media](/windows/uwp/debug-test-perf/optimize-animations-and-media)
