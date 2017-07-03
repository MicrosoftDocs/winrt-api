---
-api-id: M:Windows.Services.Maps.PlaceInfo.CreateFromIdentifier(System.String,Windows.Devices.Geolocation.Geopoint,Windows.Services.Maps.PlaceInfoCreateOptions)
-api-type: winrt method
---

<!-- Method syntax.
public PlaceInfo PlaceInfo.CreateFromIdentifier(String identifier, Geopoint defaultPoint, PlaceInfoCreateOptions options)
-->

# Windows.Services.Maps.PlaceInfo.CreateFromIdentifier

## -description
Creates a [PlaceInfo](placeinfo.md) instance.

## -parameters
### -param identifier
The identifier of the location.

### -param defaultPoint
The geographic map location that you want to show in a light-dismissible window.
>[!Note]
This value is used only if the identifier is invalid, the device is offline, or the details of the place can't be obtained by using the identifier.

### -param options
The optional information that describes this location. This information will appear in the light-dismissible window.
>[!Note]
This value is used only if the identifier is invalid, the device is offline, or the details of the place can't be obtained by using the identifier.

## -returns
A [PlaceInfo](placeinfo.md) instance that describes the location.

## -remarks

## -see-also

## -examples
