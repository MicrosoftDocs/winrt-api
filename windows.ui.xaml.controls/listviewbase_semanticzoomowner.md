---
-api-id: P:Windows.UI.Xaml.Controls.ListViewBase.SemanticZoomOwner
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Controls.SemanticZoom SemanticZoomOwner { get;  set; }
-->

# Windows.UI.Xaml.Controls.ListViewBase.SemanticZoomOwner

## -description
Gets or sets the [SemanticZoom](semanticzoom.md) instance that hosts the [ListViewBase](listviewbase.md).

## -property-value
The [SemanticZoom](semanticzoom.md) instance that hosts this view, or **null** if the view is not hosted in a [SemanticZoom](semanticzoom.md) control. 
<!--Note about only implementers of interface should set? Particularly here, the true relationship is declared in the *View properties of the SemanticZoom.-->

## -remarks
You don't set this property in Extensible Application Markup Language (XAML) or in your app code. The property is set implicitly when the view is set as either the [ZoomedInView](semanticzoom_zoomedinview.md) or [ZoomedOutView](semanticzoom_zoomedoutview.md) of a [SemanticZoom](semanticzoom.md) control.

## -examples

## -see-also
[SemanticZoom](semanticzoom.md), [ISemanticZoomInformation](isemanticzoominformation.md), [IsActiveView](listviewbase_isactiveview.md), [IsZoomedInView](listviewbase_iszoomedinview.md), [CompleteViewChange](listviewbase_completeviewchange.md), [CompleteViewChangeFrom](listviewbase_completeviewchangefrom.md), [CompleteViewChangeTo](listviewbase_completeviewchangeto.md), [InitializeViewChange](listviewbase_initializeviewchange.md), [MakeVisible](listviewbase_makevisible.md), [StartViewChangeFrom](listviewbase_startviewchangefrom.md), [StartViewChangeTo](listviewbase_startviewchangeto.md)