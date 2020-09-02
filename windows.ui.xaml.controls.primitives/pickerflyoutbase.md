---
-api-id: T:Windows.UI.Xaml.Controls.Primitives.PickerFlyoutBase
-api-type: winrt class
---

<!-- Class syntax.
public class PickerFlyoutBase : Windows.UI.Xaml.Controls.Primitives.FlyoutBase, Windows.UI.Xaml.Controls.Primitives.IPickerFlyoutBase, Windows.UI.Xaml.Controls.Primitives.IPickerFlyoutBaseOverrides
-->

# Windows.UI.Xaml.Controls.Primitives.PickerFlyoutBase

## -description
Represents a base class for picker controls.

## -remarks

### XAML attached properties

PickerFlyoutBase is the host service class for a [XAML attached property](/windows/uwp/xaml-platform/attached-properties-overview).

In order to support XAML processor access to the attached properties, and also to expose equivalent _get_ and _set_ operations to code, each XAML attached property has a pair of Get and Set accessor methods. Another way to get or set the value in code is to use the dependency property system, calling either [GetValue](../windows.ui.xaml/dependencyobject_getvalue_1188551207.md) or [SetValue](../windows.ui.xaml/dependencyobject_setvalue_52578133.md) and passing the identifier field as the dependency property identifier.

| Attached property | Description |
| - | - |
| Title | Gets or sets  the title for a picker flyout when it appears.<ul><li>Type: string</li><li>Identifier field: <a href="https://docs.microsoft.com/uwp/api/windows.ui.xaml.controls.primitives.pickerflyoutbase.titleproperty">TitleProperty</a></li><li>Accessor methods: <a href="https://docs.microsoft.com/uwp/api/windows.ui.xaml.controls.primitives.pickerflyoutbase.gettitle">GetTitle</a>, <a href="https://docs.microsoft.com/uwp/api/windows.ui.xaml.controls.primitives.pickerflyoutbase.settitle">SetTitle</a></li></ul>|

## -examples

## -see-also
[FlyoutBase](flyoutbase.md)