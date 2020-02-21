---
-api-id: M:Windows.Devices.Gpio.GpioChangeCounter.Reset
-api-type: winrt method
---

<!-- Method syntax.
public GpioChangeCount GpioChangeCounter.Reset()
-->

# Windows.Devices.Gpio.GpioChangeCounter.Reset


## -description

Resets the count to 0 and returns the previous count.

## -returns

A [GpioChangeCount](gpiochangecount.md) structure containing a count and an associated timestamp.

## -remarks

The following exception can be thrown by this method:

* HRESULT_FROM_WIN32(ERROR_INVALID_HANDLE) - the change counter or the associated pin has been disposed.

## -see-also

## -examples

