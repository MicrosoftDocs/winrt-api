---
-api-id: E:Windows.ApplicationModel.Core.CoreApplication.EnteredBackground
-api-type: winrt event
---

<!-- Event syntax
static public event Windows.Foundation.EventHandler EnteredBackground<Windows.ApplicationModel.EnteredBackgroundEventArgs>
-->

# Windows.ApplicationModel.Core.CoreApplication.EnteredBackground

## -description
Fired when the app enters the running in the background state.

## -remarks
This event is fired when your app is no longer visible in the foreground.

Previously your suspending callback was the best place to save state after a user finished a session with your app. However, now an application may continue running in the background and then move back to the foreground due to trigger activity without ever reaching the suspended state. The best place to save data after a user session is in your entered background event handler.

Memory limits also change as an app moves into the background. It is best to check the [MemoryManager](../windows.system/memorymanager.md) and release memory if needed to ensure your app does not get terminated.

## -examples

## -see-also
[EnteredBackgroundEventArgs](../windows.applicationmodel/enteredbackgroundeventargs.md)