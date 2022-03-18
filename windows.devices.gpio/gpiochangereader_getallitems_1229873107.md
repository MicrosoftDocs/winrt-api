---
-api-id: M:Windows.Devices.Gpio.GpioChangeReader.GetAllItems
-api-type: winrt method
---

<!-- Method syntax.
public IVector<GpioChangeRecord> GpioChangeReader.GetAllItems()
-->

# Windows.Devices.Gpio.GpioChangeReader.GetAllItems


## -description

Removes and returns all items current in the reader's buffer.

## -returns

IVector<[GpioChangeRecord](gpiochangerecord.md)>

The returned vector enables random access to all the change records removed from the buffer.

## -remarks

This will also reset an active overflow condition, causing the [IsOverflowed](gpiochangereader_isoverflowed.md) property to return false.

## -see-also

## -examples

