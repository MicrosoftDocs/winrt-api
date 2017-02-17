---
-api-id: P:Windows.Devices.Gpio.GpioChangeReader.IsOverflowed
-api-type: winrt property
---

<!-- Property syntax.
public bool IsOverflowed { get; }
-->

# Windows.Devices.Gpio.GpioChangeReader.IsOverflowed

## -description
Gets whether an attempt to place a change record into the reader's buffer has failed due to the buffer being full.

## -property-value
Returns true if an attempt at placement has been unsuccessful, and false otherwise.

## -remarks
Removing an item from the buffer will cause IsOverflowed to reset to false.

## -see-also

## -examples

