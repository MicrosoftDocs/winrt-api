---
-api-id: P:Windows.UI.Xaml.Controls.ItemsControl.GroupStyle
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IObservableVector<Windows.UI.Xaml.Controls.GroupStyle> GroupStyle { get; }
-->

# Windows.UI.Xaml.Controls.ItemsControl.GroupStyle

## -description
Gets a collection of [GroupStyle](groupstyle.md) objects that define the appearance of each level of groups.



## -xaml-syntax
```xaml
<itemsControl>
  <itemsControl.GroupStyle>
    oneOrMoreGroupStyleObjects
  </itemsControl.GroupStyle>
</itemsControl>

```


## -xaml-values
<dl><dt>oneOrMoreGroupStyleObjects</dt><dd>oneOrMoreGroupStyleObjectsOne or more GroupStyle object elements defined in XAML. Each GroupStyle might contain definitions for HeaderTemplate and Panel that apply for a particular level.</dd>
</dl>
## -property-value
A collection of [GroupStyle](groupstyle.md) objects that define the appearance of each level of groups.

## -remarks
> [!NOTE]
> [GroupStyle.ContainerStyle](groupstyle_containerstyle.md) and [GroupStyle.ContainerStyleSelector](groupstyle_containerstyleselector.md) are deprecated in Windows 8.1, and are ignored in ItemsControl.GroupStyle.

## -examples

## -see-also
