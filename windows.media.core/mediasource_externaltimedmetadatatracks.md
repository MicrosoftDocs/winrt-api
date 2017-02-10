---
-api-id: P:Windows.Media.Core.MediaSource.ExternalTimedMetadataTracks
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IObservableVector<Windows.Media.Core.TimedMetadataTrack> ExternalTimedMetadataTracks { get; }
-->

# Windows.Media.Core.MediaSource.ExternalTimedMetadataTracks

## -description
A collection of external timed metadata tracks associated with the [MediaSource](mediasource.md).

## -property-value
The collection of external timed metadata tracks.

## -remarks
You can generate [TimedMetadataTrack](timedmetadatatrack.md) objects in code and add them to this collection directly, or you can create a [TimedTextSource](timedtextsource.md) from a URL or stream and use the [ExternalTimedTextSources](mediasource_externaltimedtextsources.md) property to populate the collection.

## -examples

## -see-also
