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
