---
-api-id: M:Windows.Devices.Gpio.GpioChangeReader.Start
-api-type: winrt method
---

<!-- Method syntax.
public void GpioChangeReader.Start()
-->

# Windows.Devices.Gpio.GpioChangeReader.Start


## -description

Starts recording changes in pin polarity. This method may only be called when change recording is not already active.

## -remarks

Calling Start() may enable or reconfigure interrupts for the pin.

The following exceptions can be thrown by this method:

* HRESULT_FROM_WIN32(ERROR_BAD_COMMAND) - change reading is not currently active.
* HRESULT_FROM_WIN32(ERROR_INVALID_HANDLE) - the change reader or the associated pin has been disposed.

## -see-also

## -examples

