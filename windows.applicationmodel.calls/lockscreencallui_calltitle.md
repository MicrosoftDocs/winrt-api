---
-api-id: P:Windows.ApplicationModel.Calls.LockScreenCallUI.CallTitle
-api-type: winrt property
---

<!-- Property syntax
public string CallTitle { get;  set; }
-->

# Windows.ApplicationModel.Calls.LockScreenCallUI.CallTitle

## -description
Gets and sets a brief description of the nature of the call. This brief description is also called the call's accessible name; its form is "Video call with Jane Doe."

## -property-value
A brief description of the nature of the call, for example, "Video call with Jane Doe."

## -remarks

An app can use the [CallTitle](lockscreencallui_calltitle.md) property to briefly describe the call. This call description is also called the accessible name and is provided to screen readers to describe your app when it runs on the lock screen. Don't include the name of your app in the accessible name; the operating system automatically includes the name of your app in the accessible name and provides that to the screen reader. The recommended form of the accessible name includes the mode of communication (video or audio) and the name of the other party. Here are some examples:

+ Video call with Jane Doe
+ Audio call with Jane Doe
+ Video call with Jane Doe and three others

<!--[jjacks - don't know if this should go here] There are currently three sources of accessible names for app windows. 1. The window title managed by CoreWindow. This is used in the Switch list and in the Alt+Tab list. 2. The window title managed by MultipleViewManager for applications that create multiple windows. This is used in the Switch list and possibly also in the Alt+Tab list. 3. The CallTitle managed by LockScreenCallUI. This is used only on the lock screen.-->

## -examples

## -see-also
