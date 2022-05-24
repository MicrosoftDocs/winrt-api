---
-api-id: M:Windows.Media.Core.CodecQuery.FindAllAsync(Windows.Media.Core.CodecKind,Windows.Media.Core.CodecCategory,System.String)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<CodecInfo>> CodecQuery.FindAllAsync(CodecKind kind, CodecCategory category, String subType)
-->

# Windows.Media.Core.CodecQuery.FindAllAsync


## -description

Returns a read-only list of all media codecs installed on the system that meet the specified requirements.

## -parameters

### -param kind

A value that specifies whether the method should return codecs that operate on video or audio data.

### -param category

A value that specifies whether the method should return codecs that are encoders or decoders.

### -param subType

A value specifying the media encoding subtype that all returned codecs must support. This value can be a string representation of one of the subtype GUIDs listed in [Audio Subtype GUIDs](/windows/desktop/medfound/audio-subtype-guids) or [Video Subtyp GUIDs](/windows/desktop/medfound/video-subtype-guids). The [CodecSubtypes](./codecsubtypes.md) class provides properties for most supported media subtypes that return the string representation of the subtype [GUID](/windows/win32/api/guiddef/ns-guiddef-guid). You can also specify a FOURCC code for this parameter. For more information, see [FOURCC Codes](/windows/desktop/DirectShow/fourcc-codes). To specify that all codecs of the specified *kind* and *category* should be returned, regardless of what media subtypes are supported, specify an empty string ("") for this parameter.

## -returns

## -remarks

## -see-also

## -examples

