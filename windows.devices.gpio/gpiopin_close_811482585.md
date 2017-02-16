---
-api-id: M:Windows.Devices.Gpio.GpioPin.Close
-api-type: winrt method
---

<!-- Method syntax
public void Close()
-->

# Windows.Devices.Gpio.GpioPin.Close

## -description
Closes the general-purpose I/O (GPIO) pin and releases the resources associated with it.

## -remarks
You cannot call [Close](../windows.foundation/iclosable_close.md) methods through Visual C++ component extensions (C++/CX) on Windows Runtime class instances where the class implemented [IClosable](../windows.foundation/iclosable.md). Instead, Visual C++ component extensions (C++/CX) code for runtime classes should call the destructor or set the last reference to **null**.

## -examples

## -see-also
[GpioController.OpenPin](gpiocontroller_openpin.md)