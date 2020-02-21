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

## -returns

A [GpioChangeRecord](gpiochangerecord.md) structure containing the timestamp and polarity (rising or falling) of the change.

## -remarks

This will also reset an active overflow condition, causing the [IsOverflowed](gpiochangereader_isoverflowed.md) property to return false.

The following exception can be thrown by this method:

* HRESULT_FROM_WIN32(ERROR_NO_MORE_ITEMS) - the reader's buffer is empty.

## -see-also

## -examples

