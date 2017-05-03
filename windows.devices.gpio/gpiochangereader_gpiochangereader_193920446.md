---
-api-id: M:Windows.Devices.Gpio.GpioChangeReader.#ctor(Windows.Devices.Gpio.GpioPin)
-api-type: winrt method
---

<!-- Method syntax.
public GpioChangeReader.GpioChangeReader(GpioPin pin)
-->

# Windows.Devices.Gpio.GpioChangeReader.GpioChangeReader

## -description
Creates a new GpioChangeReader associated with the specified pin. Only a single GpioChangeReader may be associated with a pin at any given time.

## -parameters

### -param pin
The pin on which to read changes. The pin must have been opened in Exclusive mode, and cannot be associated with another change reader.

## -remarks
The following exceptions can be thrown by this method:

* E_POINTER - The pin passed in is null.
* HRESULT_FROM_WIN32(ERROR_SHARING_VIOLATION) - The pin is already associated with a change reader. That change reader must be disposed before the pin can be associated with a new change reader.
* E_ACCESSDENIED - The pin is not opened in Exclusive mode.

## -see-also

## -examples

