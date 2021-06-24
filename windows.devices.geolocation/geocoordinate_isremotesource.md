---
-api-id: P:Windows.Devices.Geolocation.Geocoordinate.IsRemoteSource
-api-type: winrt property
---

# Windows.Devices.Geolocation.Geocoordinate.IsRemoteSource

<!--
public bool IsRemoteSource { get; }
-->


## -description

Gets a value that indicates whether the current location reported by this [Geocoordinate](geocoordinate.md) object is being redirected to a remote physical location.

## -property-value

True if the current location reported by this [Geocoordinate](geocoordinate.md) object is being redirected to a remote physical location; otherwise, false.

## -remarks

In some scenarios, such as remote desktop sessions, the physical location of the current device does not represent the user's actual location. In these scenarios, Windows can redirect the user's location to a remote computer that is used as the main source for positioning. Use this property to determine whether the user's location is being redirected to a remote computer.  

## -see-also

## -examples


