---
-api-id: E:Windows.UI.ViewManagement.Core.CoreInputView.PrimaryViewHiding
-api-type: winrt event
---

<!-- Event syntax.
public event TypedEventHandler PrimaryViewHiding<CoreInputView, CoreInputViewHidingEventArgs>
-->

# Windows.UI.ViewManagement.Core.CoreInputView.PrimaryViewHiding

## -description

Occurs before the input pane associated with the [CoreInputView](coreinputview.md) is hidden (if visible).

## -remarks

The application must be in the foreground for this event to fire.

Primary view refers to the [CoreInputViewKind.Keyboard](coreinputviewkind.md#-field-keyboard1), while CoreInputView can be any of the values from [CoreInputViewKind](coreinputviewkind.md).

## -see-also

[Windows.UI.ViewManagement.Core.CoreInputView.PrimaryViewShowing](coreinputview_primaryviewshowing.md), [Windows.UI.ViewManagement.Core.CoreInputViewHidingEventArgs](coreinputviewhidingeventargs.md)

## -examples
