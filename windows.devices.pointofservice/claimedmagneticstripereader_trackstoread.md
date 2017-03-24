---
-api-id: P:Windows.Devices.PointOfService.ClaimedMagneticStripeReader.TracksToRead
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.Devices.PointOfService.MagneticStripeReaderTrackIds TracksToRead { get;  set; }
-->

# Windows.Devices.PointOfService.ClaimedMagneticStripeReader.TracksToRead

## -description
Gets or sets the track data that the application wants to receive following a card swipe.

## -property-value
The card track.

## -remarks
[TracksToRead](claimedmagneticstripereader_trackstoread.md) determines which tracks the application wants to receive following a card swipe. This does not indicate the capability of the device hardware; instead, it is an application configurable property representing which tracks to read. There are cases when the desired data cannot be obtained, such as cards not having data for a particular track.

Decreasing the required number of tracks may provide a greater success rate and somewhat greater responsiveness by removing the processing for inaccessible data.

This property is initialized for all tracks (Track1 | Track 2 | Track3 | Track4).

## -examples

## -see-also
