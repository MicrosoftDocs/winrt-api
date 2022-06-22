---
-api-id: M:Windows.UI.Xaml.Controls.ListViewBase.CompleteViewChange
-api-type: winrt method
---

<!-- Method syntax
public void CompleteViewChange()
-->

# Windows.UI.Xaml.Controls.ListViewBase.CompleteViewChange

## -description
Changes related aspects of presentation when the overall view for a [SemanticZoom](isemanticzoominformation.md) changes.



## -remarks
Controls derived from [ListViewBase](listviewbase.md) typically have an associated [ScrollViewer](scrollviewer.md) as part of their template. The [ListViewBase](listviewbase.md) implementation of [CompleteViewChange](isemanticzoominformation_completeviewchange_1917507883.md) perpetuates [ScrollBarVisibility](scrollbarvisibility.md) for any scroll bars across the views when the views change.

## -examples

## -see-also
[ISemanticZoomInformation](isemanticzoominformation.md), [IsActiveView](listviewbase_isactiveview.md), [IsZoomedInView](listviewbase_iszoomedinview.md), [SemanticZoomOwner](listviewbase_semanticzoomowner.md), [CompleteViewChangeFrom](listviewbase_completeviewchangefrom_788425485.md), [CompleteViewChangeTo](listviewbase_completeviewchangeto_41306206.md), [InitializeViewChange](listviewbase_initializeviewchange_1165335344.md), [MakeVisible](listviewbase_makevisible_1148837317.md), [StartViewChangeFrom](listviewbase_startviewchangefrom_1386295791.md), [StartViewChangeTo](listviewbase_startviewchangeto_1504058226.md)
