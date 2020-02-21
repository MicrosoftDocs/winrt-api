---
-api-id: M:Windows.Devices.Gpio.GpioChangeCounter.Start
-api-type: winrt method
---

<!-- Method syntax.
public void GpioChangeCounter.Start()
-->

# Windows.Devices.Gpio.GpioChangeCounter.Start


## -description

Starts counting changes in pin polarity. This method may only be called when change counting is not already active.

## -remarks

Calling Start() may enable or reconfigure interrupts for the pin.

The following exceptions can be thrown by this method:

* HRESULT_FROM_WIN32(ERROR_BAD_COMMAND) - change counting has already been started.
* HRESULT_FROM_WIN32(ERROR_INVALID_HANDLE) - the change counter or the associated pin has been disposed.

## -see-also

## -examples

