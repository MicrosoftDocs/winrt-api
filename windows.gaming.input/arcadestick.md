---
-api-id: T:Windows.Gaming.Input.ArcadeStick
-api-type: winrt class
---

<!-- Class syntax.
public class ArcadeStick : Windows.Gaming.Input.IArcadeStick, Windows.Gaming.Input.IGameController
-->

# Windows.Gaming.Input.ArcadeStick

## -description

Represents an arcade stick.

## -remarks

Instances of the **ArcadeStick** class cannot be created directly; instead, instances of the class are retrieved through the [ArcadeStick.ArcadeSticks](arcadestick_arcadesticks.md) property listing all connected arcade sticks or through the [ArcadeStick.ArcadeStickAdded](arcadestick_arcadestickadded.md) event. See [Arcade stick](/windows/uwp/gaming/arcade-stick) for more information about how to use the **ArcadeStick** class.

### Supported Devices

**ArcadeStick** supports any GIP (Gaming Input Protocol) or XUSB arcade stick.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1703 | 15063 | FromGameController |
| 1703 | 15063 | TryGetBatteryReport |

## -examples

## -see-also

[Windows.Gaming.Input.IGameController](igamecontroller.md), [Arcade stick](/windows/uwp/gaming/arcade-stick), [Input practices for games](/windows/uwp/gaming/input-practices-for-games)
