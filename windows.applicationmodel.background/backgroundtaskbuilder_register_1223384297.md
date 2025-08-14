---
-api-id: M:Windows.ApplicationModel.Background.BackgroundTaskBuilder.Register(System.String)
-api-type: winrt method
---

# Windows.ApplicationModel.Background.BackgroundTaskBuilder.Register(System.String)

<!--
public Windows.ApplicationModel.Background.BackgroundTaskRegistration Register (string taskName);
-->

## -description

Registers a background task with the specified task name with the system.

## -parameters

### -param taskName

The name of the task assigned to the registered background task. This parameter takes precedence over the [Name](backgroundtaskbuilder_name.md) property. Other background tasks with the same name are removed before registering this current task.

## -returns

An instance of a [BackgroundTaskRegistration](backgroundtaskregistration.md) object.

## -remarks

When using this **BackgroundTaskBuilder.Register(string)** overload, running tasks in modern standby is not requested by default.

The task must have an event trigger for the **Register** method to succeed. The system schedules the background task when its trigger event occurs and all of its conditions have been met.

If there are existing background task registrations with the same name, they are unregistered before registering this new task. This method permits multiple threads to concurrently register tasks with the same name using this method, and that may result in duplicate background task registrations. Use care (e.g., appropriate locking) when invoking this method concurrently. Duplicate registrations may cause task instances to execute concurrently.

An out-of-process background task must also specify a task entry point. A Win32 COM background task must specify a task entry point CLSID using [SetTaskEntryPointClsid(GUID)](backgroundtaskbuilder_settaskentrypointclsid_451828578.md).

See [Create and register an in-process background task](/windows/uwp/launch-resume/create-and-register-an-inproc-background-task), [Create and register an out-of-process background task](/windows/uwp/launch-resume/create-and-register-a-background-task), and [Create and register a Win32 COM background task](/windows/uwp/launch-resume/create-and-register-a-winmain-background-task) for details about registering each kind of task.

## -see-also

## -examples

See [BackgroundTask sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/BackgroundTask/cs/BackgroundTask) for a complete example of registering a background task.

The following example shows the registration of a Win32 COM task that runs on a recurring 15 minute timer.

```csharp
 using System;
 using Windows.ApplicationModel.Background;

 public IBackgroundTaskRegistration RegisterBackgroundTaskWithSystem(IBackgroundTrigger trigger, Guid entryPointClsid, string taskName)
 {
     BackgroundTaskBuilder builder = new BackgroundTaskBuilder();

     builder.SetTrigger(trigger);
     builder.SetTaskEntryPointClsid(entryPointClsid);

     BackgroundTaskRegistration registration;
     if (builder.Validate())
     {
         registration = builder.Register(taskName);
     }
     else
     {
         registration = null;
     }

     return registration;
 }

 RegisterBackgroundTaskWithSystem(new TimeTrigger(15, false), typeof(TimeTriggeredTask).GUID, typeof(TimeTriggeredTask).Name);
 ```
