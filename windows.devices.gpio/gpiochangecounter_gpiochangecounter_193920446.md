---
-api-id: M:Windows.Devices.Gpio.GpioChangeCounter.#ctor(Windows.Devices.Gpio.GpioPin)
-api-type: winrt method
---

<!-- Method syntax.
public GpioChangeCounter.GpioChangeCounter(GpioPin pin)
-->

# Windows.Devices.Gpio.GpioChangeCounter.GpioChangeCounter

## -description
Creates a new GpioChangeCounter associated with the specified pin. Only a single GpioChangeCounter may be associated with a pin at any given time.

## -parameters

### -param pin
The pin on which to count changes. This pin must have been opened in Exclusive mode, and cannot be associated with another GpioChangeCounter.

## -remarks

The following exceptions can be thrown by this method:

* E_POINTER - The pin passed in is null.
* HRESULT_FROM_WIN32(ERROR_SHARING_VIOLATION) - The pin is already associated with a change counter. That change counter must be disposed before the pin can be associated with a new change counter.
* E_ACCESSDENIED - The pin is not opened in Exclusive mode.

## -see-also

## -examples

