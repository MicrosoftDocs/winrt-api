---
-api-id: P:Windows.UI.Xaml.Controls.ScrollViewer.LeftHeader
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.UIElement LeftHeader { get;  set; }
-->

# Windows.UI.Xaml.Controls.ScrollViewer.LeftHeader

## -description
Gets or sets the content of the left header.



## -xaml-syntax
```xaml
<ScrollViewer>
  <ScrollViewer.LeftHeader>headerObject</ScrollViewer.LeftHeader>
</ScrollViewer>

```


## -xaml-values
<dl><dt>headerObject</dt><dd>headerObjectAn single object element that serves as header content. Use discretion when using objects as header content; not all objects are suitable for use within the limited presentation surface that appears for headers.</dd>
</dl>
## -property-value
The content of the left header.

## -remarks
The LeftHeader, [TopHeader](scrollviewer_topheader.md), and [TopLeftHeader](scrollviewer_topleftheader.md) properties can be set only when [ScrollViewer](scrollviewer.md) content's [HorizontalAlignment](../windows.ui.xaml/frameworkelement_horizontalalignment.md) is **Left** and [VerticalAlignment](../windows.ui.xaml/frameworkelement_verticalalignment.md) is **Top**.

The left header scrolls vertically, but not horizontally.

## -examples

## -see-also
[TopHeader](scrollviewer_topheader.md), [TopLeftHeader](scrollviewer_topleftheader.md)
