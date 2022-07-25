---
-api-id: P:Windows.UI.Xaml.Controls.ScrollViewer.TopHeader
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.UIElement TopHeader { get;  set; }
-->

# Windows.UI.Xaml.Controls.ScrollViewer.TopHeader

## -description
Gets or sets the content of the top header.



## -xaml-syntax
```xaml
<ScrollViewer>
  <ScrollViewer.TopHeader>headerObject</ScrollViewer.TopHeader>
</ScrollViewer>

```


## -xaml-values
<dl><dt>headerObject</dt><dd>headerObjectAn single object element that serves as header content. Use discretion when using objects as header content; not all objects are suitable for use within the limited presentation surface that appears for headers.</dd>
</dl>
## -property-value
The content of the top header.

## -remarks
The [LeftHeader](scrollviewer_leftheader.md), TopHeader, and [TopLeftHeader](scrollviewer_topleftheader.md) properties can be set only when [ScrollViewer](scrollviewer.md) content's [HorizontalAlignment](../windows.ui.xaml/frameworkelement_horizontalalignment.md) is **Left** and [VerticalAlignment](../windows.ui.xaml/frameworkelement_verticalalignment.md) is **Top**.

The top header scrolls horizontally, but not vertically.

## -examples

## -see-also
