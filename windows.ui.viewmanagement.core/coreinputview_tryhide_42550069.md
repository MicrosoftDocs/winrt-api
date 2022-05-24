---
-api-id: M:Windows.UI.ViewManagement.Core.CoreInputView.TryHide
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public bool CoreInputView.TryHide()
-->

# Windows.UI.ViewManagement.Core.CoreInputView.TryHide

## -description

Attempts to hide (if visible) the input pane associated with the [CoreInputView](coreinputview.md) pane.

## -returns

True, if the request to hide the input pane was accepted. Otherwise, false.

If this method is called from an app that is not in foreground, the request is rejected and false is returned.

## -remarks

If you set [CoreTextEditContext.InputPaneDisplayPolicy](../windows.ui.text.core/coretexteditcontext_inputpanedisplaypolicy.md) to **Manual**, use [TryShow](coreinputview_tryshow_1077566544.md) or [TryShowPrimaryView](coreinputview_tryshowprimaryview_1925215151.md) to display the input pane, and TryHide or [TryHidePrimaryView](coreinputview_tryhideprimaryview_908065025.md) to hide the input pane.

## -see-also

[TryHidePrimaryView](coreinputview_tryhideprimaryview_908065025.md)

## -examples
