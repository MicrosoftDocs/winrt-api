---
-api-id: T:Windows.Devices.Gpio.GpioOpenStatus
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Devices.Gpio.GpioOpenStatus : int
-->

# GpioOpenStatus

## -description
Describes the possible results of opening a pin with the [GpioPin.TryOpenPin](gpiocontroller_tryopenpin.md) method.

## -enum-fields
### -field PinOpened:0
The GPIO pin was successfully opened.

### -field PinUnavailable:1
The pin is reserved by the system and is not available to apps that run in user mode.

### -field SharingViolation:2
The pin is currently open in an incompatible sharing mode. For example:


+ The pin is already open in **GpioSharingMode.Exclusive** mode.
+ The pin is already open in **GpioSharingMode.SharedReadOnly** mode when you request to open it in **GpioSharingMode.Exclusive** mode.



### -field MuxingConflict:3
The pin is currently opened for a different function, such as **I2c**, **Spi**, or **UART**. Ensure the pin is not in use by another function.

### -field UnknownError:4
The pin could not be opened.

## -remarks

## -examples

## -see-also
[GpioController.TryOpenPin](gpiocontroller_tryopenpin.md), [GpioSharingMode](gpiosharingmode.md)

