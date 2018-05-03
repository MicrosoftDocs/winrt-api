---
-api-id: M:Windows.Devices.Gpio.GpioPin.IsDriveModeSupported(Windows.Devices.Gpio.GpioPinDriveMode)
-api-type: winrt method
---

<!-- Method syntax
public bool IsDriveModeSupported(Windows.Devices.Gpio.GpioPinDriveMode driveMode)
-->

# Windows.Devices.Gpio.GpioPin.IsDriveModeSupported

## -description
Gets whether the general-purpose I/O (GPIO) pin supports the specified drive mode.

## -parameters
### -param driveMode
The drive mode that you want to check for support.

## -returns
True if the GPIO pin supports the drive mode that *driveMode* specifies; otherwise false. If you specify a drive mode for which this method returns false when you call [SetDriveMode](gpiopin_setdrivemode.md), [SetDriveMode](gpiopin_setdrivemode.md) generates an exception.

## -remarks

## -examples

## -see-also
[GpioPinDriveMode](gpiopindrivemode.md), [GetDriveMode](gpiopin_getdrivemode.md), [SetDriveMode](gpiopin_setdrivemode.md)

## -capabilities
&lt;DeviceCapability name="lowLevel" /&gt;
