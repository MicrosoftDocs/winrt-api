---
-api-id: P:Windows.Media.Devices.RegionOfInterest.Bounds
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Rect Bounds { get;  set; }
-->

# Windows.Media.Devices.RegionOfInterest.Bounds

## -description
Gets or sets the rectangle that defines the region of focus.

## -property-value
The rectangle that defines the region of focus.

## -remarks
To specify a point with non-normalized coordinates, meaning the [BoundsNormalized](regionofinterest_boundsnormalized.md) property is not set or set to FALSE, you should specify a rectangle with width of 1 and height of 1.

To specify a point with normalized coordinates, meaning [BoundsNormalized](regionofinterest_boundsnormalized.md) is set to TRUE, you should specify a rectangle with width of FLT_EPSILON and height of FLT_EPSILON.

If the region of interest specified by the developer is smaller than what is supported by the hardware, the driver will default to the smallest supported rectangle possible that fully contains the specified region.

## -examples

## -see-also
