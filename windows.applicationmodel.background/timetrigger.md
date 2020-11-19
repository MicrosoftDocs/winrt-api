---
-api-id: T:Windows.ApplicationModel.Background.TimeTrigger
-api-type: winrt class
---

<!-- Class syntax.
public class TimeTrigger : Windows.ApplicationModel.Background.IBackgroundTrigger, Windows.ApplicationModel.Background.ITimeTrigger
-->

# Windows.ApplicationModel.Background.TimeTrigger

## -description
Represents a time event that triggers a background task to run.

## -remarks
The background task must be declared in the manifest before the registration can be successful. You do not need to add the app to the lock screen in order to use background tasks in Windows 10, but you still need to call  [BackgroundExecutionManager.RequestAccessAsync](/uwp/api/windows.applicationmodel.background.backgroundexecutionmanager.RequestAccessAsync) to request background access.

TimeTriggers do not work when the device is in battery saver mode. If the user wants the app to be able to perform background activity when the device is in battery saver mode, they can make an exception for that app in the **Let apps run in the background** settings panel.

<!-- confirmed -->
> [!NOTE]
> This class is not agile, which means that you need to consider its threading model and marshaling behavior. For more info, see [Threading and Marshaling (C++/CX)](/cpp/cppcx/threading-and-marshaling-c-cx) and [Using Windows Runtime objects in a multithreaded environment (.NET)](/windows/uwp/threading-async/using-windows-runtime-objects-in-a-multithreaded-environment).

## -examples

The following example shows how to create and register a time trigger.

```csharp
//
// A friendly task name.
//
String name = "ExampleTaskName";

//
// Must be the same entry point that is specified in the manifest.
//
String taskEntryPoint = "ExampleNamespace.ExampleTaskName";

//
// A time trigger that repeats at 15-minute intervals.
//
IBackgroundTrigger trigger = new TimeTrigger(15, false);

//
// Builds the background task.
//
BackgroundTaskBuilder builder = new BackgroundTaskBuilder();

builder.Name = name;
builder.TaskEntryPoint = taskEntryPoint;
builder.SetTrigger(trigger);

//
// Registers the background task, and get back a BackgroundTaskRegistration object representing the registered task.
//
BackgroundTaskRegistration task = builder.Register();
```

## -see-also