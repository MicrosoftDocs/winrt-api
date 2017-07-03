---
-api-id: M:Windows.UI.ViewManagement.Core.CoreInputView.TryHidePrimaryView
-api-type: winrt method
---

<!-- Method syntax.
public bool CoreInputView.TryHidePrimaryView()
-->

# Windows.UI.ViewManagement.Core.CoreInputView.TryHidePrimaryView

## -description
Tries to hide the [InputPane](inputpane.md), if it is visible.

## -returns
**true** if the request to show the [CoreInputView](coreinputview.md) pane was accepted; otherwise **false**.

If this method is called from an app that is not in foreground, the request is rejected and **false** is returned.

## -remarks
If you set [CoreTextEditContext.InputPaneDisplayPolicy](../windows.ui.text.core/coretexteditcontext_inputpanedisplaypolicy.md) to **Manual** in your app, you are responsible for showing and hiding the input pane using [TryShowPrimaryView](coreinputview_tryshowprimaryview_1925215151.md) and [TryHidePrimaryView](coreinputview_tryhideprimaryview_908065025.md).

## -see-also
- [TryShowPrimaryView](coreinputview_tryshowprimaryview_1925215151.md)

## -examples

