---
-api-id: T:Windows.ApplicationModel.Background.TetheringEntitlementCheckTrigger
-api-type: winrt class
---

<!-- Class syntax.
public class TetheringEntitlementCheckTrigger : IBackgroundTrigger
-->

# Windows.ApplicationModel.Background.TetheringEntitlementCheckTrigger

## -description
Represents a tethering event that triggers a background task to run.

## -remarks
When this trigger is registered, and the user tries to turn on tethering through the Windows UI, the background task is triggered.

> [!WARNING]
> The tethering trigger may not behave as expected if it is reregistered multiple times

## -see-also

## -examples

The following example shows how to create and register a tethering trigger:

```csharp
using Windows.ApplicationModel.Background;

void RegisterTetheringTrigger()
{
  bool taskAlreadyRegistered = false;
  string exampleTaskName = "MyEntitlementTask";

  foreach (var task in BackgroundTaskRegistration.AllTasks)
  {
      if (task.Value.Name == exampleTaskName)
      {
          taskAlreadyRegistered = true;
          break;
      }
  }

  if (!taskAlreadyRegistered)
  {
      var builder = new BackgroundTaskBuilder();

      builder.Name = exampleTaskName;
      builder.TaskEntryPoint = "Sample.TheActualBackgroundTask";
      var trigger = new TetheringEntitlementCheckTrigger();
      builder.SetTrigger(trigger);
      builder.Register();
  }
}
```

## -capabilities
networkConnectionManagerProvisioning
