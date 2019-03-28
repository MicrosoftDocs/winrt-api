---
-api-id: T:Windows.UI.Xaml.Controls.Primitives.FlyoutBase
-api-type: winrt class
---

<!-- Class syntax.
public class FlyoutBase : Windows.UI.Xaml.DependencyObject, Windows.UI.Xaml.Controls.Primitives.IFlyoutBase, Windows.UI.Xaml.Controls.Primitives.IFlyoutBase2, Windows.UI.Xaml.Controls.Primitives.IFlyoutBase3, Windows.UI.Xaml.Controls.Primitives.IFlyoutBaseOverrides
-->

# Windows.UI.Xaml.Controls.Primitives.FlyoutBase

## -description

Represents the base class for flyout controls, such as [Flyout](../windows.ui.xaml.controls/flyout.md) and [MenuFlyout](../windows.ui.xaml.controls/menuflyout.md).

## -remarks

### **FlyoutBase** derived classes

[FlyoutBase](flyoutbase.md) is the parent class for [Flyout](../windows.ui.xaml.controls/flyout.md) and [MenuFlyout](../windows.ui.xaml.controls/menuflyout.md).

### XAML attached properties

FlyoutBase is the host service class for a [XAML attached property](https://docs.microsoft.com/windows/uwp/xaml-platform/attached-properties-overview).

In order to support XAML processor access to the attached properties, and also to expose equivalent _get_ and _set_ operations to code, each XAML attached property has a pair of Get and Set accessor methods. Another way to get or set the value in code is to use the dependency property system, calling either [GetValue](../windows.ui.xaml/dependencyobject_getvalue_1188551207.md) or [SetValue](../windows.ui.xaml/dependencyobject_setvalue_52578133.md) and passing the identifier field as the dependency property identifier.

| Attached property | Description |
| - | - |
| AttachedFlyout | Gets or sets the flyout attached to a [FrameworkElement](../windows.ui.xaml/frameworkelement.md).<ul><li>Type: FlyoutBase</li><li>Identifier field: <a href="https://docs.microsoft.com/uwp/api/windows.ui.xaml.controls.primitives.flyoutbase.attachedflyoutproperty">AttachedFlyoutProperty</a></li><li>Accessor methods: <a href="https://docs.microsoft.com/uwp/api/windows.ui.xaml.controls.primitives.flyoutbase.getattachedflyout">GetAttachedFlyout</a>, <a href="https://docs.microsoft.com/uwp/api/windows.ui.xaml.controls.primitives.flyoutbase.setattachedflyout">SetAttachedFlyout</a></li></ul>To attach a flyout to a Button, use [Button.Flyout](../windows.ui.xaml.controls/button_flyout.md) instead.|

## -examples

## -see-also

- [DependencyObject](../windows.ui.xaml/dependencyobject.md)
- [Flyout](../windows.ui.xaml.controls/flyout.md)
- [MenuFlyout](../windows.ui.xaml.controls/menuflyout.md)
- [Button.Flyout](../windows.ui.xaml.controls/button_flyout.md)
- [XAML UI basics sample (Windows 10)](https://github.com/Microsoft/Xaml-Controls-Gallery) - see [FlyoutPage.xaml](https://github.com/Microsoft/Windows-universal-samples/blob/master/Samples/XamlUIBasics/cs/AppUIBasics/ControlPages/FlyoutPage.xaml)
- [XAML Flyout and MenuFlyout sample (Windows 8)](https://go.microsoft.com/fwlink/p/?LinkID=310074)
- [Version adaptive code sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/VersionAdaptiveCode)