---
-api-id: E:Windows.Gaming.UI.GameBar.IsInputRedirectedChanged
-api-type: winrt event
---

<!-- Event syntax
static public event Windows.Foundation.EventHandler IsInputRedirectedChanged<object>
-->

# Windows.Gaming.UI.GameBar.IsInputRedirectedChanged

## -description
Occurs when input is redirected to Game bar or input is restored to the game.

After the user invokes Game bar, input may be redirected to Game bar while the player interacts with it. Games that are no longer receiving input will typically want to pause gameplay or present an idle state. While paused or idle, a best practice is to continue rendering the current frame or scene, so that the recording is smooth and seamless if the player begins recording or is already recording. Multiplayer games might choose to continue gameplay rather than to pause.

> [!TIP]
> This event can be raised on background (non-UI) threads. You may need to post an event to the UI thread to perform UI actions.

Use [IsInputRedirected](gamebar_isinputredirected.md) to determine whether input is currently redirected to Game bar.

## -remarks

## -examples

## -see-also
[IsInputRedirected](gamebar_isinputredirected.md), [VisibilityChanged](gamebar_visibilitychanged.md)