---
-api-id: M:Windows.Devices.Gpio.GpioChangeReader.PeekNextItem
-api-type: winrt method
---

<!-- Method syntax.
public GpioChangeRecord GpioChangeReader.PeekNextItem()
-->

# Windows.Devices.Gpio.GpioChangeReader.PeekNextItem


## -description

Retrieves the earlier inserted change record from the reader's buffer, without removing it.

## -returns

A [GpioChangeRecord](gpiochangerecord.md) structure containing the timestamp and polarity (rising or falling) of the change.

## -remarks

The following exception can be thrown by this method:

* HRESULT_FROM_WIN32(ERROR_NO_MORE_ITEMS) - the reader's buffer is empty.

## -see-also

## -examples

