---
-api-id: T:Windows.UI.Xaml.Media.RevealBrush
-api-type: winrt class
---

<!-- Class syntax.
public class RevealBrush : XamlCompositionBrushBase, XamlCompositionBrushBase
-->

# Windows.UI.Xaml.Media.RevealBrush

## -description

Base class for brushes that use composition effects and lighting to implement the reveal visual design treatment.

## -remarks

### XAML attached properties

RevealBrush is the host service class for a [XAML attached property](https://docs.microsoft.com/windows/uwp/xaml-platform/attached-properties-overview).

In order to support XAML processor access to the attached properties, and also to expose equivalent _get_ and _set_ operations to code, each XAML attached property has a pair of Get and Set accessor methods. Another way to get or set the value in code is to use the dependency property system, calling either [GetValue](../windows.ui.xaml/dependencyobject_getvalue_1188551207.md) or [SetValue](../windows.ui.xaml/dependencyobject_setvalue_52578133.md) and passing the identifier field as the dependency property identifier.

| Attached property | Description |
| - | - |
| State | Gets or sets a value that indicates the pointer state of the element that this brush is used on.<ul><li>Type: [RevealBrushState](revealbrushstate.md)</li><li>Identifier field: <a href="https://docs.microsoft.com/uwp/api/windows.ui.xaml.media.revealbrush.stateproperty">StateProperty</a></li><li>Accessor methods: <a href="https://docs.microsoft.com/uwp/api/windows.ui.xaml.media.revealbrush.getstate">GetState</a>, <a href="https://docs.microsoft.com/uwp/api/windows.ui.xaml.media.revealbrush.setstate">SetState</a></li></ul> |

## -see-also
[Reveal highlight overview](https://docs.microsoft.com/windows/uwp/design/style/reveal)

## -examples

