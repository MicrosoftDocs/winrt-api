---
-api-id: P:Windows.UI.WebUI.WebUIBackgroundTaskInstance.Current
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.WebUI.IWebUIBackgroundTaskInstance Current { get; }
-->

# Windows.UI.WebUI.WebUIBackgroundTaskInstance.Current

## -description
Gets the current background task.

## -property-value
The current background task. This property can only be accessed in the context of a background task. This property is null in a foreground app.

## -remarks
An app creates a background task by using the [BackgroundTaskBuilder](../windows.applicationmodel.background/backgroundtaskbuilder.md) class. The [SetTrigger](/windows/desktop/api/mstask/nf-mstask-itasktrigger-settrigger) method must be set to the event trigger for the task. The [TaskEntryPoint](../windows.applicationmodel.background/backgroundtaskbuilder_taskentrypoint.md) must specify a JavaScript file containing the code to run. The app then registers the background task by calling the [Register](../windows.applicationmodel.background/backgroundtaskbuilder_register_292201929.md) method. When the trigger fires, the system executes the code in the JavaScript file.

The app must also specify the JavaScript file in the `<Extensions>` section of the app manifest. For example: `<Extension Category="windows.backgroundTasks" StartPage = "js\backgroundtask.js">.`.

When a background task is run, it can use the object returned from the Current property to set the success or failure of the background task and to access properties of the task.

After the background task finishes its work, the task must call the Web Workers [close](/previous-versions/windows/internet-explorer/ie-developer/dev-guides/hh673568(v=vs.85)) method to terminate itself. This way it doesn't continue to consume the user's memory and battery. Additionally only one background task for the same trigger can run at a time so the previous task must be closed before a new one can be triggered. 

> [!NOTE]
> Background tasks are meant to be short lived tasks. In general you should not register for event callbacks in a background task. In the case that you do register for a Windows Runtime event and the foreground instance of your app also registers for that event, the callback in your background task may be unreliable.

## -examples

## -see-also
