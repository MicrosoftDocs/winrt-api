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

**true** if the request to show the input pane was accepted; otherwise **false**.

If this method is called from an app that is not in foreground, the request is rejected and **false** is returned.

## -remarks

If you set [CoreTextEditContext.InputPaneDisplayPolicy](../windows.ui.text.core/coretexteditcontext_inputpanedisplaypolicy.md) to **Manual** in your app, you are responsible for showing and hiding the input pane using TryShowPrimaryView and [TryHidePrimaryView](coreinputview_tryhideprimaryview_908065025.md).

## -see-also

[TryHidePrimaryView](coreinputview_tryhideprimaryview_908065025.md)

## -examples
