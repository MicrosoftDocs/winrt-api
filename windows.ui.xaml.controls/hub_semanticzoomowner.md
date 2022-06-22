---
-api-id: P:Windows.UI.Xaml.Controls.Hub.SemanticZoomOwner
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Controls.SemanticZoom SemanticZoomOwner { get;  set; }
-->

# Windows.UI.Xaml.Controls.Hub.SemanticZoomOwner

## -description
Gets or sets the [SemanticZoom](semanticzoom.md) instance that hosts the [Hub](hub.md).



## -property-value
The [SemanticZoom](semanticzoom.md) instance that hosts this [Hub](hub.md), or **null** if the [Hub](hub.md) is not hosted in a [SemanticZoom](semanticzoom.md) control.

## -remarks
You don't set this property in XAML or in your app code. The property is set implicitly when the view is set as either the [ZoomedInView](semanticzoom_zoomedinview.md) or [ZoomedOutView](semanticzoom_zoomedoutview.md) of a [SemanticZoom](semanticzoom.md) control.

## -examples

## -see-also
[SemanticZoom](semanticzoom.md), [SemanticZoom.IsZoomedInViewActive](semanticzoom_iszoomedinviewactive.md), [ISemanticZoomInformation.IsActiveView](isemanticzoominformation_isactiveview.md), [ISemanticZoomInformation](isemanticzoominformation.md), [IsActiveView](hub_isactiveview.md), [IsZoomedInView](hub_iszoomedinview.md), [CompleteViewChange](hub_completeviewchange_1917507883.md), [CompleteViewChangeFrom](hub_completeviewchangefrom_788425485.md), [CompleteViewChangeTo](hub_completeviewchangeto_41306206.md), [InitializeViewChange](hub_initializeviewchange_1165335344.md), [MakeVisible](hub_makevisible_1148837317.md), [StartViewChangeFrom](hub_startviewchangefrom_1386295791.md), [StartViewChangeTo](hub_startviewchangeto_1504058226.md)
