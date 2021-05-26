---
-api-id: P:Windows.UI.Xaml.Controls.VirtualizingStackPanel.IsVirtualizing
-api-type: winrt attachedproperty
---

# Windows.UI.Xaml.Controls.VirtualizingStackPanel.IsVirtualizing

<!--
see GetIsVirtualizing
-->

## -description

Gets a value that indicates whether a child item of the panel is virtualized.

## -remarks

> [!NOTE]
> `VirtualizingStackPanel.IsVirtualizing` is an atypical attached property because it does not have a `Set` accessor, and thus is not really a XAML attached property with a markup usage. It uses the attached property model as a property store, but does not support an Extensible Application Markup Language (XAML) usage. Instead, the property serves as a sentinel that any `VirtualizingStackPanel` child element can check to determine whether that child is currently being represented as virtualized. To find out if an item is being virtualized, call [GetIsVirtualizing](virtualizingstackpanel_getisvirtualizing_1946654319.md), passing the item as the input parameter.

<ul><li>Type: Boolean</li><li>Identifier field: <a href="/uwp/api/windows.ui.xaml.controls.virtualizingstackpanel.isvirtualizingproperty">IsVirtualizingProperty</a></li><li>Accessor methods: <a href="/uwp/api/windows.ui.xaml.controls.virtualizingstackpanel.getisvirtualizing">GetIsVirtualizing</a></li></ul>

## -see-also

[XAML attached properties](/windows/uwp/xaml-platform/attached-properties-overview)

## -examples
