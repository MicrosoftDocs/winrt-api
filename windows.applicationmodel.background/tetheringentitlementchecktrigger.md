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
When this trigger is registered, and your cellular customer tries to turn on tethering through the Windows UI, the background task is triggered. As a mobile network operator, you can use the triggered background task to communicate to Windows whether your cellular customer is allowed to use the tethering feature based on their entitlement.

The background task will only be triggered if it is correctly registered in the Country and Operator Settings Asset (COSA) database for mobile operators. See [Desktop COSA/APN database settings](/windows-hardware/drivers/mobilebroadband/desktop-cosa-apn-database-settings#desktop-cosa-only-settings) for details.

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
