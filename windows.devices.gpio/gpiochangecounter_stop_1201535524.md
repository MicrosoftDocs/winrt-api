---
-api-id: M:Windows.Devices.Gpio.GpioChangeCounter.Stop
-api-type: winrt method
---

<!-- Method syntax.
public void GpioChangeCounter.Stop()
-->

# Windows.Devices.Gpio.GpioChangeCounter.Stop


## -description

Stop counting changes in pin polarity. This method may only be called when change counting is currently active.

## -remarks

Calling Stop() may disable or reconfigure interrupts for the pin.

The following exceptions can be thrown by this method:

* HRESULT_FROM_WIN32(ERROR_BAD_COMMAND) - change counting is not currently active.
* HRESULT_FROM_WIN32(ERROR_INVALID_HANDLE) - the change counter or the associated pin has been disposed.

## -see-also

## -examples

