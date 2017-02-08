---
-api-id: P:Windows.Gaming.UI.GameBar.Visible
-api-type: winrt property
---

<!-- Property syntax
public bool Visible { get; }
-->

# Windows.Gaming.UI.GameBar.Visible

## -description
Indicates whether Game bar is currently visible.

Use the  property to determine the visibility state of Game bar. Games can choose to pause gameplay or present an idle state when Game bar is visible and being drawn over the game. While paused or idle, a best practice is to continue rendering the current frame or scene, so that the recording is smooth and seamless if the player begins recording or is already recording. Multiplayer games might choose to continue gameplay rather than to pause.

To be notified of changes to , handle the [VisibilityChanged](gamebar_visibilitychanged.md) event.

## -property-value
**true** if Game bar is currently visible; **false** otherwise.

## -remarks

## -examples

## -see-also
[VisibilityChanged](gamebar_visibilitychanged.md), [IsInputRedirected](gamebar_isinputredirected.md), [IsInputRedirectedChanged](gamebar_isinputredirectedchanged.md)