---
-api-id: T:Windows.ApplicationModel.Background.SystemCondition
-api-type: winrt class
---

<!-- Class syntax.
public class SystemCondition : Windows.ApplicationModel.Background.IBackgroundCondition, Windows.ApplicationModel.Background.ISystemCondition
-->

# Windows.ApplicationModel.Background.SystemCondition

## -description
Represents a system condition that must be in effect for a background task to run.

## -remarks
> [!NOTE]
> : This class is not agile, which means that you need to consider its threading model and marshaling behavior. For more info, see [Threading and Marshaling (C++/CX)](http://go.microsoft.com/fwlink/p/?linkid=258275) and [Using Windows Runtime objects in a multithreaded environment (.NET)](http://go.microsoft.com/fwlink/p/?linkid=258277).

## -examples
The following example expands on the example shown in [SystemTrigger](systemtrigger.md) by also adding a condition to the background task.

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
IBackgroundTrigger trigger = IBackgroundTrigger trigger = new SystemTrigger(SystemTriggerType.TimeZoneChange, false);

//
// A system condition indicating that the background task shouldn't run until the user is present.
//
SystemCondition condition = new SystemCondition(SystemConditionType.UserPresent)

//
// Builds the background task.
//
BackgroundTaskBuilder builder = new BackgroundTaskBuilder();

builder.Name = name;
builder.TaskEntryPoint = taskEntryPoint;
builder.SetTrigger(trigger);
builder.AddCondition(condition);

//
// Registers the background task, and get back a BackgroundTaskRegistration object representing the registered task.
//
BackgroundTaskRegistration task = builder.Register();
```



## -see-also