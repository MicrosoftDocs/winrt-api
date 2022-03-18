---
-api-id: E:Windows.UI.WebUI.WebUIApplication.Suspending
-api-type: winrt event
---

<!-- Event syntax
static public event Windows.UI.WebUI.SuspendingEventHandler Suspending
-->

# Windows.UI.WebUI.WebUIApplication.Suspending

## -description
Occurs when the app is suspending.

## -remarks
The system suspends your app whenever the user switches to another app or to the desktop. The system resumes your app whenever the user switches back to it. When the system resumes your app, the content of your variables and data structures is the same as it was before the system suspended the app. The system restores the app exactly where it left off, so that it appears to the user as if it's been running in the background.

The system attempts to keep your app and its data in memory while it's suspended. However, if the system does not have the resources to keep your app in memory, the system terminates your app. When the user switches back to a suspended app that has been terminated, the app receives an **activated** event and should check whether its session state objects are defined. If the objects are defined, the app should load that data.

The system doesn't notify an app when it's terminated, so your app must save its application data and release exclusive resources and file handles when it's suspended, and restore them when the app is activated after termination.

You should also release any exclusive resources, like file handles at suspend, so that they can be used by other apps while your app is suspended. Your app can also listen to the [Oncheckpoint](/previous-versions/windows/apps/br229839(v=win.10)) event to handle the app being suspended.

> [!NOTE]
> If you need to do asynchronous work when your app is being suspended, you will need to defer completion of suspend until after your work completes. You can use the [suspendingOperation.getDeferral](suspendingoperation_getdeferral_254836512.md) method to delay completion of suspend until after you complete the deferral.

## -examples

## -see-also
[App lifecycle](/windows/uwp/launch-resume/app-lifecycle), [Oncheckpoint event](/previous-versions/windows/apps/br229839(v=win.10)), [App activated, resume, and suspend using the WRL sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208%20app%20samples/%5BJavaScript%5D-Windows%208%20app%20samples/JavaScript/Windows%208%20app%20samples/App%20activated%2C%20resume%2C%20and%20suspend%20using%20the%20WRL%20%20sample%20(Windows%208)/JavaScript)
