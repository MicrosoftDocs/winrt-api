---
-api-id: P:Windows.Devices.Gpio.Provider.IGpioPinProvider.DebounceTimeout
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.TimeSpan DebounceTimeout { get;  set; }
-->

# Windows.Devices.Gpio.Provider.IGpioPinProvider.DebounceTimeout

## -description
Gets or sets the debounce timeout for the general-purpose I/O (GPIO) pin, which is an interval during which changes to the value of the pin are filtered out and do not generate [ValueChanged](igpiopinprovider_valuechanged.md) events.

## -property-value
The debounce timeout for the GPIO pin, which is an interval during which changes to the value of the pin are filtered out and do not generate [ValueChanged](igpiopinprovider_valuechanged.md) events. If the length of this interval is 0, all changes to the value of the pin generate [ValueChanged](igpiopinprovider_valuechanged.md) events.

## -remarks

## -examples

## -see-also
