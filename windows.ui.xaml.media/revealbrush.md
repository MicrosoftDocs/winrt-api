---
-api-id: T:Windows.UI.Xaml.Media.RevealBrush
-api-type: winrt class
---

<!-- Class syntax.
public class RevealBrush : XamlCompositionBrushBase, XamlCompositionBrushBase
-->

# Windows.UI.Xaml.Media.RevealBrush

## -description

> [!Important]
> RevealBrush is available for use in the operating systems specified in the Requirements section. However, we do not recommend its use as it may be altered or unavailable in subsequent versions.

Base class for brushes that use composition effects and lighting to implement the reveal visual design treatment.

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.Media.RevealBrush](/windows/winui/api/microsoft.ui.xaml.media.revealbrush) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -remarks

### XAML attached properties

RevealBrush is the host service class for a [XAML attached property](/windows/uwp/xaml-platform/attached-properties-overview).

In order to support XAML processor access to the attached properties, and also to expose equivalent _get_ and _set_ operations to code, each XAML attached property has a pair of Get and Set accessor methods. Another way to get or set the value in code is to use the dependency property system, calling either [GetValue](../windows.ui.xaml/dependencyobject_getvalue_1188551207.md) or [SetValue](../windows.ui.xaml/dependencyobject_setvalue_52578133.md) and passing the identifier field as the dependency property identifier.

| Attached property | Description |
| - | - |
| [State](revealbrush_state.md) | Gets or sets a value that indicates the pointer state of the element that this brush is used on. |

## -see-also

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Using brushes to paint backgrounds, foregrounds, and outlines](/windows/apps/design/style/brushes).
>
> If you have the **WinUI 2 Gallery** app installed, [open the app to see the controls in action](winui2gallery:).
> + [Get the WinUI 2 Gallery app (Microsoft Store)](https://www.microsoft.com/store/productId/9MSVH128X2ZT)
> + [Get the source code (GitHub)](https://github.com/Microsoft/WinUI-Gallery)
