---
-api-id: T:Windows.UI.Xaml.Media.XamlLight
-api-type: winrt class
---

<!-- Class syntax.
public class XamlLight : DependencyObject, DependencyObject
-->

# Windows.UI.Xaml.Media.XamlLight

## -description
Provides a base class used to create XAML lights that use a [CompositionLight](./../windows.ui.composition/compositionlight.md) to apply lighting effects to XAML elements and brushes.



## -remarks

You can use XamlLight to create custom lights.

For example, it can be used to create a light that applies a composition [SpotLight](/uwp/api/Windows.UI.Composition.SpotLight) to target elements to light them.

XamlLight provides methods for targeting UIElements or XAML Brushes, applying lights to trees of UIElements, and helping manage the lifetime of CompositionLight resources based on whether they're currently in use.

Custom XamlLights can be used in conjunction with custom Brushes derived from [XamlCompositionBrushBase](xamlcompositionbrushbase.md) which use a [SceneLightingEffect](/uwp/api/Windows.UI.Composition.Effects.SceneLightingEffect) to controls the reflective properties of elements when being lit by a XamlLight.

### Targeting objects

If you target a [Brush](/uwp/api/Windows.UI.Xaml.Media.Brush) with a XamlLight then the portions of any UIElements using that Brush will be lit by the light.

If you target a [UIElement](/uwp/api/Windows.UI.Xaml.UIElement) with a XamlLight then the entire UIElement and its child UIElements will all be lit by the light.

Targets can be added and removed by calling methods on a XamlLight instance. XamlLights can also define [custom attached properties](/windows/uwp/xaml-platform/custom-attached-properties) to add and remove targets from markup.

### Managing resources

When creating a XamlLight, it's usually a good practice to delay creating a [CompositionLight](/uwp/api/windows.ui.composition.compositionlight) and any related resources until the light is being used. The [OnConnected](xamllight_onconnected_832156073.md) method is called when a XamlLight is first used to target an element or brush on screen, so you can override [OnConnected](xamllight_onconnected_832156073.md) to safely create resources only when they're needed.

It's also a good practice to dispose of composition resources when they're no longer in use. The [OnDisconnected](xamllight_ondisconnected_213178242.md) method is called when a XamlLight instance is no longer in use anywhere on the screen, so you can override [OnDisconnected](xamllight_ondisconnected_213178242.md) to safely dispose of resources. If the XamlLight is later used again after being disconnected then [OnConnected](xamllight_onconnected_832156073.md) will be called again.

> [!WARNING]
> On Windows 10 Creators Update (SDK 15063), CompositionLight can't be accessed after Dispose is called, so setting it to **null** after calling Dispose causes an error. To work around this issue, you can save the CompositionLight to a temporary variable and call Dispose on that after you set CompositionLight to null. `var temp = CompostionLight; CompositionLight = null; temp.Dispose();`
> This issue is fixed in later versions of the SDK. See [Version adaptive apps](/windows/uwp/debug-test-perf/version-adaptive-apps) for info about how to target different SDK versions.

## -examples

See the code example in [Lighting](/windows/uwp/composition/lighting).

## -see-also

[UIElement.Lights](./../windows.ui.xaml/uielement_lights.md), [Using the composition Visual Layer with XAML](/windows/uwp/composition/using-the-visual-layer-with-xaml),[Composition lighting](/windows/uwp/composition/lighting), [CompositionLight](/uwp/api/windows.ui.composition.compositionlight)
