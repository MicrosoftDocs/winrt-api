---
-api-id: M:Windows.Gaming.Input.Preview.LegacyGipGameControllerProvider.PairPilotToCopilot(Windows.System.User, System.String, System.String)
-api-type: winrt method
---

<!-- Method syntax.
public void LegacyGipGameControllerProvider.PairPilotToCopilot(User user, string pilotControllerProviderId, string copilotControllerProviderId)
-->

# Windows.Gaming.Input.Preview.LegacyGipGameControllerProvider.PairPilotToCopilot

## -description

Pairs the given pilot and copilot controllers for the given user.

## -parameters

### -param user

User to create a copilot pairing for.

### -param pilotControllerProviderId

Provider id for the pilot controller.

### -param copilotControllerProviderId

Provider id for the copilot controller.

## -remarks

Once a pilot and copilot controller are paired, all physical inputs from either controller will appear through all input APIs as though they came from the pilot controller.

> [!CAUTION]
> Copilot pairing is system-wide and persistent for the given user. This should only be done at the user's direction.

## -examples

:::code language="csharp" source="code/csharp/CopilotSample.cs":::

## -see-also
