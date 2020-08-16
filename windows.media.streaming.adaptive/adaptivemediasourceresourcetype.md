---
-api-id: T:Windows.Media.Streaming.Adaptive.AdaptiveMediaSourceResourceType
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Media.Streaming.Adaptive.AdaptiveMediaSourceResourceType : int
-->

# AdaptiveMediaSourceResourceType

## -description
Specifies the type of an adaptive media resource.

## -enum-fields
### -field Manifest:0
The resource is an adaptive streaming manifest.

### -field InitializationSegment:1
The resource is an initialization segment.

### -field MediaSegment:2
The resource is a media segment.

### -field Key:3
The resource is an encryption key.

### -field InitializationVector:4
The resource is a cryptographic initialization vector.


### -field MediaSegmentIndex:5
The resource is a media segment index.

## -remarks

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1809 | 17763 | MediaSegmentIndex |

## -examples

## -see-also
