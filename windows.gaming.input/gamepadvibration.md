---
-api-id: T:Windows.Gaming.Input.GamepadVibration
-api-type: winrt struct
---

<!-- Structure syntax.
public struct GamepadVibration 
-->

# GamepadVibration

## -description
Describes the speed of the gamepad's four available vibration motors.

## -struct-fields

### -field LeftMotor
The level of the left vibration motor. Valid values are between 0.0 and 1.0, where 0.0 signifies no motor use and 1.0 signifies max vibration.
    

### -field RightMotor
The level of the right vibration motor. Valid values are between 0.0 and 1.0, where 0.0 signifies no motor use and 1.0 signifies max vibration.
    

### -field LeftTrigger
The left trigger vibration level. Valid values are between 0.0 and 1.0, where 0.0 signifies no motor use and 1.0 signifies max vibration.
    

### -field RightTrigger
The right trigger vibration level. Valid values are between 0.0 and 1.0, where 0.0 signifies no motor use and 1.0 signifies max vibration.
    

## -remarks
Note that on devices with fewer motors, four vibration motor speed values are combined by the driver in a way that gives the best possible approximation of the haptic feedback you'd get on a controller that has all four motors.

## -examples

## -see-also