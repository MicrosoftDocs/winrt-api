---
-api-id: T:Windows.Devices.Gpio.GpioChangeRecord
-api-type: winrt struct
---

<!-- Structure syntax.
public struct GpioChangeRecord  {
	public GpioPinEdge Edge 
	public TimeSpan RelativeTime 
}
-->

# Windows.Devices.Gpio.GpioChangeRecord

## -description
Stores a relative timestap of a general-purpose I/O (GPIO) pin value change, and whether the pin transitioned from low to high or from high to low.

## -struct-fields

### -field Edge
A [GpioPinEdge](gpiopinedge.md) object corresponding to the transition type.

### -field RelativeTime
A relative timestamp that can be used to determine the difference in time between two change records. This timestamp does not correspond to any absolute or system time.

## -remarks

## -see-also

## -examples

