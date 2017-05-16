---
-api-id: M:Windows.Devices.Gpio.GpioController.OpenPin(System.Int32,Windows.Devices.Gpio.GpioSharingMode)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Devices.Gpio.GpioPin OpenPin(System.Int32 pinNumber, Windows.Devices.Gpio.GpioSharingMode sharingMode)
-->

# Windows.Devices.Gpio.GpioController.OpenPin

## -description
Opens the specified general-purpose I/O (GPIO) pin in the specified mode.

## -parameters
### -param pinNumber
The pin number of the GPIO pin that you want to open. The pin number must be
+ in range
+ available to usermode applications


Pin numbers start at 0, and increase to the maximum pin number, which is one less than the value returned by [GpioController.PinCount](gpiocontroller_pincount.md).

Which pins are available to usermode depends on the circuit board on which the code is running. For information about how pin numbers correspond to physical pins, see the documentation for your circuit board. Pin mappings for boards such as the Raspberry Pi are available at the [IoT developer center](https://developer.microsoft.com/en-us/windows/iot/).

### -param sharingMode
The mode in which you want to open the GPIO pin, which determines whether other connections to the pin can be opened while you have the pin open.

## -returns
The opened GPIO pin.

## -remarks

#### Error Codes
##### E_INVALIDARG  (0x80070057)

An invalid parameter was specified. This error will be returned if the pin number is out of range. Pin numbers start at 0 and increase to the maximum pin number, which is one less than the value returned by [GpioController.PinCount](gpiocontroller_pincount.md).

##### HRESULT_FROM_WIN32(ERROR_NOT_FOUND) (0x80070490)

The pin is not available to usermode applications; it is reserved by the system. See the documentation for your circuit board to find out which pins are available to usermode applications.

##### HRESULT_FROM_WIN32(ERROR_SHARING_VIOLATION) (0x80070020)

The pin is currently open in an incompatible sharing mode. For example:


+ The pin is already open in **GpioSharingMode.Exclusive** mode.
+ The pin is already open in **GpioSharingMode.SharedReadOnly** mode when you request to open it in **GpioSharingMode.Exclusive** mode.


##### HRESULT_FROM_WIN32(ERROR_GPIO_INCOMPATIBLE_CONNECT_MODE) (0x80073bde)

The pin is currently muxed to a different function; for example I2C, SPI, or UART. Ensure the pin is not in use by another function.

##### HRESULT_FROM_WIN32(ERROR_GEN_FAILURE) (0x8007001f)

The GPIO driver returned an error. Ensure that the GPIO driver is running and configured correctly.

## -examples

## -see-also
[OpenPin(Int32)](gpiocontroller_openpin_1000658948.md), [GpioPin.Close](gpiopin_close.md), [GpioSharingMode](gpiosharingmode.md), [TryOpenPin](gpiocontroller_tryopenpin.md)