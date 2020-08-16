---
-api-id: M:Windows.Devices.Gpio.GpioController.TryOpenPin(System.Int32,Windows.Devices.Gpio.GpioSharingMode,Windows.Devices.Gpio.GpioPin@,Windows.Devices.Gpio.GpioOpenStatus@)
-api-type: winrt method
---

<!-- Method syntax
public bool TryOpenPin(System.Int32 pinNumber, Windows.Devices.Gpio.GpioSharingMode sharingMode, Windows.Devices.Gpio.GpioPin pin, Windows.Devices.Gpio.GpioOpenStatus openStatus)
-->

# Windows.Devices.Gpio.GpioController.TryOpenPin

## -description
Opens the specified general-purpose I/O (GPIO) pin in the specified mode, and gets a status value that you can use to handle a failure to open the pin programmatically.

## -parameters
### -param pinNumber
The pin number of the GPIO pin that you want to open. Some pins may not be available in user mode. For information about how the pin numbers correspond to physical pins, see the documentation for your circuit board.

### -param sharingMode
The mode in which you want to open the GPIO pin, which determines whether other connections to the pin can be opened while you have the pin open.

### -param pin
The opened GPIO pin if the return value is true; otherwise null.

### -param openStatus
An enumeration value that indicates either that the attempt to open the GPIO pin succeeded, or the reason that the attempt to open the GPIO pin failed.

## -returns
True if the method successfully opened the pin; otherwise false.

If the method returns true, the *pin* parameter receives an instance of a [GpioPin](gpiopin.md), and the *openStatus* parameter receives **GpioOpenStatus.PinOpened**. If the method returns false, the *pin* parameter is null and the *openStatus* parameter receives the reason that the operation failed.

## -remarks

## -examples

## -see-also
[OpenPin](gpiocontroller_openpin_1000658948.md), [GpioOpenStatus](gpioopenstatus.md)

## -capabilities
lowLevel
