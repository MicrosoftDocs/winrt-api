---
-api-id: P:Windows.Devices.Geolocation.Geolocator.DesiredAccuracy
-api-type: winrt property
---

<!-- Property syntax
public Windows.Devices.Geolocation.PositionAccuracy DesiredAccuracy { get;  set; }
-->

# Windows.Devices.Geolocation.Geolocator.DesiredAccuracy

## -description
The accuracy level at which the [Geolocator](geolocator.md) provides location updates.

## -property-value
The accuracy level at which the [Geolocator](geolocator.md) provides location updates.

## -remarks
Set DesiredAccuracy to **High** only if your application requires the most accurate data available. Set DesiredAccuracy to **Default** to optimize for power.



> [!NOTE]
> Some hardware may not support high accuracy location data. If your app attempts to set accuracy to a value that's not supported, accuracy will be set to the limit that the hardware supports. Therefore, setting the DesiredAccuracy property is not guaranteed to have an effect on the accuracy of data.

The [DesiredAccuracyInMeters](geolocator_desiredaccuracyinmeters.md) property provides more granularity and control of the accuracy of the position results. Most applications can simply use the DesiredAccuracy property.

When neither [DesiredAccuracyInMeters](geolocator_desiredaccuracyinmeters.md) nor DesiredAccuracy are set, your app will use an accuracy setting of 500 meters (which corresponds to the DesiredAccuracy setting of **Default**). Setting DesiredAccuracy to **Default** or **High** indirectly sets [DesiredAccuracyInMeters](geolocator_desiredaccuracyinmeters.md) to 500 or 10 meters, respectively. When your app sets both DesiredAccuracy and [DesiredAccuracyInMeters](geolocator_desiredaccuracyinmeters.md), your app will use whichever accuracy value was set last.

## -examples

The following example shows how to set the desired accuracy.

```csharp
Geolocator geolocator = new Geolocator();
geolocator.DesiredAccuracy = Windows.Devices.Geolocation.PositionAccuracy.Default;
geolocator.DesiredAccuracy = Windows.Devices.Geolocation.PositionAccuracy.High;
```

## -see-also


## -capabilities
location
ID_CAP_LOCATION [Windows Phone]
