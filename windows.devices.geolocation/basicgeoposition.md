---
-api-id: T:Windows.Devices.Geolocation.BasicGeoposition
-api-type: winrt struct
---

<!-- Structure syntax.
public struct BasicGeoposition 
-->

# BasicGeoposition

## -description
The basic information to describe a geographic position.

## -struct-fields

### -field Latitude
The latitude of the geographic position. The valid range of latitude values is from -90.0 to 90.0 degrees.
    

### -field Longitude
The longitude of the geographic position. This can be any value. For values less than or equal to-180.0 or values greater than 180.0, the value may be wrapped and stored appropriately before it is used. For example, a longitude of 183.0 degrees would become -177.0 degrees.
    

### -field Altitude
The altitude of the geographic position in meters.
    

## -remarks

## -examples

## -see-also