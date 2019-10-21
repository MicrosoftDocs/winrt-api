---
-api-id: T:Windows.UI.Composition.Interactions.VisualInteractionSourceRedirectionMode
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Composition.Interactions.VisualInteractionSourceRedirectionMode : int
-->

# VisualInteractionSourceRedirectionMode

## -description
Indicates what input should be redirected to the InteractionTracker.

## -enum-fields
### -field Off:0
Redirection is off, all input goes to the UI thread.

### -field CapableTouchpadOnly:1
Pointer input goes to the UI thread, Precision Touchpad input goes to the compositor.


### -field CapableTouchpadAndPointerWheel:3


### -field PointerWheelOnly:2


## -remarks

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1803 | 17134 | CapableTouchpadAndPointerWheel |
| 1803 | 17134 | PointerWheelOnly |

## -examples

## -see-also

