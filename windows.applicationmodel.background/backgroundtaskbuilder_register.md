---
-api-id: M:Windows.ApplicationModel.Background.BackgroundTaskBuilder.Register
-api-type: winrt method
---

<!-- Method syntax
public Windows.ApplicationModel.Background.BackgroundTaskRegistration Register()
-->

# Windows.ApplicationModel.Background.BackgroundTaskBuilder.Register

## -description

Registers a background task with the system.

## -returns

An instance of a [BackgroundTaskRegistration](backgroundtaskregistration.md) object.

## -remarks

The task must have an event trigger for the Register method to succeed. The system schedules the background task when its trigger event occurs and all of its conditions have been met.

An out-of-process background task must also specify a task entry point. See [Create and register an in-process background task](/windows/uwp/launch-resume/create-and-register-an-inproc-background-task) and [Create and register an out-of-process background task](/windows/uwp/launch-resume/create-and-register-a-background-task) for details about registering each kind of task.

### Background task parameter validation

> **Windows 8**
> Windows 8 does not validate the parameters set on the [BackgroundTaskBuilder](backgroundtaskbuilder.md) object until the system tries to run the background task. If the parameters aren't valid, the background task can't start and an event log entry is created.

> **Windows 8.1**
> Starting in Windows 8.1, the parameters used to register the background task are validated at the time of registration. An error is returned if the background task registration fails, allowing the app to determine whether or not the background task is valid. For C# and Visual Basic, task registration errors typically result in specific .NET exceptions being thrown. These exceptions are thrown as first-chance exceptions and should be corrected while you're still developing your code.Existing Windows 8 apps running on Windows 8.1 are subject to this new system behavior, which can cause the app to crash if it can't handle a failed background task registration. (An event log entry will still be generated for the failed background task registration.) As a result, Windows 8 apps that register invalid background tasks should be rewritten to register background tasks correctly and to handle failed background task registration as a caught exception.

## -examples

[BackgroundTask sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/BackgroundTask/cs/BackgroundTask)

## -see-also



---
-api-id: M:Windows.ApplicationModel.Background.BackgroundTaskBuilder.Register(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.ApplicationModel.Background.BackgroundTaskRegistration Register(System.String taskName)
-->

# Windows.ApplicationModel.Background.BackgroundTaskBuilder.Register(String)

## -description

Registers a background task with the specified task name with the system.

## -parameters
### -param taskNaame
The *Task Name* assigned to the registered background task. This parameter takes precedence over the [Name property](windows.applicationmodel.background/backgroundtaskbuilder_name.md). Other background tasks with the same name are removed before registering this current task.

## -returns

An instance of a [BackgroundTaskRegistration](backgroundtaskregistration.md) object.

## -remarks

The task must have an event trigger for the Register method to succeed. The system schedules the background task when its trigger event occurs and all of its conditions have been met.

If there are existing background task registrations with the same name, they are unregistered before registering this new task. This method permits multiple threads to concurrently register tasks with the same name using this method, and that may result in duplicate background task registrations. Use care (e.g., appropriate locking) when invoking this method concurrently. Duplicate registrations may cause task instances to execute concurrently.

An out-of-process background task must also specify a task entry point. A Win32 COM background task must specify a task entry point CLSID using [SetTaskEntryPointClsid(GUID)](windows.applicationmodel.background/backgroundtaskbuilder_settaskentrypointclsid_451828578.md).

See [Create and register an in-process background task](/windows/uwp/launch-resume/create-and-register-an-inproc-background-task), [Create and register an out-of-process background task](/windows/uwp/launch-resume/create-and-register-a-background-task), and [Create and register a Win32 COM background task](/windows/uwp/launch-resume/create-and-register-a-winmain-background-task) for details about registering each kind of task.

### Background task parameter validation

## -examples

[BackgroundTask sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/BackgroundTask/cs/BackgroundTask)

The following example shows the registration of a Win32 COM task that runs on a recurring 15 minute timer. The 
```csharp
 using System;
 using Windows.ApplicationModel.Background;
 
 public IBackgroundTaskRegistration RegisterBackgroundTaskWithSystem(IBackgroundTrigger trigger, Guid entryPointClsid, string taskName)
 {
     BackgroundTaskBuilder builder = new BackgroundTaskBuilder();
 
     builder.SetTrigger(trigger);
     builder.SetTaskEntryPointClsid(entryPointClsid);
 
     BackgroundTaskRegistration registration;
     try
     {
         registration = builder.Register(taskName);
     }
     catch (Exception)
     {
         registration = null;
     }
 
     return registration;
 }
 
 RegisterBackgroundTaskWithSystem(new TimeTrigger(15, false), typeof(TimeTriggeredTask).GUID, typeof(TimeTriggeredTask).Name);
 ```

## -see-also

