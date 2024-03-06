---
-api-id: M:Windows.Gaming.Input.Preview.LegacyGipGameControllerProvider.FromGameControllerProvider(Windows.Gaming.Input.IGameControllerProvider)
-api-type: winrt method
---

<!-- Method syntax.
public LegacyGipGameControllerProvider LegacyGipGameControllerProvider.FromGameControllerProvider(IGameControllerProvider provider)
-->

# Windows.Gaming.Input.Preview.LegacyGipGameControllerProvider.FromGameControllerProvider

## -description

Constructs a [LegacyGipGameControllerProvider](legacygipgamecontrollerprovider.md) for the given controller provider.

## -parameters

### -param provider

Controller provider to construct a LegacyGipGameControllerProvider for.

## -returns

A LegacyGipGameControllerProvider if the controller is a GIP controller. Null if the controller is not a GIP controller.

## -remarks

## -examples

:::code language="csharp" source="code/csharp/HeadsetManagementSample.cs":::

## -see-also

[LegacyGipGameControllerProvider](legacygipgamecontrollerprovider.md)
