---
-api-id: T:Windows.Media.Streaming.Adaptive.AdaptiveMediaSourceCreationStatus
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Media.Streaming.Adaptive.AdaptiveMediaSourceCreationStatus : int
-->

# AdaptiveMediaSourceCreationStatus

## -description
Specifies the result of an attempt to create a [AdaptiveMediaSource](adaptivemediasource.md) object.

## -enum-fields
### -field Success:0
The [AdaptiveMediaSource](adaptivemediasource.md) object was successfully created.

### -field ManifestDownloadFailure:1
The creation of the [AdaptiveMediaSource](adaptivemediasource.md) object failed as the result of a failure in downloading the adaptive streaming manifest.

### -field ManifestParseFailure:2
The creation of the [AdaptiveMediaSource](adaptivemediasource.md) object failed as the result of a failure in parsing the adaptive streaming manifest.

### -field UnsupportedManifestContentType:3
The creation of the [AdaptiveMediaSource](adaptivemediasource.md) object failed because the content of the adaptive streaming manifest is unsupported.

### -field UnsupportedManifestVersion:4
The creation of the [AdaptiveMediaSource](adaptivemediasource.md) object failed because the version of the adaptive streaming manifest is unsupported.

### -field UnsupportedManifestProfile:5
The creation of the [AdaptiveMediaSource](adaptivemediasource.md) object failed because the profile of the adaptive streaming manifest is unsupported.

### -field UnknownFailure:6
The creation of the [AdaptiveMediaSource](adaptivemediasource.md) object failed because of an unknown failure.


## -remarks

## -examples

## -see-also