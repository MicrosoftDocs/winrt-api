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

## -params

## -param kind
A value that specifies whether the method should return codecs that operate on video or audio data.

## -param category
A value that specifies whether the method should return codecs that are encoders or decoders.

## -param subType
A value specifying the media encoding subtype that all returned codecs must support. This value can be a string representation of one of the subtype GUIDs listed in [Audio Subtype GUIDs](https://msdn.microsoft.com/library/windows/desktop/aa372553(v=vs.85).aspx) or [Video Subtyp GUIDs](https://msdn.microsoft.com/library/windows/desktop/aa370819(v=vs.85).aspx). The [CodecSubtypes](./codecsubtypes.md) class provides properties for most supported media subtypes that return the string representation of the subtype GUID. You can also specify a FOURCC code for this parameter. For more information, see [FOURCC Codes](https://msdn.microsoft.com/library/windows/desktop/dd375802(v=vs.85).aspx). To specify that all codecs of the specified *kind* and *category* should be returned, regardless of what media subtypes are supported, specify an empty string ("") or null for this parameter.

## -returns

## -remarks

## -see-also

## -examples

