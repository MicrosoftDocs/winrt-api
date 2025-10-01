---
-api-id: P:Windows.Devices.Geolocation.GeocoordinateSatelliteData.GeometricDilutionOfPrecision
-api-type: winrt property
---

# Windows.Devices.Geolocation.GeocoordinateSatelliteData.GeometricDilutionOfPrecision

<!--
public System.Nullable<double> GeometricDilutionOfPrecision { get; }
-->


## -description

Gets the geometric dilution of precision (GDOP) of a [Geocoordinate](geocoordinate.md).

## -property-value

The geometric dilution of precision (GDOP) value, or `null` if the GNSS receiver returns zero for this measurement.

## -remarks

Geometric dilution of precision (GDOP) indicates the overall satellite geometry quality for position determination. GDOP
combines the effects of satellite positioning on horizontal, vertical, and time accuracy into a single metric that
reflects positioning confidence.

GDOP is a unitless multiplier; the approximate position error equals the GDOP value multiplied by the underlying range error
from satellite measurements. For interpretation ranges and contributing factors (satellite geometry, satellite count and
distribution, elevation, constellation changes), consult standard GNSS references. This API exposes the raw value so
applications can apply scenario-appropriate thresholds without duplicating broadly available GNSS domain material.

### Application guidance

- Critical applications (navigation, emergency services) should prefer lower GDOP values when selecting a position fix.
- Multiple readings can help validate positions when GDOP values are elevated or fluctuating.
- Monitor GDOP trends - rapidly changing values may indicate unstable satellite geometry and justify discarding a fix.

> [!IMPORTANT]
> This property returns `null` if the GNSS receiver returns a zero value for GDOP, indicating the measurement is not
> available. This commonly occurs during initial GNSS acquisition or when insufficient satellites are available for
> positioning.

> [!TIP]
> For applications requiring consistent accuracy, consider combining GDOP monitoring with other satellite data properties
> like the number of satellites in view to make informed decisions about position reliability.

## -examples

## -see-also

[GeocoordinateSatelliteData](geocoordinatesatellitedata.md),
[PositionDilutionOfPrecision](geocoordinatesatellitedata_positiondilutionofprecision.md),
[TimeDilutionOfPrecision](geocoordinatesatellitedata_timedilutionofprecision.md)
