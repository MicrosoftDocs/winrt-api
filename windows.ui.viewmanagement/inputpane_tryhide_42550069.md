---
-api-id: M:Windows.UI.ViewManagement.InputPane.TryHide
-api-type: winrt method
---

<!-- Method syntax
public bool TryHide()
-->

# Windows.UI.ViewManagement.InputPane.TryHide

## -description
Tries to hide the [InputPane](inputpane.md), if it is visible.

## -returns
**true** if the request to hide the [InputPane](inputpane.md) was accepted; otherwise **false**.

If this method is called from an app that is not in foreground, the request is rejected and **false** is returned.

## -remarks

If you set [CoreTextEditContext.InputPaneDisplayPolicy](../windows.ui.text.core/coretexteditcontext_inputpanedisplaypolicy.md) to **Manual** in your app, you are responsible for showing and hiding the input pane using TryShow and TryHide.

## -examples

## -see-also
[TryShow](inputpane_tryshow_1077566544.md), [Hiding](inputpane_hiding.md)