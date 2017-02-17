---
-api-id: P:Windows.Devices.Gpio.GpioChangeReader.Capacity
-api-type: winrt property
---

<!-- Property syntax.
public int Capacity { get; }
-->

# Windows.Devices.Gpio.GpioChangeReader.Capacity

## -description
Gets the maximum number of change records that the GpioChangeReader can store at one time.

## -property-value
The maximum number of change records.

## -remarks
When this maximum number of records is met, further changes will not be recorded and the [IsOverflowed](gpiochangereader_isoverflowed.md) property will return true.

## -see-also

## -examples

