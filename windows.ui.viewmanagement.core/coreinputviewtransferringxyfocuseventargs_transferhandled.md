---
-api-id: P:Windows.UI.ViewManagement.Core.CoreInputViewTransferringXYFocusEventArgs.TransferHandled
-api-type: winrt property
---

<!-- Property syntax.
public bool TransferHandled { get;  set; }
-->

# Windows.UI.ViewManagement.Core.CoreInputViewTransferringXYFocusEventArgs.TransferHandled

## -description

Gets or sets a value that marks the [XYFocusTransferringFromPrimaryView](coreinputview_xyfocustransferringfromprimaryview.md) event as handled.

## -property-value

Set the value to true on successful focus navigation. The default is false.

If false, the input pane retains focus.

## -remarks

Primary view refers to either of the [CoreInputViewKind.Keyboard](https://github.com/MicrosoftDocs/winrt-api/blob/docs/windows.ui.viewmanagement.core/coreinputviewkind.md#-field-keyboard1) or [CoreInputViewKind.Handwriting](https://github.com/MicrosoftDocs/winrt-api/blob/docs/windows.ui.viewmanagement.core/coreinputviewkind.md#-field-handwriting2) views, while CoreInputView can be any of the values from [CoreInputViewKind](coreinputviewkind.md).

## -see-also

[XYFocusTransferringFromPrimaryView](coreinputview_xyfocustransferringfromprimaryview.md)

## -examples
