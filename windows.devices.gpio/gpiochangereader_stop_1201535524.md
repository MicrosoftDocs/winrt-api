---
-api-id: M:Windows.Devices.Gpio.GpioChangeReader.Stop
-api-type: winrt method
---

<!-- Method syntax.
public void GpioChangeReader.Stop()
-->

# Windows.Devices.Gpio.GpioChangeReader.Stop


## -description

Stop recording changes in pin polarity. This method may only be called when change recording is currently active.

## -remarks

Calling Stop() may disable or reconfigure interrupts for the pin.

The following exceptions can be thrown by this method:

* HRESULT_FROM_WIN32(ERROR_BAD_COMMAND) - change reading has already been started.
* HRESULT_FROM_WIN32(ERROR_INVALID_HANDLE) - the change reader or the associated pin has been disposed.

## -see-also

## -examples

