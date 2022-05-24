---
-api-id: E:Windows.UI.Xaml.Application.Resuming
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.EventHandler Resuming<object>
-->

# Windows.UI.Xaml.Application.Resuming

## -description
Occurs when the application transitions from Suspended state to Running state.

## -remarks
The system suspends your app whenever the user switches to another app or to the desktop, and resumes your app whenever the user switches back to it. However, the system can also terminate your app while it is suspended in order to free up resources. Therefore, you should handle the [Suspending](application_suspending.md) event to save your app state.

If your app is terminated, you can restore the app state in an [OnLaunched](application_onlaunched_859642554.md) method override. If your app resumes before it is terminated, the system restores the app state automatically. You should handle the Resuming event only if you need to refresh any displayed content that might have changed while the app is suspended, such as news feeds or the user's location.

Applications should avoid invoking code that puts a high load on the UI thread in response to Resuming. Doing so gives appearance to the user that the shell is being unresponsive, when in fact it is your application code that is the throttle point. Delegate operations to other threads if possible, or use a staged or virtualized approach for rebuilding views and UI whenever the application is resumed.

The Resuming event runs in the same apartment it was registered in.

## -examples

## -see-also
[Suspending](application_suspending.md), [OnActivated](application_onactivated_603737819.md), [Launching and resuming apps](/windows/uwp/launch-resume/), [Processes threads and apartments](/windows/win32/com/processes--threads--and-apartments)
