---
-api-id: T:Windows.Devices.Gpio.GpioChangeCounter
-api-type: winrt class
---

<!-- Class syntax.
public class GpioChangeCounter : IClosable
-->

# Windows.Devices.Gpio.GpioChangeCounter

## -description
Counts changes of a specified polarity on a general-purpose I/O (GPIO) pin.

## -remarks
When the pin is an input, interrupts are used to detect pin changes. Interrupts for the pin are enabled for the specified polarity, and the count is incremented when an interrupt occurs.

When the pin is an output, the count will increment whenever the specified transition occurs on the pin. For example, if the pin is configured as an output and counting is enabled for rising edges, writing a 0 and then a 1 will cause the count to be incremented.

## -see-also

## -examples

