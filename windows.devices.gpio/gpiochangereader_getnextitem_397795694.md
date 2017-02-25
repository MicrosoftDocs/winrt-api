---
-api-id: M:Windows.Devices.Gpio.GpioChangeReader.GetNextItem
-api-type: winrt method
---

<!-- Method syntax.
public GpioChangeRecord GpioChangeReader.GetNextItem()
-->

# Windows.Devices.Gpio.GpioChangeReader.GetNextItem

## -description
Retrieves and removes the earliest inserted change record from the reader's buffer.

## -parameters

## -returns
[GpioChangeRecord](gpiochangerecord.md)

A structure containing the timestamp and polarity (rising or falling) of the change.

## -remarks
This will also reset an active overflow condition, causing the [IsOverflowed](gpiochangereader_isoverflowed.md) property to return false.

## -see-also

## -examples

