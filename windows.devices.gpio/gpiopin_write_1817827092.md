---
-api-id: M:Windows.Devices.Gpio.GpioPin.Write(Windows.Devices.Gpio.GpioPinValue)
-api-type: winrt method
---

<!-- Method syntax
public void Write(Windows.Devices.Gpio.GpioPinValue value)
-->

# Windows.Devices.Gpio.GpioPin.Write

## -description
Drives the specified value onto the general purpose I/O (GPIO) pin according to the current drive mode for the pin if the pin is configured as an output, or updates the latched output value for the pin if the pin is configured as an input.

## -parameters
### -param value
The enumeration value to write to the GPIO pin.

If the GPIO pin is configured as an output, the method drives the specified value onto the pin according to the current drive mode for the pin.

If the GPIO pin is configured as an input, the method updates the latched output value for the pin. The latched output value is driven onto the pin when the configuration for the pin changes to output.

## -remarks
The following exceptions can be thrown by this method:

### E_ACCESSDENIED

The GPIO pin is open in shared read-only mode. To write to the pin, close the pin and reopen the pin in exclusive mode.

## -examples

## -see-also
[GpioPinValue](gpiopinvalue.md), [GpioPin.Read](gpiopin_read.md)

## -capabilities
&lt;DeviceCapability name="lowLevel" /&gt;
