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

## -remarks

### XAML attached properties

RevealBrush is the host service class for a [XAML attached property](/windows/uwp/xaml-platform/attached-properties-overview).

In order to support XAML processor access to the attached properties, and also to expose equivalent _get_ and _set_ operations to code, each XAML attached property has a pair of Get and Set accessor methods. Another way to get or set the value in code is to use the dependency property system, calling either [GetValue](../windows.ui.xaml/dependencyobject_getvalue_1188551207.md) or [SetValue](../windows.ui.xaml/dependencyobject_setvalue_52578133.md) and passing the identifier field as the dependency property identifier.

| Attached property | Description |
| - | - |
| [State](revealbrush_state.md) | Gets or sets a value that indicates the pointer state of the element that this brush is used on. |

## -see-also

## -examples

See the **XAML Controls Gallery** sample app for examples of WinUI features and controls.

If you have the **XAML Controls Gallery** app installed, [open the app to see the controls in action](xamlcontrolsgallery:).

If you don't have the XAML Controls Gallery app installed, get the WinUI 2.x version from the [Microsoft Store](https://www.microsoft.com/p/xaml-controls-gallery/9msvh128x2zt).

You can also view, clone, and build the XAML Controls Gallery source code from [GitHub](https://github.com/Microsoft/Xaml-Controls-Gallery) (switch to the [WinUI 3 Preview branch](https://github.com/microsoft/Xaml-Controls-Gallery/tree/winui3preview) for WinUI 3 Preview controls and features).
