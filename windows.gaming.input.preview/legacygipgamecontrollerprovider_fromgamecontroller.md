---
-api-id: M:Windows.Gaming.Input.Preview.LegacyGipGameControllerProvider.FromGameController(Windows.Gaming.Input.IGameController)
-api-type: winrt method
---

<!-- Method syntax.
public LegacyGipGameControllerProvider LegacyGipGameControllerProvider.FromGameController(IGameController controller)
-->

# Windows.Gaming.Input.Preview.LegacyGipGameControllerProvider.FromGameController

## -description

Constructs a [LegacyGipGameControllerProvider](legacygipgamecontrollerprovider.md) for the given controller.

## -parameters

### -param controller

Controller to construct a LegacyGipGameControllerProvider for.

## -returns

A LegacyGipGameControllerProvider if the controller is a GIP controller. Null if the controller is not a GIP controller.

## -remarks

## -examples

:::code language="csharp" source="code/csharp/EnumerateControllerPropertiesSample.cs":::

## -see-also

[LegacyGipGameControllerProvider](legacygipgamecontrollerprovider.md)
