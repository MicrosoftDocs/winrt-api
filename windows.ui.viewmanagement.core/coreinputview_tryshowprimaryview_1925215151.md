---
-api-id: M:Windows.UI.ViewManagement.Core.CoreInputView.TryShowPrimaryView
-api-type: winrt method
---

<!-- Method syntax.
public bool CoreInputView.TryShowPrimaryView()
-->

# Windows.UI.ViewManagement.Core.CoreInputView.TryShowPrimaryView

## -description

Attempts to show (if hidden) the [CoreInputView](coreinputview.md) pane.

This method is a "best effort" and guarantees only that the user has a way to interact with the focused control. For a docked a Soft Input Panel (SIP) like the **Touch keyboard and handwriting panel**, the pane is shown only if a hardware keyboard is not available.

## -returns

True, if the request to show the input pane was accepted. Otherwise, false.

If this method is called from an app that is not in foreground, the request is rejected and false is returned.

## -remarks

Primary view refers to either of the [CoreInputViewKind.Keyboard](https://github.com/MicrosoftDocs/winrt-api/blob/docs/windows.ui.viewmanagement.core/coreinputviewkind.md#-field-keyboard1) or [CoreInputViewKind.Handwriting](https://github.com/MicrosoftDocs/winrt-api/blob/docs/windows.ui.viewmanagement.core/coreinputviewkind.md#-field-handwriting2) views, while CoreInputView can be any of the values from [CoreInputViewKind](coreinputviewkind.md).

If you set [CoreTextEditContext.InputPaneDisplayPolicy](../windows.ui.text.core/coretexteditcontext_inputpanedisplaypolicy.md) to **Manual** in your app, you are responsible for showing and hiding the input pane using [TryShowPrimaryView](coreinputview_tryshowprimaryview_1925215151.md) and [TryHidePrimaryView](coreinputview_tryhideprimaryview_908065025.md).

## -see-also

[TryHidePrimaryView](coreinputview_tryhideprimaryview_908065025.md)

## -examples
