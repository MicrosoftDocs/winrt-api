---
-api-id: M:Windows.UI.Xaml.Controls.ListViewBase.ScrollIntoView(System.Object,Windows.UI.Xaml.Controls.ScrollIntoViewAlignment)
-api-type: winrt method
---

<!-- Method syntax
public void ScrollIntoView(System.Object item, Windows.UI.Xaml.Controls.ScrollIntoViewAlignment alignment)
-->

# Windows.UI.Xaml.Controls.ListViewBase.ScrollIntoView

## -description
Scrolls the list to bring the specified data item into view with the specified alignment.

## -parameters
### -param item
The data item to bring into view.

### -param alignment
An enumeration value that specifies whether the item uses **Default** or **Leading** alignment.

## -remarks
You use the [ScrollIntoView](listviewbase_scrollintoview.md) method to bring an item into view when the [ListViewBase](listviewbase.md) control is not used as a view in a [SemanticZoom](semanticzoom.md) control. To bring an item into view when the [ListViewBase](listviewbase.md) control is used in a [SemanticZoom](semanticzoom.md), use the [MakeVisible](listviewbase_makevisible.md) method instead.

When the contents of the [ItemsSource](itemscontrol_itemssource.md) collection changes, particularly if many items are added to or removed from the collection, you might need to call [UpdateLayout](../windows.ui.xaml/uielement_updatelayout.md) prior to calling [ScrollIntoView](listviewbase_scrollintoview.md) for the specified item to scroll into the viewport.

## -examples

## -see-also
[ScrollIntoView(Object)](listviewbase_scrollintoview_376937206.md), [MakeVisible](listviewbase_makevisible.md)