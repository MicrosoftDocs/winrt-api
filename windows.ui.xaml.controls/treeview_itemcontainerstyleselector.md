---
-api-id: P:Windows.UI.Xaml.Controls.TreeView.ItemContainerStyleSelector
-api-type: winrt property
ms.custom: RS5
---

<!-- Property syntax.
public StyleSelector ItemContainerStyleSelector { get;  set; }
-->

# Windows.UI.Xaml.Controls.TreeView.ItemContainerStyleSelector

## -description

Gets or sets a reference to a custom [StyleSelector](styleselector.md) logic class. The [StyleSelector](styleselector.md) returns different [Style](../windows.ui.xaml/style.md) values to use for the item container based on characteristics of the object being displayed.

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.Controls.TreeView.ItemContainerStyleSelector](/windows/winui/api/microsoft.ui.xaml.controls.treeview.itemcontainerstyleselector) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax

```xaml
<TreeView ItemContainerStyleSelector="styleSelectorReference" />
```

## -xaml-values

<dl><dt>styleSelectorReference</dt><dd>styleSelectorReferenceA reference to an existing StyleSelector. Typically this is a keyed resource, which you reference through a {StaticResource} markup extension usage.</dd>
</dl>

## -property-value

A custom [StyleSelector](styleselector.md) logic class.

## -remarks

## -see-also

## -examples

