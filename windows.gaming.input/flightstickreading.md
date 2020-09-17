---
-api-id: T:Windows.Gaming.Input.FlightStickReading
-api-type: winrt structure
---

<!-- Structure syntax.
public struct FlightStickReading  {
    public FlightStickButtons Buttons 
    public GameControllerSwitchPosition HatSwitch 
    public double Pitch 
    public double Roll 
    public double Throttle 
    public ulong Timestamp 
    public double Yaw 
}
-->

# Windows.Gaming.Input.FlightStickReading

## -description

The current state of the flight stick.

## -struct-fields

### -field Buttons

The button currently being pressed.

### -field HatSwitch

The position of the hat switch.

### -field Pitch

The amount of pitch (rotation around the X-axis; forward and backward movement on the flight stick).

### -field Roll

The amount of roll (rotation around the Z-axis; left and right movement on the flight stick).

### -field Throttle

The position of the throttle.

### -field Timestamp

The time that the reading was reported from the hardware.

### -field Yaw

The amount of yaw (rotation around the Y-axis; usually read from twisting the joystick or from some other input).

## -remarks

For information about how to process the information provided in this structure, see [Flight stick](/windows/uwp/gaming/flight-stick).

## -see-also

[Windows.Gaming.Input.FlightStickButtons](flightstickbuttons.md), [Windows.Gaming.Input.GameControllerSwitchPosition](gamecontrollerswitchposition.md), [Windows.Gaming.Input.FlightStick](flightstick.md)

## -examples
