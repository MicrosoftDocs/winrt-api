---
-api-id: P:Windows.UI.Xaml.Controls.Primitives.OrientedVirtualizingPanel.CanVerticallyScroll
-api-type: winrt property
---

<!-- Property syntax
public bool CanVerticallyScroll { get;  set; }
-->

# Windows.UI.Xaml.Controls.Primitives.OrientedVirtualizingPanel.CanVerticallyScroll

## -description
Gets or sets a value that determines how the [OrientedVirtualizingPanel](orientedvirtualizingpanel.md) measures space for child elements for possible scrolling in the vertical dimension.



## -property-value
**true** to support a potentially infinite vertical layout dimension. **false** to restrict to available size.

## -remarks
> [!NOTE]
> This property is not intended to be set inXAML. You can set the panel's **Orientation** property in XAML and optionally change the [ScrollViewer.HorizontalScrollBarVisibility](../windows.ui.xaml.controls/scrollviewer_horizontalscrollbarvisibility.md) or [ScrollViewer.VerticalScrollBarVisibility](../windows.ui.xaml.controls/scrollviewer_verticalscrollbarvisibility.md) to change how scrolling works. This property can be changed in code. In some cases you will need to use [VisualTreeHelper](../windows.ui.xaml.media/visualtreehelper.md) to access the panel.

## -examples

## -see-also
