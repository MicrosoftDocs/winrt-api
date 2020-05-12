---
-api-id: M:Windows.ApplicationModel.Background.BackgroundTaskBuilder.SetTaskEntryPointClsid(System.Guid)
-api-type: winrt method
---

## -description
Assigns a COM CLSID entry point using an existing BackgroundTaskBuilder object.

## -parameters

### -param TaskEntryPoint
The name of the application-defined TaskEntryPoint class.

## -remarks
For classic COM CLSID activations, the CLSID to activate is specified via SetTaskEntryPointClsid method during registration. The COM registration must identify an out-of-process COM server (i.e. LocalServer32).

## -see-also

[TaskEntryPoint](backgroundtaskbuilder_taskentrypoint.md)

## -examples

The following code sample demonstrates the use of BackgroundTaskBuilder to register the created WinMain COM background task to a time trigger on a 15-minute interval. 

The sample code avoids creating duplicate tasks by checking if a background task with a particular task name is already registered. This is done in sample code since the intent is that only one particular background task registration exists. 

It is up to the app developer to create one or multiple background tasks with the same entry point (or trigger or name).

```csharp
 using System;
 using Windows.ApplicationModel.Background;
 
 public IBackgroundTaskRegistration RegisterBackgroundTaskWithSystem(IBackgroundTrigger trigger, Guid entryPointClsid, string taskName)
 {
     foreach (var registrationIterator in BackgroundTaskRegistration.AllTasks)
     {
         if (registrationIterator.Value.Name == taskName)
         {
             return registrationIterator.Value;
         }
     }
 
     BackgroundTaskBuilder builder = new BackgroundTaskBuilder();
 
     builder.SetTrigger(trigger);
     builder.SetTaskEntryPointClsid(entryPointClsid);
     builder.Name = taskName;
 
     BackgroundTaskRegistration registration;
     try
     {
         registration = builder.Register();
     }
     catch (Exception)
     {
         registration = null;
     }
 
     return registration;
 }
 
 RegisterBackgroundTaskWithSystem(new TimeTrigger(15, false), typeof(TimeTriggeredTask).GUID, typeof(TimeTriggeredTask).Name);
 ```
