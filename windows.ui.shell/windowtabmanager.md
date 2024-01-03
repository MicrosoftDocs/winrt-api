---
-api-id: T:Windows.UI.Shell.WindowTabManager
-api-type: winrt class
---

# Windows.UI.Shell.WindowTabManager

<!--
public sealed class WindowTabManager
-->

## -description

Lets an app manage the relationship between its in-app UI tabs and representations of the tabs in the system shell UI.

## -remarks

> [!IMPORTANT]
> This API is for Win32 desktop apps only. UWP and other app types are not supported.

If your app uses visual tabs to organize and separate content, you can use `WindowTabManager` to expose those tabs in system shell UI for easier access.

The `WindowTabManager` lets an app share information about its in-app tab views to the Windows shell. How the shell chooses to respond to the information, if at all, is at the shell's discretion. (In other words, the implementation may be inert on some shells.)

`WindowsTabManager` stores the list of tabs the app wants the Windows shell to know about and lets the app indicate which one is the currently active tab. The app can also provide information about the tab's title, icon, grouping, and if they are associated with an alternative application id.

`WindowsTabManager` also provides events that the app can subscribe to in order to react to Windows shell-triggered interactions with its tabs; for example, switching to a different tab, closing a tab, or knowing that a preview of a tab is displayed.

## -see-also

## -examples
