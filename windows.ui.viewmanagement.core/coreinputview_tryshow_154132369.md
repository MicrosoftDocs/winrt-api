---
-api-id: M:Windows.UI.ViewManagement.Core.CoreInputView.TryShow(Windows.UI.ViewManagement.Core.CoreInputViewKind)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public bool CoreInputView.TryShow(CoreInputViewKind type)
-->

# Windows.UI.ViewManagement.Core.CoreInputView.TryShow

## -description

Attempts to show (if hidden) the specified [type](coreinputviewkind.md) of input pane associated with the [CoreInputView](coreinputview.md).

## -parameters

### -param type

[CoreInputViewKind](coreinputviewkind.md)

## -returns

True, if the request to show the input pane was accepted; otherwise false.

If this method is called from an app that is not in foreground, the request is rejected and false is returned.

## -remarks

If *type* is set to **[Default](coreinputviewkind.md)**, a "best effort" is made to show the input pane while ensuring the user can still interact with the focused control. For example, a docked a Soft Input Panel (SIP), such as the **Touch keyboard and handwriting panel**, is shown only if a hardware keyboard is not available.

Use this method if you want to provide a specific user experience based on a specific input pane, such as the Windows emoji pane.

Primary view refers to either of the [CoreInputViewKind.Keyboard](https://github.com/MicrosoftDocs/winrt-api/blob/docs/windows.ui.viewmanagement.core/coreinputviewkind.md#-field-keyboard1) or [CoreInputViewKind.Handwriting](https://github.com/MicrosoftDocs/winrt-api/blob/docs/windows.ui.viewmanagement.core/coreinputviewkind.md#-field-handwriting2) views, while CoreInputView can be any of the values from [CoreInputViewKind](coreinputviewkind.md).

If you set [CoreTextEditContext.InputPaneDisplayPolicy](../windows.ui.text.core/coretexteditcontext_inputpanedisplaypolicy.md) to 'Manual', use [TryShow](coreinputview_tryshow_1077566544.md) or [TryShowPrimaryView](coreinputview_tryshowprimaryview_1925215151.md) to display the input pane, and [TryHide](coreinputview_tryhide_42550069.md) or [TryHidePrimaryView](coreinputview_tryhideprimaryview_908065025.md) to hide the input pane.

## -see-also

[TryShowPrimaryView](coreinputview_tryshowprimaryview_1925215151.md), [TryShow](coreinputview_tryshow_1077566544.md)

## -examples
