---
-api-id: T:Windows.Devices.Gpio.GpioChangeReader
-api-type: winrt class
---

<!-- Class syntax.
public class GpioChangeReader : IClosable
-->

# Windows.Devices.Gpio.GpioChangeReader

## -description
Represents a shared circular buffer between kernel mode and user mode into which high-resolution timestamps are placed when a general-purpose I/O (GPIO) pin changes value.

## -remarks
Kernel mode places a timestamp into the buffer when a pin changes value, and user mode removes items from the buffer. An overflow occurs when there is no longer sufficient room in the buffer to place additional timestamps. Upon overflow, further events are not recorded, and the [IsOverflowed](gpiochangereader_isoverflowed.md) property will return true.

This class is not thread-safe. Calling functions of this class concurrently from multiple threads will have unpredictable results.

## -see-also

## -examples

