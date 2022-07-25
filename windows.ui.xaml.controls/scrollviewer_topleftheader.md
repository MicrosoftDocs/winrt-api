---
-api-id: P:Windows.UI.Xaml.Controls.ScrollViewer.TopLeftHeader
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.UIElement TopLeftHeader { get;  set; }
-->

# Windows.UI.Xaml.Controls.ScrollViewer.TopLeftHeader

## -description
Gets or sets the content of the top, left header.



## -xaml-syntax
```xaml
<ScrollViewer>
  <ScrollViewer.TopLeftHeader>headerObject</ScrollViewer.TopLeftHeader>
</ScrollViewer>

```


## -xaml-values
<dl><dt>headerObject</dt><dd>headerObjectAn single object element that serves as header content. Use discretion when using objects as header content; not all objects are suitable for use within the limited presentation surface that appears for headers.</dd>
</dl>
## -property-value
The content of the top, left header.

## -remarks
The [LeftHeader](scrollviewer_leftheader.md), [TopHeader](scrollviewer_topheader.md), and TopLeftHeader properties can be set only when [ScrollViewer](scrollviewer.md) content's [HorizontalAlignment](../windows.ui.xaml/frameworkelement_horizontalalignment.md) is **Left** and [VerticalAlignment](../windows.ui.xaml/frameworkelement_verticalalignment.md) is **Top**.

The top left header doesn't scroll in any direction.

## -examples

## -see-also
