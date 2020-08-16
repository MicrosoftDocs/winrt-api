---
-api-id: T:Windows.Devices.Gpio.GpioChangeCount
-api-type: winrt struct
---

<!-- Structure syntax.
public struct GpioChangeCount  {
	public ulong Count 
	public TimeSpan RelativeTime 
}
-->

# Windows.Devices.Gpio.GpioChangeCount

## -description
Represents a near-simultaneous sampling of the number of times a pin has changed value, and the time at which this count was sampled. This structure can be used to determine the number of pin value changes over a period of time.

## -struct-fields

### -field Count
The number of times the transition of polarity specified by [GpioChangeCounter.Polarity](gpiochangecounter_polarity.md) occurred on the pin.

### -field RelativeTime
The time at which this count was sampled. The time is sampled close to (but not simultaneously with) the count. This timestamp can be used to determine the elapsed time between two GpioChangeCount records. It does not correspond to any absolute or system time.

## -remarks

## -see-also

## -examples

