---
-api-id: M:Windows.Gaming.Input.Preview.LegacyGipGameControllerProvider.FromGameControllerProvider(Windows.Gaming.Input.Custom.IGameControllerProvider)
-api-type: winrt method
---

# Windows.Gaming.Input.Preview.LegacyGipGameControllerProvider.FromGameControllerProvider(Windows.Gaming.Input.Custom.IGameControllerProvider)

<!--
public static Windows.Gaming.Input.Preview.LegacyGipGameControllerProvider FromGameControllerProvider (Windows.Gaming.Input.Custom.IGameControllerProvider provider);
-->

## -description

Constructs a [LegacyGipGameControllerProvider](legacygipgamecontrollerprovider.md) for the given controller provider.

## -parameters

### -param provider

Controller provider to construct a LegacyGipGameControllerProvider for.

## -returns

A LegacyGipGameControllerProvider if the controller is a GIP (Gaming Input Protocol) controller. Null if the controller is not a GIP controller.

## -remarks

## -see-also

[LegacyGipGameControllerProvider](legacygipgamecontrollerprovider.md)

## -examples

:::code language="csharp" source="code/csharp/HeadsetManagementSample.cs":::
