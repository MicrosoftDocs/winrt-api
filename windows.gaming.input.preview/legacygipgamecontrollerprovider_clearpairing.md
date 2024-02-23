---
-api-id: M:Windows.Gaming.Input.Preview.LegacyGipGameControllerProvider.ClearPairing(Windows.System.User, System.String)
-api-type: winrt method
---

<!-- Method syntax.
public void LegacyGipGameControllerProvider.ClearPairing(User user, string controllerProviderId)
-->

# Windows.Gaming.Input.Preview.LegacyGipGameControllerProvider.ClearPairing

## -description

Removes any copilot pairings for controllerId for the given user.

## -parameters

### -param user

User to clear the pairing for.

### -param controllerProviderId

Provider id for the controller to remove from parings.

## -remarks

Removes the given controller from any pairings where it is either a pilot or copilot for the given user. The controller does not need to be connected to be unpaired.

> [!CAUTION]
> Copilot pairing is system-wide and persistent for the given user. This should only be done at the user's direction.

## -examples

:::code language="csharp" source="code/csharp/CopilotSample.cs":::

## -see-also
