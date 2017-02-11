---
-api-id: P:Windows.Media.Core.MediaSource.ExternalTimedTextSources
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IObservableVector<Windows.Media.Core.TimedTextSource> ExternalTimedTextSources { get; }
-->

# Windows.Media.Core.MediaSource.ExternalTimedTextSources

## -description
A collection of external timed text sources associated with the [MediaSource](mediasource.md).

## -property-value
The collection of external timed text sources.

## -remarks
You can create a [TimedTextSource](timedtextsource.md) from a URL or stream and then set this property to populate the [ExternalTimedMetadataTracks](mediasource_externaltimedmetadatatracks.md) collection, or you can generate [TimedMetadataTrack](timedmetadatatrack.md) objects in code and add them to tthe [ExternalTimedMetadataTracks](mediasource_externaltimedmetadatatracks.md) collection directly.



## -examples

## -see-also
