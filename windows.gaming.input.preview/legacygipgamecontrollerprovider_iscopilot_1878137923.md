---
-api-id: M:Windows.Gaming.Input.Preview.LegacyGipGameControllerProvider.IsCopilot(Windows.System.User,System.String)
-api-type: winrt method
---

# Windows.Gaming.Input.Preview.LegacyGipGameControllerProvider.IsCopilot(Windows.System.User,System.String)

<!--
public static string IsCopilot (Windows.System.User user, string controllerProviderId);
-->

## -description

Retrieves the ID of the pilot controller if this controller is a copilot.

## -parameters

### -param user

User to check the pairing for.

### -param controllerProviderId

Provider id for the controller to check for pairings.

## -returns

The ID of the pilot controller if this controller is a copilot; otherwise, null.

## -remarks

## -see-also

## -examples

:::code language="csharp" source="code/csharp/CopilotSample.cs":::
