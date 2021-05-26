---
-api-id: P:Windows.Media.Devices.DigitalWindowCapability.NormalizedFieldOfViewLimit
-api-type: winrt property
---

# Windows.Media.Devices.DigitalWindowCapability.NormalizedFieldOfViewLimit

<!--
public Windows.Foundation.Rect NormalizedFieldOfViewLimit { get; }
-->


## -description

Gets a normalized rectangle representing the field of view limit of the capture device.

## -property-value

A rectangle with normalized values.

## -remarks

Since the digital window field of view is a subset of the field of view that the sensor can see, these values are likely to be outside the bounds of 0 and 1, for example (-.5, -.5, 1.5, 1.5).

## -see-also

## -examples


