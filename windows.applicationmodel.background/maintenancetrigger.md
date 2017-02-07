---
-api-id: T:Windows.ApplicationModel.Background.MaintenanceTrigger
-api-type: winrt class
---

<!-- Class syntax.
public class MaintenanceTrigger : Windows.ApplicationModel.Background.IBackgroundTrigger, Windows.ApplicationModel.Background.IMaintenanceTrigger
-->

# Windows.ApplicationModel.Background.MaintenanceTrigger

## -description
Represents a maintenance trigger.

## -remarks
Background tasks that use a maintenance trigger run only when the system is connected to AC power.

> [!NOTE]
> This class is not agile, which means that you need to consider its threading model and marshaling behavior. For more info, see [Threading and Marshaling (C++/CX)](http://go.microsoft.com/fwlink/p/?linkid=258275) and [Using Windows Runtime objects in a multithreaded environment (.NET)](http://go.microsoft.com/fwlink/p/?linkid=258277).

## -examples
The following example shows how to create and register a maintenance trigger.

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
// A system trigger that goes off every 15 minutes as long as the device is plugged in to AC power.
//
MaintenanceTrigger trigger = new MaintenanceTrigger(15, false);

//
// Build the background task.
//
BackgroundTaskBuilder builder = new BackgroundTaskBuilder();

builder.Name = name;
builder.TaskEntryPoint = taskEntryPoint;
builder.SetTrigger(trigger);

//
// Register the background task, and get back a BackgroundTaskRegistration object representing the registered task.
//
BackgroundTaskRegistration task = builder.Register();
```

```javascript
//
// A friendly task name.
//
var name = "ExampleTaskName";

//
// Must be the same entry point that is specified in the manifest.
//
var taskEntryPoint = "ExampleNamespace.ExampleTaskName";

//
// A system trigger that goes off every 15 minutes as long as the device is plugged in to AC power.
//
var trigger = new Windows.ApplicationModel.Background.MaintenanceTrigger(15, false);

//
// Build the background task.
//
var builder = new Windows.ApplicationModel.Background.BackgroundTaskBuilder();

builder.Name = name;
builder.TaskEntryPoint = taskEntryPoint;
builder.SetTrigger(trigger);

//
// Register the background task, and get back a BackgroundTaskRegistration object representing the registered task.
//
var task = builder.Register();
```



## -see-also