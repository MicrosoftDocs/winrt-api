---
-api-id: P:Windows.UI.Xaml.Controls.ListViewBase.IsActiveView
-api-type: winrt property
---

<!-- Property syntax
public bool IsActiveView { get;  set; }
-->

# Windows.UI.Xaml.Controls.ListViewBase.IsActiveView

## -description
Gets or sets a value that indicates whether the [ListViewBase](listviewbase.md) instance is the active view in its owning [SemanticZoom](semanticzoom.md).

## -property-value
**true** if the [ListViewBase](listviewbase.md) is the active view; otherwise, **false**.

## -remarks
You typically don't set this property in XAML or in app code. The property is set implicitly when the view is set as either the [ZoomedInView](semanticzoom_zoomedinview.md) or [ZoomedOutView](semanticzoom_zoomedoutview.md) of a [SemanticZoom](semanticzoom.md) control.

## -examples

## -see-also
[SemanticZoom](semanticzoom.md), [SemanticZoom.IsZoomedInViewActive](semanticzoom_iszoomedinviewactive.md), [ISemanticZoomInformation.IsActiveView](isemanticzoominformation_isactiveview.md), [ISemanticZoomInformation](isemanticzoominformation.md), [IsZoomedInView](listviewbase_iszoomedinview.md), [SemanticZoomOwner](listviewbase_semanticzoomowner.md), [CompleteViewChange](listviewbase_completeviewchange.md), [CompleteViewChangeFrom](listviewbase_completeviewchangefrom.md), [CompleteViewChangeTo](listviewbase_completeviewchangeto.md), [InitializeViewChange](listviewbase_initializeviewchange.md), [MakeVisible](listviewbase_makevisible.md), [StartViewChangeFrom](listviewbase_startviewchangefrom.md), [StartViewChangeTo](listviewbase_startviewchangeto.md)