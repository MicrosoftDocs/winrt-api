---
-api-id: P:Windows.UI.Xaml.Controls.TreeView.ItemTemplateSelector
-api-type: winrt property
ms.custom: RS5
---

<!-- Property syntax.
public DataTemplateSelector ItemTemplateSelector { get;  set; }
-->

# Windows.UI.Xaml.Controls.TreeView.ItemTemplateSelector

## -description

Gets or sets a reference to a custom [DataTemplateSelector](datatemplateselector.md) logic class. The DataTemplateSelector referenced by this property returns a template to apply to items.

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.Controls.TreeView.ItemTemplateSelector](/windows/winui/api/microsoft.ui.xaml.controls.treeview.itemtemplateselector) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax

```xaml
<TreeView ItemTemplateSelector="dataTemplateSelectorReference" />
```

## -xaml-values
<dl><dt>dataTemplateSelectorReference</dt><dd>dataTemplateSelectorReferenceA reference to an existing DataTemplateSelector. Typically this is a keyed resource, which you reference through {StaticResource} markup extension.</dd>
</dl>

## -property-value

A reference to a custom [DataTemplateSelector](datatemplateselector.md) logic class.

## -remarks

## -see-also

## -examples

