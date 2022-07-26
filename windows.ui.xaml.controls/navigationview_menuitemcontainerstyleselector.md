---
-api-id: P:Windows.UI.Xaml.Controls.NavigationView.MenuItemContainerStyleSelector
-api-type: winrt property
---

<!-- Property syntax.
public StyleSelector MenuItemContainerStyleSelector { get;  set; }
-->

# Windows.UI.Xaml.Controls.NavigationView.MenuItemContainerStyleSelector

## -description

Gets or sets a reference to a custom [StyleSelector](styleselector.md) logic class. The [StyleSelector](styleselector.md) returns different [Style](../windows.ui.xaml/style.md) values to use for the item container based on characteristics of the object being displayed.

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.Controls.NavigationView.MenuItemContainerStyleSelector](/windows/winui/api/microsoft.ui.xaml.controls.navigationview.menuitemcontainerstyleselector) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax

```xaml
<NavigationView MenuItemContainerStyleSelector="styleSelectorReference" />
```

## -xaml-values

<dl><dt>styleSelectorReference</dt><dd>styleSelectorReferenceA reference to an existing StyleSelector. Typically this is a keyed resource, which you reference through a {StaticResource} markup extension usage.</dd>
</dl>

## -property-value

A custom [StyleSelector](styleselector.md) logic class.

## -remarks

## -see-also

## -examples

