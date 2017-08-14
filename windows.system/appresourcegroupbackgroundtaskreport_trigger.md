---
-api-id: P:Windows.System.AppResourceGroupBackgroundTaskReport.Trigger
-api-type: winrt property
---

<!-- Property syntax.
public string Trigger { get; }
-->

# Windows.System.AppResourceGroupBackgroundTaskReport.Trigger

## -description
Gets the name of the trigger that activated this task.

## -property-value
The name of the trigger.

## -remarks
If the task is activated by a trigger, then this will be the trigger type name; otherwise it will be an internally-generated string that identifies the activation behavior. For example, the trigger string would be `"Windows.ApplicationModel.Background.ActivitySensorTrigger"` if an app set a background task trigger in code like this:

```csharp
var builder = new Windows.ApplicationModel.Background.BackgroundTaskBuilder;
builder.SetTrigger(new Windows.ApplicationModel.Background.ActivitySensorTrigger(50));
```

## -see-also

## -examples

## -capabilities
appDiagnostics
