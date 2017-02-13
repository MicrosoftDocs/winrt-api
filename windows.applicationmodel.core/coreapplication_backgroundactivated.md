---
-api-id: E:Windows.ApplicationModel.Core.CoreApplication.BackgroundActivated
-api-type: winrt event
---

<!-- Event syntax
static public event Windows.Foundation.EventHandler BackgroundActivated<Windows.ApplicationModel.Activation.BackgroundActivatedEventArgs>
-->

# Windows.ApplicationModel.Core.CoreApplication.BackgroundActivated

## -description
Fired when your app is activated by a background trigger.

## -remarks
Register your background triggers with [BackgroundTaskBuilder](../windows.applicationmodel.background/backgroundtaskbuilder.md), but do not set the [TaskEntryPoint](../windows.applicationmodel.background/backgroundtaskbuilder_taskentrypoint.md). This will enable this event to fire when your trigger is signaled. The event handler has a [BackgroundActivatedEventArgs](../windows.applicationmodel.activation/backgroundactivatedeventargs.md) parameter which contains everything that the [IBackgroundTask.Run](../windows.applicationmodel.background/ibackgroundtask_run.md) method delivers.



> [!TIP]
> By the time an app enters the background state, none of its UI is visible.

## -examples

## -see-also
[BackgroundActivatedEventArgs](../windows.applicationmodel.activation/backgroundactivatedeventargs.md)