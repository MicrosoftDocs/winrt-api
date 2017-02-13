---
-api-id: M:Windows.UI.Xaml.Controls.ListViewBase.InitializeViewChange
-api-type: winrt method
---

<!-- Method syntax
public void InitializeViewChange()
-->

# Windows.UI.Xaml.Controls.ListViewBase.InitializeViewChange

## -description
Initializes the changes to related aspects of presentation (such as scrolling UI or state) when the overall view for a [SemanticZoom](isemanticzoominformation.md) is about to change.

## -remarks
Controls derived from [ListViewBase](listviewbase.md) typically have an associated [ScrollViewer](scrollviewer.md) as part of their template. The [ListViewBase](listviewbase.md) implementation of [InitializeViewChange](isemanticzoominformation_initializeviewchange.md) stores [ScrollBarVisibility](scrollbarvisibility.md) for current scroll bars, so that values can be perpetuated across the views when the views change.

## -examples

## -see-also
[ISemanticZoomInformation](isemanticzoominformation.md), [IsActiveView](listviewbase_isactiveview.md), [IsZoomedInView](listviewbase_iszoomedinview.md), [SemanticZoomOwner](listviewbase_semanticzoomowner.md), [CompleteViewChange](listviewbase_completeviewchange.md), [CompleteViewChangeFrom](listviewbase_completeviewchangefrom.md), [CompleteViewChangeTo](listviewbase_completeviewchangeto.md), [MakeVisible](listviewbase_makevisible.md), [StartViewChangeFrom](listviewbase_startviewchangefrom.md), [StartViewChangeTo](listviewbase_startviewchangeto.md)