---
-api-id: T:Windows.Gaming.Input.Preview.LegacyGipGameControllerProvider
-api-type: winrt class
---

# Windows.Gaming.Input.Preview.LegacyGipGameControllerProvider

<!--
public sealed class LegacyGipGameControllerProvider
-->

## -description

Exposes a set of properties and functionality for administering gaming accessories, such as gamepads and headsets, that use the GIP (Gaming Input Protocol) protocol.

> [!IMPORTANT]
> Access to this class requires declaring the xboxAccessoryManagement capability

> [!CAUTION]
> These APIs affect all games on a system and may cause problems on an accessory if misused. Microsoft recommends only using these APIs for administering hardware you have developed.

## -examples

### Reading the properties of a controller

:::code language="csharp" source="code/csharp/EnumerateControllerPropertiesSample.cs":::

### Remap buttons

:::code language="csharp" source="code/csharp/RemapButtonsSample.cs":::

### Copilot settings

:::code language="csharp" source="code/csharp/CopilotSample.cs":::

### Headset management

:::code language="csharp" source="code/csharp/HeadsetManagementSample.cs":::

## -see-also

[IGameControllerProvider](../windows.gaming.input.custom/igamecontrollerprovider.md)
