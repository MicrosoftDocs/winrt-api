---
-api-id: T:Windows.Devices.Geolocation.VenueData
-api-type: winrt class
---

<!-- Class syntax.
public class VenueData : Windows.Devices.Geolocation.IVenueData
-->

# Windows.Devices.Geolocation.VenueData

## -description
Represents the venue associated with a geographic location.

## -remarks
This class represents a venue, such as a shopping mall or office building. The [VenueData](venuedata.md) object is created as a property of the [Geoposition](geoposition.md) class when venue information is available for a geographic location. Otherwise, this property returns **NULL**.

Venue information is not available for all geographic locations. A [VenueData](venuedata.md) object will be returned only when the geographic location is within a venue that’s supported by the data provider.



> [!NOTE]
> In this release, Bing is the exclusive data provider for all venue information.

## -examples

## -see-also
