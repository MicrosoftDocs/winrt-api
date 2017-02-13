---
-api-id: P:Windows.Devices.Geolocation.Geocoordinate.PositionSourceTimestamp
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.IReference<Windows.Foundation.DateTime> PositionSourceTimestamp { get; }
-->

# Windows.Devices.Geolocation.Geocoordinate.PositionSourceTimestamp

## -description
Gets the time at which the associated [Geocoordinate](geocoordinate.md) position was calculated.

## -property-value
The time at which the associated [Geocoordinate](geocoordinate.md) position was calculated.

## -remarks
When this property is not available, the value will be **NULL**.

The timestamp returned by this property depends on how the location was obtained and may be completely unrelated to the system time on the device. For example, if the position is obtained from the Global Navigation Satellite System (GNSS) the timestamp would be obtained from the satellites. If the position was is obtained from Secure User Plane Location (SUPL), the timestamp would be obtained from SUPL servers. This means that the timestamps obtained from these services will be precise and, most importantly, consistent across all devices regardless of whether the system time on the devices is set correctly.

## -examples

## -see-also
