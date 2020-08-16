---
-api-id: P:Windows.Devices.Gpio.GpioPin.DebounceTimeout
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.TimeSpan DebounceTimeout { get;  set; }
-->

# Windows.Devices.Gpio.GpioPin.DebounceTimeout

## -description
Gets or sets the debounce timeout for the general-purpose I/O (GPIO) pin, which is an interval during which changes to the value of the pin are filtered out, and do not generate [ValueChanged](gpiopin_valuechanged.md) events.

## -property-value
The debounce timeout (of type [TimeSpan](/uwp/api/windows.foundation.timespan)) for the GPIO pin. If the length of this interval is 0, then all changes to the value of the pin generate [ValueChanged](gpiopin_valuechanged.md) events.

## -remarks

## -examples

## -see-also
[ValueChanged](gpiopin_valuechanged.md)

## -capabilities
lowLevel