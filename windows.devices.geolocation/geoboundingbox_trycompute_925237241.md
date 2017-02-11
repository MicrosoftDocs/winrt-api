---
-api-id: M:Windows.Devices.Geolocation.GeoboundingBox.TryCompute(Windows.Foundation.Collections.IIterable{Windows.Devices.Geolocation.BasicGeoposition},Windows.Devices.Geolocation.AltitudeReferenceSystem,System.UInt32)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Devices.Geolocation.GeoboundingBox TryCompute(Windows.Foundation.Collections.IIterable<Windows.Devices.Geolocation.BasicGeoposition> positions, Windows.Devices.Geolocation.AltitudeReferenceSystem altitudeRefSystem, System.UInt32 spatialReferenceId)
-->

# Windows.Devices.Geolocation.GeoboundingBox.TryCompute

## -description
Calculates a [GeoboundingBox](geoboundingbox.md) that contains the specified set of geographic positions and uses the specified altitude reference system and spatial reference ID (SRID).

## -parameters
### -param positions
A collection of geographic positions to include inside the [GeoboundingBox](geoboundingbox.md).

### -param altitudeRefSystem
The altitude reference system to use for the [GeoboundingBox](geoboundingbox.md). For more info, see the [AltitudeReferenceSystem](geoboundingbox_altitudereferencesystem.md) property.

### -param spatialReferenceId
The spatial reference ID (SRID) to use for the [GeoboundingBox](geoboundingbox.md). For more info, see the [SpatialReferenceId](geoboundingbox_spatialreferenceid.md) property.

## -returns
The calculated rectangle that contains the specified set of geographic positions.

## -remarks

## -examples

## -see-also
[TryCompute(IIterable(BasicGeoposition))](geoboundingbox_trycompute_467892569.md), [TryCompute(IIterable(BasicGeoposition), AltitudeReferenceSystem)](geoboundingbox_trycompute_952878109.md)