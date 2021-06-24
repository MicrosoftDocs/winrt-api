---
-api-id: M:Windows.UI.ViewManagement.Core.CoreInputView.TryShow
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public bool CoreInputView.TryShow()
-->

# Windows.UI.ViewManagement.Core.CoreInputView.TryShow

## -description

Attempts to show (if hidden) the input pane associated with the [CoreInputView](coreinputview.md).

## -returns

True if the request to show the input pane was accepted. Otherwise, false.

If this method is called from an app that is not in foreground, the request is rejected and false is returned.

## -remarks

This method is a "best effort" and guarantees only that the user has a way to interact with the focused control. For a docked a Soft Input Panel (SIP) like the **Touch keyboard and handwriting panel**, the pane is shown only if a hardware keyboard is not available.

If you set [CoreTextEditContext.InputPaneDisplayPolicy](../windows.ui.text.core/coretexteditcontext_inputpanedisplaypolicy.md) to `Manual`, use TryShow or [TryShowPrimaryView](coreinputview_tryshowprimaryview_1925215151.md) to display the input pane, and [TryHide](coreinputview_tryhide_42550069.md) or [TryHidePrimaryView](coreinputview_tryhideprimaryview_908065025.md) to hide the input pane.

## -see-also

[TryShowPrimaryView](coreinputview_tryshowprimaryview_1925215151.md), [TryShow](coreinputview_tryshow_154132369.md)

## -examples
