---
-api-id: M:Windows.Devices.Gpio.GpioPin.SetDriveMode(Windows.Devices.Gpio.GpioPinDriveMode)
-api-type: winrt method
---

<!-- Method syntax
public void SetDriveMode(Windows.Devices.Gpio.GpioPinDriveMode value)
-->

# Windows.Devices.Gpio.GpioPin.SetDriveMode

## -description
Sets the drive mode of the general-purpose I/O (GPIO) pin. The drive mode specifies whether the pin is configured as an input or an output, and determines how values are driven onto the pin.

## -parameters
### -param value
An enumeration value that specifies drive mode to use for the GPIO pin. The drive mode specifies whether the pin is configured as an input or an output, and determines how values are driven onto the pin.

## -remarks
The following exceptions can be thrown by this method:

### E_INVALIDARG

The GPIO pin does not support the specified drive mode.

### E_ACCESSDENIED

The pin is open in shared read-only mode. Close the pin and reopen it in exclusive mode to change the drive mode of the pin.

## -examples

## -see-also
[GpioPinDriveMode](gpiopindrivemode.md), [GpioPin.GetDriveMode](gpiopin_getdrivemode.md)

## -capabilities
&lt;DeviceCapability name="lowLevel" /&gt;
