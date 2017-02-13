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

You should also release any exclusive resources, like file handles at suspend, so that they can be used by other apps while your app is suspended. Your app can also listen to the [Oncheckpoint](http://msdn.microsoft.com/library/a7620c81-f769-46e5-b030-dde21b8c2d5b) event to handle the app being suspended.

> [!NOTE]
> If you need to do asynchronous work when your app is being suspended, you will need to defer completion of suspend until after your work completes. You can use the [suspendingOperation.getDeferral](suspendingoperation_getdeferral.md) method to delay completion of suspend until after you complete the deferral.

## -examples

## -see-also
[App lifecycle](http://msdn.microsoft.com/library/6c469e77-f1e3-4859-a27b-c326f9616d10), [Oncheckpoint event](http://msdn.microsoft.com/library/a7620c81-f769-46e5-b030-dde21b8c2d5b), [App activated, resume, and suspend using the WRL sample](http://go.microsoft.com/fwlink/p/?linkid=226722)