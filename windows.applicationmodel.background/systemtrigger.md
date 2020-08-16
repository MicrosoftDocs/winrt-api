---
-api-id: T:Windows.ApplicationModel.Background.SystemTrigger
-api-type: winrt class
---

<!-- Class syntax.
public class SystemTrigger : Windows.ApplicationModel.Background.IBackgroundTrigger, Windows.ApplicationModel.Background.ISystemTrigger
-->

# Windows.ApplicationModel.Background.SystemTrigger

## -description

Represents a system event that triggers a background task to run.

## -remarks

<!-- confirmed -->
> [!NOTE]
> This class is not agile, which means that you need to consider its threading model and marshaling behavior. For more info, see [Threading and Marshaling (C++/CX)](http://msdn.microsoft.com/en-us/library/windows/apps/hh771042.aspx) and [Using Windows Runtime objects in a multithreaded environment (.NET)](https://go.microsoft.com/fwlink/p/?linkid=258277).

## -examples

The following example shows how to create and register a system trigger with the **TimeZoneChanged** event.

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
// A system trigger that goes off whenever the time zone is changed, or a change occurs with daylight savings time.
//
IBackgroundTrigger trigger = new SystemTrigger(SystemTriggerType.TimeZoneChange, false);

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

[Communication blocking and filtering sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/CommunicationBlockAndFilter)
