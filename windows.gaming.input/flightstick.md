---
-api-id: T:Windows.Gaming.Input.FlightStick
-api-type: winrt class
---

<!-- Class syntax.
public class FlightStick : IGameController, IGameControllerBatteryInfo
-->

# Windows.Gaming.Input.FlightStick

## -description

Represents a flight stick.

## -remarks

**FlightStick** is targeted at simple, arcade-style flight games. It provides several basic inputs, which are derived from the lowest common denominator of inputs available across the majority of popular flight stick devices. These inputs include:

* Two buttons for firing primary and secondary weapons.
* A hat switch for camera view and/or target selection.
* Axis data for pitch, roll, yaw, and throttle position.

Instances of the **FlightStick** class cannot be created directly; instead, instances of the class are retrieved through the [FlightStick.FlightSticks](flightstick_flightsticks.md) property listing all connected flight sticks or through the [FlightStick.FlightStickAdded](flightstick_flightstickadded.md) event.

See [Flight stick](https://docs.microsoft.com/windows/uwp/gaming/flight-stick) for more information about how to use the **FlightStick** class.

### Supported Devices

**FlightStick** supports any Xbox One-certified or Xbox 360-compatible flight stick.

## -see-also

* [Flight stick](https://docs.microsoft.com/windows/uwp/gaming/flight-stick)
* [Windows.Gaming.Input.IGameController interface](igamecontroller.md)
* [Windows.Gaming.Input.IGameControllerBatteryInfo interface](igamecontrollerbatteryinfo.md)

## -examples

