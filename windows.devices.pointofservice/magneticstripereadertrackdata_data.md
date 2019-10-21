---
-api-id: P:Windows.Devices.PointOfService.MagneticStripeReaderTrackData.Data
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.Storage.Streams.IBuffer Data { get; }
-->

# Windows.Devices.PointOfService.MagneticStripeReaderTrackData.Data

## -description
Gets the raw or decoded data from the swiped card.

## -property-value
The track data from the swiped card.

## -remarks
If [IsDecodeDataEnabled](claimedmagneticstripereader_isdecodedataenabled.md) is true, then Data contains decoded data.

If [IsTransmitSentinelsEnabled](claimedmagneticstripereader_istransmitsentinelsenabled.md) is false, then Data contains the track data between sentinels, but not including the start and end sentinels. If [IsTransmitSentinelsEnabled](claimedmagneticstripereader_istransmitsentinelsenabled.md) is true, then the track data includes the start and end sentinels.

## -examples

## -see-also
