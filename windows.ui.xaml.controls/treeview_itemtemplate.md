---
-api-id: P:Windows.UI.Xaml.Controls.TreeView.ItemTemplate
-api-type: winrt property
ms.custom: RS5
---

<!-- Property syntax.
public DataTemplate ItemTemplate { get;  set; }
-->

# Windows.UI.Xaml.Controls.TreeView.ItemTemplate

## -description

Gets or sets the [DataTemplate](../windows.ui.xaml/datatemplate.md) used to display each item.

## -xaml-syntax

```xaml
<TreeView>
  <TreeView.ItemTemplate>
    singleDataTemplate
  </TreeView.ItemTemplate>
</TreeView>
```

```xaml
<TreeView ItemTemplate="resourceReferenceToDataTemplate"/>
```

## -xaml-values

<dl><dt>singleDataTemplate</dt><dd>singleDataTemplateA single DataTemplate object element. That DataTemplate would typically have multiple child elements that define the visual appearance of the data representation.</dd>
<dt>resourceReferenceToDataTemplate</dt><dd>resourceReferenceToDataTemplateA resource reference to an existing DataTemplate from a resources collection. The resource reference must specify the desired DataTemplate by key through a {StaticResource} markup extension usage.</dd>
</dl>

## -property-value

The template that specifies the visualization of the data objects. The default is **null**.

## -remarks

## -see-also

## -examples

