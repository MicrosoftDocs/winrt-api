---
-api-id: M:Windows.Gaming.Input.Preview.LegacyGipGameControllerProvider.PairPilotToCopilot(Windows.System.User,System.String,System.String)
-api-type: winrt method
---

# Windows.Gaming.Input.Preview.LegacyGipGameControllerProvider.PairPilotToCopilot(Windows.System.User,System.String,System.String)

<!--
public static void PairPilotToCopilot (Windows.System.User user, string pilotControllerProviderId, string copilotControllerProviderId);
-->

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

## -see-also

## -examples

:::code language="csharp" source="code/csharp/CopilotSample.cs":::
