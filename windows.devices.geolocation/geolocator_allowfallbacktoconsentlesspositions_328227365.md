---
-api-id: M:Windows.Devices.Geolocation.Geolocator.AllowFallbackToConsentlessPositions
-api-type: winrt method
---

<!-- Method syntax
public void AllowFallbackToConsentlessPositions()
-->

# Windows.Devices.Geolocation.Geolocator.AllowFallbackToConsentlessPositions

## -description
Sets the [Geolocator](geolocator.md) to use coarse location as a fallback option (see Remarks).

## -remarks
The coarse location feature allows the app to bypass the app-specific location switch (located in system settings) and obtain a "rough" location that is obfuscated with at least a 4km radius of uncertainty. The [PositionSource](geocoordinate_positionsource.md) property of the retrieved [Geocoordinate](geocoordinate.md) will evaluate to **Obfuscated**.

Coarse location, if enabled in the app, will be utilized when the app-specific location switch is set to **off** (that is, when precise location is not allowed). The system-wide location switch, however, must be still switched **on** in order for any location retrieval to take place.

This feature is enabled for any [Geolocator](geolocator.md) object that calls AllowFallbackToConsentlessPositions. It is disabled by default.

Normally, an app that uses location services should first call [RequestAccessAsync](geolocator_requestaccessasync_380675631.md) to check if its app-specific location is switched **on**, and if not, it should prompt the user to go to system settings and switch it **on**. However, an app that has coarse location capability does not need to call [RequestAccessAsync](geolocator_requestaccessasync_380675631.md), as it can function whether location access is allowed or denied. The user may still turn on the app-specific location in order to use precise location, but this is not needed for the app's location functionality to work.

## -examples

## -see-also

## -capabilities
location
