---
-api-id: M:Windows.UI.ViewManagement.InputPane.TryShow
-api-type: winrt method
---

<!-- Method syntax
public bool TryShow()
-->

# Windows.UI.ViewManagement.InputPane.TryShow

## -description
Tries to show the [InputPane](inputpane.md), if it is hidden.

This method is a "best effort" and guarantees only that the user has a way to enter text in the focused control. The touch keyboard, or Soft Input Panel (SIP), is shown only if a hardware keyboard is not available.

## -returns
**true** if the request to show the [InputPane](inputpane.md) was accepted; otherwise **false**.

If this method is called from an app that is not in foreground, the request is rejected and **false** is returned.

## -remarks

If you set [CoreTextEditContext.InputPaneDisplayPolicy](../windows.ui.text.core/coretexteditcontext_inputpanedisplaypolicy.md) to **Manual** in your app, you are responsible for showing and hiding the input pane using TryShow and TryHide.

## -examples

## -see-also
[TryHide](inputpane_tryhide_42550069.md), [Showing](inputpane_showing.md)