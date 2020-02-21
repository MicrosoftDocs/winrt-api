---
-api-id: M:Windows.Devices.Gpio.GpioChangeCounter.Read
-api-type: winrt method
---

<!-- Method syntax.
public GpioChangeCount GpioChangeCounter.Read()
-->

# Windows.Devices.Gpio.GpioChangeCounter.Read


## -description

Reads the current count of polarity changes. Before counting has been started, this will return 0.

## -returns

A [GpioChangeCount](gpiochangecount.md) structure containing a count and an associated timestamp.

## -remarks

The following exception can be thrown by this method:

* HRESULT_FROM_WIN32(ERROR_INVALID_HANDLE) - the change counter or the associated pin has been disposed.

## -see-also

## -examples

