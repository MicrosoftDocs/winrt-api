---
-api-id: M:Windows.Gaming.Input.Preview.LegacyGipGameControllerProvider.ClearPairing(Windows.System.User,System.String)
-api-type: winrt method
---

# Windows.Gaming.Input.Preview.LegacyGipGameControllerProvider.ClearPairing(Windows.System.User,System.String)

<!--
public static void ClearPairing (Windows.System.User user, string controllerProviderId);
-->

## -description

Removes any copilot pairings for controllerId for the given user.

## -parameters

### -param user

User to clear the pairing for.

### -param controllerProviderId

Provider id for the controller to remove from parings.

## -remarks

Removes the given controller from any pairings where it is either a pilot or copilot for the given user. The controller does not need to be connected to be unpaired. Removing one controller from a pairing removes the pairing entirely &mdash; that is, if a controller is paired as a copilot to another controller, removing the copilot controller will also remove the pairing for the pilot controller and vice versa.

> [!CAUTION]
> Copilot pairing is system-wide and persistent for the given user. This should only be done at the user's direction.

## -see-also

## -examples

:::code language="csharp" source="code/csharp/CopilotSample.cs":::
