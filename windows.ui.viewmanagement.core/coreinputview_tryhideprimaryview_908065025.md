---
-api-id: M:Windows.UI.ViewManagement.Core.CoreInputView.TryHidePrimaryView
-api-type: winrt method
---

<!-- Method syntax.
public bool CoreInputView.TryHidePrimaryView()
-->

# Windows.UI.ViewManagement.Core.CoreInputView.TryHidePrimaryView

## -description

Attempts to hide (if visible) the input pane associated with the [CoreInputView](coreinputview.md).

## -returns

True, if the request to show the input pane was accepted. Otherwise false.

If this method is called from an app that is not in foreground, the request is rejected and false is returned.

## -remarks

Primary view refers to either of the [CoreInputViewKind.Keyboard](https://github.com/MicrosoftDocs/winrt-api/blob/docs/windows.ui.viewmanagement.core/coreinputviewkind.md#-field-keyboard1) or [CoreInputViewKind.Handwriting](https://github.com/MicrosoftDocs/winrt-api/blob/docs/windows.ui.viewmanagement.core/coreinputviewkind.md#-field-handwriting2) views, while CoreInputView can be any of the values from [CoreInputViewKind](coreinputviewkind.md).

If you set [CoreTextEditContext.InputPaneDisplayPolicy](../windows.ui.text.core/coretexteditcontext_inputpanedisplaypolicy.md) to **Manual**, use [TryShow](coreinputview_tryshow_1077566544.md) or [TryShowPrimaryView](coreinputview_tryshowprimaryview_1925215151.md) to display the input pane, and [TryHide](coreinputview_tryhide_42550069.md) or TryHidePrimaryView to hide the input pane.

## -see-also

[TryShowPrimaryView](coreinputview_tryshowprimaryview_1925215151.md)

## -examples
