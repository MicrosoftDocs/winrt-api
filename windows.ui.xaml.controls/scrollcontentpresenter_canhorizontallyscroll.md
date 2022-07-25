---
-api-id: P:Windows.UI.Xaml.Controls.ScrollContentPresenter.CanHorizontallyScroll
-api-type: winrt property
---

<!-- Property syntax
public bool CanHorizontallyScroll { get;  set; }
-->

# Windows.UI.Xaml.Controls.ScrollContentPresenter.CanHorizontallyScroll

## -description
Gets or sets a value that indicates whether scrolling on the horizontal axis is possible.



## -property-value
**true** if scrolling is possible; otherwise, **false**.

## -remarks
> [!NOTE]
> This property is not intended to be set in XAML. You can set the panel's **Orientation** property in XAML and optionally change the [ScrollViewer.HorizontalScrollBarVisibility](scrollviewer_horizontalscrollbarvisibility.md) or [ScrollViewer.VerticalScrollBarVisibility](scrollviewer_verticalscrollbarvisibility.md) to change how scrolling works. This property can be changed in code. In some cases you will need to use [VisualTreeHelper](../windows.ui.xaml.media/visualtreehelper.md) to access the panel. For example, when used in an [ItemsPanel](itemscontrol_itemspanel.md), there's no property that provides access to a [ScrollContentPresenter](scrollcontentpresenter.md) within the panel.

## -examples

## -see-also
