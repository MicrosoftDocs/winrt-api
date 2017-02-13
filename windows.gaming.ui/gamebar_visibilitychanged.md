---
-api-id: E:Windows.Gaming.UI.GameBar.VisibilityChanged
-api-type: winrt event
---

<!-- Event syntax
static public event Windows.Foundation.EventHandler VisibilityChanged<object>
-->

# Windows.Gaming.UI.GameBar.VisibilityChanged

## -description
Occurs when Game bar is shown or dismissed.

Use the  event to monitor the visibility state of Game bar. Games can choose to pause gameplay or present an idle state when Game bar is visible and being drawn over the game. While paused or idle, a best practice is to continue rendering the current frame or scene, so that the recording is smooth and seamless if the player begins recording or is already recording. Multiplayer games might choose to continue gameplay rather than to pause.

> [!TIP]
> This event can be raised on background (non-UI) threads. You may need to post an event to the UI thread to perform UI actions.

Use [Visible](gamebar_visible.md) to determine whether Game bar is currently visible.

## -remarks

## -examples

## -see-also
[Visible](gamebar_visible.md), [IsInputRedirectedChanged](gamebar_isinputredirectedchanged.md)