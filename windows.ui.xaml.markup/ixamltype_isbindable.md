---
-api-id: P:Windows.UI.Xaml.Markup.IXamlType.IsBindable
-api-type: winrt property
---

<!-- Property syntax
public bool IsBindable { get; }
-->

# Windows.UI.Xaml.Markup.IXamlType.IsBindable

## -description
Gets a value that declares whether the type is bindable.

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.Markup.IXamlType.IsBindable](/windows/winui/api/microsoft.ui.xaml.markup.ixamltype.isbindable) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -property-value
**true** if the type is bindable, **false** if the type is not bindable.

## -remarks
The value of this property corresponds to application of the [BindableAttribute](../windows.ui.xaml.data/bindableattribute.md) to the underlying class for native C++ classes. The value is always **true** for all common language runtime (CLR) classes.

## -examples

## -see-also
[XAML overview](/windows/uwp/xaml-platform/xaml-overview)
