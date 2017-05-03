---
-api-id: M:Windows.Devices.Gpio.GpioChangeReader.#ctor(Windows.Devices.Gpio.GpioPin,System.Int32)
-api-type: winrt method
---

<!-- Method syntax.
public GpioChangeReader.GpioChangeReader(GpioPin pin, Int32 minCapacity)
-->

# Windows.Devices.Gpio.GpioChangeReader.GpioChangeReader

## -description
Creates a new GpioChangeReader associated with the specified pin and with the specified minimum capacity for change records. Only a single GpioChangeReader may be associated with a pin at any given time.

## -parameters

### -param pin
The pin on which to read changes. The pin must have been opened in Exclusive mode, and cannot be associated with another change reader.

### -param minCapacity
The minimum number of change records that the reader must be able to hold.

## -remarks

## -see-also

## -examples

