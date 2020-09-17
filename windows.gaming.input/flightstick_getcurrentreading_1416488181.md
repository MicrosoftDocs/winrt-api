---
-api-id: M:Windows.Gaming.Input.FlightStick.GetCurrentReading
-api-type: winrt method
---

<!-- Method syntax.
public FlightStickReading FlightStick.GetCurrentReading()
-->

# Windows.Gaming.Input.FlightStick.GetCurrentReading


## -description

Gets a snapshot of the flight stick state.

## -returns

The current state of the flight stick.

## -remarks

To gather input from a flight stick, you must *poll* the flight stick using this method. The method returns a **FlightStickReading** that has information about which buttons are being pressed, the joystick's roll, pitch, and yaw, and so on. See [Reading the flight stick](/windows/uwp/gaming/flight-stick#reading-the-flight-stick) for more information about how to read input from a flight stick.

## -see-also

[Windows.Gaming.Input.FlightStickReading](flightstickreading.md)

## -examples

