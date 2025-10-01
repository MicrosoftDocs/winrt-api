---
-api-id: P:Windows.Devices.Geolocation.GeocoordinateSatelliteData.TimeDilutionOfPrecision
-api-type: winrt property
---

# Windows.Devices.Geolocation.GeocoordinateSatelliteData.TimeDilutionOfPrecision

<!--
public System.Nullable<double> TimeDilutionOfPrecision { get; }
-->


## -description

Gets the time dilution of precision (TDOP) of a [Geocoordinate](geocoordinate.md).

## -property-value

The time dilution of precision (TDOP) value, or `null` if the GNSS receiver returns zero for this measurement.

## -remarks

Time dilution of precision indicates how satellite geometry affects the accuracy of time measurements used in GNSS position
calculations. TDOP specifically measures the effect of satellite positioning on clock bias estimation.

> [!NOTE]
> Lower TDOP values indicate more accurate time synchronization with GNSS satellites, which directly impacts position
> accuracy. Values of 5 or less are considered reliable, while values higher than 10 indicate low confidence and should
> generally be used only for rough position estimation.

> [!IMPORTANT]
> This property returns `null` if the GNSS receiver returns a zero value for TDOP, indicating the measurement is not
> available.

## -examples

## -see-also

[GeocoordinateSatelliteData](geocoordinatesatellitedata.md),
[GeometricDilutionOfPrecision](geocoordinatesatellitedata_geometricdilutionofprecision.md),
[PositionDilutionOfPrecision](geocoordinatesatellitedata_positiondilutionofprecision.md)
