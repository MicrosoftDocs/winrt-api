---
-api-id: P:Windows.Gaming.UI.GameBar.IsInputRedirected
-api-type: winrt property
---

<!-- Property syntax
public bool IsInputRedirected { get; }
-->

# Windows.Gaming.UI.GameBar.IsInputRedirected

## -description
Indicates whether input is currently redirected to Game bar.

After the user invokes Game bar, input may be redirected to Game bar while the player interacts with it. Games that are no longer receiving input will typically want to pause gameplay or present an idle state. While paused or idle, a best practice is to continue rendering the current frame or scene, so that the recording is smooth and seamless if the player begins recording or is already recording. Multiplayer games might choose to continue gameplay rather than to pause.

To be notified of changes to , handle the [IsInputRedirectedChanged](gamebar_isinputredirectedchanged.md) event.

## -property-value
**true** if input is currently redirected to Game bar; **false** otherwise.

## -remarks

## -examples

## -see-also
[IsInputRedirectedChanged](gamebar_isinputredirectedchanged.md), [Visible](gamebar_visible.md)