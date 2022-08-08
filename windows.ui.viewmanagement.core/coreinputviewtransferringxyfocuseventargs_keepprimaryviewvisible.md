---
-api-id: P:Windows.UI.ViewManagement.Core.CoreInputViewTransferringXYFocusEventArgs.KeepPrimaryViewVisible
-api-type: winrt property
---

<!-- Property syntax.
public bool KeepPrimaryViewVisible { get;  set; }
-->

# Windows.UI.ViewManagement.Core.CoreInputViewTransferringXYFocusEventArgs.KeepPrimaryViewVisible

## -description

Gets or sets whether the input pane remains visible when the UI element loses focus.

## -property-value

True, if the input pane remains visible; otherwise, false. The default is true.

## -remarks

Primary view refers to either of the [CoreInputViewKind.Keyboard](https://github.com/MicrosoftDocs/winrt-api/blob/docs/windows.ui.viewmanagement.core/coreinputviewkind.md#-field-keyboard1) or [CoreInputViewKind.Handwriting](https://github.com/MicrosoftDocs/winrt-api/blob/docs/windows.ui.viewmanagement.core/coreinputviewkind.md#-field-handwriting2) views, while CoreInputView can be any of the values from [CoreInputViewKind](coreinputviewkind.md).

## -see-also

[XYFocusTransferringFromPrimaryView](coreinputview_xyfocustransferringfromprimaryview.md)

## -examples
