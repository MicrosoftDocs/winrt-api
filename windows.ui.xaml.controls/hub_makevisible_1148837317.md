---
-api-id: M:Windows.UI.Xaml.Controls.Hub.MakeVisible(Windows.UI.Xaml.Controls.SemanticZoomLocation)
-api-type: winrt method
---

<!-- Method syntax
public void MakeVisible(Windows.UI.Xaml.Controls.SemanticZoomLocation item)
-->

# Windows.UI.Xaml.Controls.Hub.MakeVisible

## -description
Forces content in the view to scroll until the item that's specified by [SemanticZoomLocation](semanticzoomlocation.md) is visible. Also focuses the item if it finds the item.

## -parameters
### -param item
The item in the view to scroll to.

## -remarks
You use the [MakeVisible](hub_makevisible.md) method to bring an item into view when the [Hub](hub.md) control is used as a view in a [SemanticZoom](semanticzoom.md) control. To bring an item into view when the [Hub](hub.md) control is not used in a [SemanticZoom](semanticzoom.md), use the [ScrollToSection](hub_scrolltosection.md) method instead.

## -examples

## -see-also
[SemanticZoom](semanticzoom.md), [SemanticZoom.IsZoomedInViewActive](semanticzoom_iszoomedinviewactive.md), [ISemanticZoomInformation.IsActiveView](isemanticzoominformation_isactiveview.md), [ISemanticZoomInformation](isemanticzoominformation.md), [IsActiveView](hub_isactiveview.md), [IsZoomedInView](hub_iszoomedinview.md), [SemanticZoomOwner](hub_semanticzoomowner.md), [CompleteViewChange](hub_completeviewchange.md), [CompleteViewChangeFrom](hub_completeviewchangefrom.md), [CompleteViewChangeTo](hub_completeviewchangeto.md), [InitializeViewChange](hub_initializeviewchange.md), [StartViewChangeFrom](hub_startviewchangefrom.md), [StartViewChangeTo](hub_startviewchangeto.md)