---
-api-id: P:Windows.ApplicationModel.Background.BackgroundTaskBuilder.TaskEntryPoint
-api-type: winrt property
---

<!-- Property syntax
public string TaskEntryPoint { get;  set; }
-->

# Windows.ApplicationModel.Background.BackgroundTaskBuilder.TaskEntryPoint

## -description
Gets or sets the class that performs the work of a background task.

## -property-value
The name of an application-defined class that performs the work of a background task.

## -remarks
> **Windows Store app using C++, C#, or Visual Basic**
> The task entry point class must implement the [IBackgroundTask](ibackgroundtask.md) interface. The system calls [IBackgroundTask::Run ](ibackgroundtask_run.md) when the background task is triggered. In addition, the class must be specified in the `<Extensions>` section of the application's manifest as `<Extension Category="windows.backgroundTasks" EntryPoint="appNamespace.appClassName">`.The task entry point class can be implemented in the same process as the application's foreground component (in-proc); however, it cannot run on any of the application's foreground threads because the application might be suspended when the background task is triggered. For best results, implement the class in a separate process (out-of-proc) to decouple it from the application's foreground components and allow the system to manage the application's processes more efficiently.

> **Windows Store app using JavaScript**
> The entry point for a JavaScript background task is a JavaScript start page. See [WebUIBackgroundTaskInstance.current](../windows.ui.webui/webuibackgroundtaskinstance_current.md) for more information.Note that JavaScript background tasks must call [close()](XREF:TODO:ie10devguide.web_workers) to terminate when they are done, so they don't continue to consume the user's memory and battery.



## -examples

## -see-also
