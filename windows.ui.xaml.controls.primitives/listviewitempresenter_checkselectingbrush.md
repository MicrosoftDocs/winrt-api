---
-api-id: P:Windows.UI.Xaml.Controls.Primitives.ListViewItemPresenter.CheckSelectingBrush
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Media.Brush CheckSelectingBrush { get;  set; }
-->

# Windows.UI.Xaml.Controls.Primitives.ListViewItemPresenter.CheckSelectingBrush

## -description
Gets or sets the brush used to render the check mark on an item while it's being selected using a swipe interaction. This property is ignored for a Windows 10 app.



## -xaml-syntax
```xaml
<ListViewItemPresenter CheckSelectingBrush="themeResourceReference"/>

```


## -xaml-values
<dl><dt>themeResourceReference</dt><dd>themeResourceReferenceA ThemeResource markup extension reference to an existing keyed resource that defines a Brush-type resource in a XAML resource dictionary. For example, to reference a resource with the key ListViewItemCheckSelectingThemeBrush, the string is {ThemeResource ListViewItemCheckSelectingThemeBrush}.</dd>
</dl>
## -property-value
The brush used to render the check mark on an item while it's being selected using a swipe interaction.

## -remarks
### Notes on XAML syntax

The XAML usage shown is for referencing a theme resource. This is how [Brush](../windows.ui.xaml.media/brush.md) values for a presenter are typically defined, so that the values can be changed when the theme changes, and potentially so that [Brush](../windows.ui.xaml.media/brush.md) values can be shared by different templates. It's possible but less common to use a XAML syntax that refers to a [Brush](../windows.ui.xaml.media/brush.md) value directly. For examples of direct XAML usages for a [Brush](../windows.ui.xaml.media/brush.md), see the XAML section in the [Brush](../windows.ui.xaml.media/brush.md) class topic.

If you're setting this property as an attribute on a custom [ListViewItemPresenter](listviewitempresenter.md) , substitute the prefixed name of your custom class in the XAML usage shown.

## -examples

## -see-also
[XAML theme resources](/windows/apps/design/style/xaml-theme-resources)
