---
-api-id: M:Windows.Gaming.Input.Preview.LegacyGipGameControllerProvider.FromGameController(Windows.Gaming.Input.IGameController)
-api-type: winrt method
---

# Windows.Gaming.Input.Preview.LegacyGipGameControllerProvider.FromGameController(Windows.Gaming.Input.IGameController)

<!--
public static Windows.Gaming.Input.Preview.LegacyGipGameControllerProvider FromGameController (Windows.Gaming.Input.IGameController controller);
-->

## -description

Constructs a [LegacyGipGameControllerProvider](legacygipgamecontrollerprovider.md) for the given controller.

## -parameters

### -param controller

Controller to construct a LegacyGipGameControllerProvider for.

## -returns

A LegacyGipGameControllerProvider if the controller is a GIP (Gaming Input Protocol) controller. Null if the controller is not a GIP controller.

## -remarks

## -see-also

[LegacyGipGameControllerProvider](legacygipgamecontrollerprovider.md)

## -examples

:::code language="csharp" source="code/csharp/EnumerateControllerPropertiesSample.cs":::
