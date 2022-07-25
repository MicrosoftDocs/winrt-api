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

FlyoutBase is the parent class for [Flyout](../windows.ui.xaml.controls/flyout.md) and [MenuFlyout](../windows.ui.xaml.controls/menuflyout.md).

### XAML attached properties

FlyoutBase is the host service class for a [XAML attached property](/windows/uwp/xaml-platform/attached-properties-overview).

In order to support XAML processor access to the attached properties, and also to expose equivalent _get_ and _set_ operations to code, each XAML attached property has a pair of Get and Set accessor methods. Another way to get or set the value in code is to use the dependency property system, calling either [GetValue](../windows.ui.xaml/dependencyobject_getvalue_1188551207.md) or [SetValue](../windows.ui.xaml/dependencyobject_setvalue_52578133.md) and passing the identifier field as the dependency property identifier.

| Attached property | Description |
| - | - |
| [AttachedFlyout](flyoutbase_attachedflyout.md) | Gets or sets the flyout attached to a [FrameworkElement](../windows.ui.xaml/frameworkelement.md).|

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | AllowFocusOnInteraction |
| 1607 | 14393 | AllowFocusWhenDisabled |
| 1607 | 14393 | Closing |
| 1607 | 14393 | ElementSoundMode |
| 1607 | 14393 | LightDismissOverlayMode |
| 1607 | 14393 | Target |
| 1703 | 15063 | OverlayInputPassThroughElement |
| 1709 | 16299 | OnProcessKeyboardAccelerators |
| 1709 | 16299 | TryInvokeKeyboardAccelerator |
| 1809 | 17763 | AreOpenCloseAnimationsEnabled |
| 1809 | 17763 | InputDevicePrefersPrimaryCommands |
| 1809 | 17763 | IsOpen |
| 1809 | 17763 | ShowAt(DependencyObject,FlyoutShowOptions) |
| 1809 | 17763 | ShowMode |
| 1903 | 18362 | IsConstrainedToRootBounds |
| 1903 | 18362 | ShouldConstrainToRootBounds |
| 1903 | 18362 | XamlRoot |

## -examples

## -see-also

[DependencyObject](../windows.ui.xaml/dependencyobject.md), [Flyout](../windows.ui.xaml.controls/flyout.md), [MenuFlyout](../windows.ui.xaml.controls/menuflyout.md), [Button.Flyout](../windows.ui.xaml.controls/button_flyout.md), [Version adaptive code sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/VersionAdaptiveCode)
