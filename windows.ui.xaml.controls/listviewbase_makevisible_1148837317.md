---
-api-id: M:Windows.UI.Xaml.Controls.ListViewBase.MakeVisible(Windows.UI.Xaml.Controls.SemanticZoomLocation)
-api-type: winrt method
---

<!-- Method syntax
public void MakeVisible(Windows.UI.Xaml.Controls.SemanticZoomLocation item)
-->

# Windows.UI.Xaml.Controls.ListViewBase.MakeVisible

## -description
Forces content in the view to scroll until the item that's specified by [SemanticZoomLocation](semanticzoomlocation.md) is visible. Also focuses the item if it finds the item.

## -parameters
### -param item
The item in the view to scroll to.

## -remarks
You use the [MakeVisible](listviewbase_makevisible.md) method to bring an item into view when the [ListViewBase](listviewbase.md) control is used as a view in a [SemanticZoom](semanticzoom.md) control. To bring an item into view when the [ListViewBase](listviewbase.md) control is not used in a [SemanticZoom](semanticzoom.md), use the [ScrollIntoView](listviewbase_scrollintoview.md) method instead.

## -examples

## -see-also
[ScrollIntoView](listviewbase_scrollintoview.md), [SemanticZoom](semanticzoom.md), [ISemanticZoomInformation](isemanticzoominformation.md), [IsActiveView](listviewbase_isactiveview.md), [IsZoomedInView](listviewbase_iszoomedinview.md), [SemanticZoomOwner](listviewbase_semanticzoomowner.md), [CompleteViewChange](listviewbase_completeviewchange.md), [CompleteViewChangeFrom](listviewbase_completeviewchangefrom.md), [CompleteViewChangeTo](listviewbase_completeviewchangeto.md), [InitializeViewChange](listviewbase_initializeviewchange.md), [StartViewChangeFrom](listviewbase_startviewchangefrom.md), [StartViewChangeTo](listviewbase_startviewchangeto.md)