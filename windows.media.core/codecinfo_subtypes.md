---
-api-id: P:Windows.Media.Core.CodecInfo.Subtypes
-api-type: winrt property
---

<!-- Property syntax.
public IVectorView<string> Subtypes { get; }
-->

# Windows.Media.Core.CodecInfo.Subtypes

## -description
Gets a read-only list of values that specify the media subtypes supported by the codec.

## -property-value
A read-only list of values that specify the media subtypes supported by the codec.

## -remarks
Each value in the list returned by this method is string representation of a [GUID](/windows/win32/api/guiddef/ns-guiddef-guid) that identifies a media subtype that is supported by the codec. For a listing of media subtype GUIDs, see [Audio Subtype GUIDs](/windows/desktop/medfound/audio-subtype-guids) or [Video Subtyp GUIDs](/windows/desktop/medfound/video-subtype-guids). The [CodecSubtypes](./codecsubtypes.md) class provides properties for most supported media subtypes that return the string representation of the subtype GUID to make it easy to compare against the **Subtypes** property of a **CodecInfo** object to see if a codec supports a particular subtype.

## -see-also
[CodecSubtypes](./codecsubtypes.md)

## -examples

