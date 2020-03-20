---
-api-id: M:Windows.UI.ViewManagement.Core.CoreInputView.TryTransferXYFocusToPrimaryView(Windows.Foundation.Rect,Windows.UI.ViewManagement.Core.CoreInputViewXYFocusTransferDirection)
-api-type: winrt method
---

<!-- Method syntax.
public bool CoreInputView.TryTransferXYFocusToPrimaryView(Rect origin, CoreInputViewXYFocusTransferDirection direction)
-->

# Windows.UI.ViewManagement.Core.CoreInputView.TryTransferXYFocusToPrimaryView

## -description
Attempts to move focus from the application UI to the input pane.

## -parameters
### -param origin
The rectangle, in client coordinates, representing the previously focused UI element. Specified in device-independent pixels (DIP).

### -param direction
The direction of navigation. If the input pane is not located in the specified direction, this method fails and returns false.

## -returns
True, if the input pane received focus; otherwise, false.

## -remarks

## -see-also
[Rect](../windows.foundation/rect.md), [CoreInputViewXYFocusTransferDirection](coreinputviewxyfocustransferdirection.md), [XYFocusTransferredToPrimaryView](coreinputview_xyfocustransferredtoprimaryview.md), [XYFocusTransferringFromPrimaryView](coreinputview_xyfocustransferringfromprimaryview.md)

## -examples

