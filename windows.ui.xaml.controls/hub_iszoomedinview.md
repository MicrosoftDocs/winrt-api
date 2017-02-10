---
-api-id: P:Windows.UI.Xaml.Controls.Hub.IsZoomedInView
-api-type: winrt property
---

<!-- Property syntax
public bool IsZoomedInView { get;  set; }
-->

# Windows.UI.Xaml.Controls.Hub.IsZoomedInView

## -description
Gets or sets a value that indicates whether the [Hub](hub.md) instance is the zoomed-in view in its owning [SemanticZoom](semanticzoom.md).

## -property-value
**true** if the [Hub](hub.md) is the zoomed-in view; otherwise, **false**.

## -remarks
You typically don't set this property in XAML or in app code. The property is set implicitly when the view is set as either the [ZoomedInView](semanticzoom_zoomedinview.md) or [ZoomedOutView](semanticzoom_zoomedoutview.md) of a [SemanticZoom](semanticzoom.md) control.

## -examples

## -see-also
[SemanticZoom](semanticzoom.md), [SemanticZoom.IsZoomedInViewActive](semanticzoom_iszoomedinviewactive.md), [ISemanticZoomInformation.IsActiveView](isemanticzoominformation_isactiveview.md), [ISemanticZoomInformation](isemanticzoominformation.md), [IsActiveView](hub_isactiveview.md), [SemanticZoomOwner](hub_semanticzoomowner.md), [CompleteViewChange](hub_completeviewchange.md), [CompleteViewChangeFrom](hub_completeviewchangefrom.md), [CompleteViewChangeTo](hub_completeviewchangeto.md), [InitializeViewChange](hub_initializeviewchange.md), [MakeVisible](hub_makevisible.md), [StartViewChangeFrom](hub_startviewchangefrom.md), [StartViewChangeTo](hub_startviewchangeto.md)