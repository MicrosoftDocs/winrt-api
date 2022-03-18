---
-api-id: P:Windows.Media.Core.TimedMetadataStreamDescriptor.Label
-api-type: winrt property
---

<!-- Property syntax.
public string Label { get;  set; }
-->

# Windows.Media.Core.TimedMetadataStreamDescriptor.Label

## -description
Gets or sets an app-defined label that identifies a timed metadata stream in a [MediaEncodingProfile](/uwp/api/Windows.Media.MediaProperties.MediaEncodingProfile) that contains multiple streams.

## -property-value
An app-defined label that identifies a timed metadata stream.

## -remarks
The label for each stream in a single **MediaEncodingProfile** must be unique. Calling [SetTimedMetadataTracks](../windows.media.mediaproperties/mediaencodingprofile_settimedmetadatatracks_484361839.md) to add a stream descriptor containing a duplicate label will result in an invalid argument error.


## -see-also

## -examples

