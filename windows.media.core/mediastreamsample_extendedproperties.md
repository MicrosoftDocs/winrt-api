---
-api-id: P:Windows.Media.Core.MediaStreamSample.ExtendedProperties
-api-type: winrt property
---

<!-- Property syntax
public Windows.Media.Core.MediaStreamSamplePropertySet ExtendedProperties { get; }
-->

# Windows.Media.Core.MediaStreamSample.ExtendedProperties

## -description
Gets the extended property set which enables getting and setting properties on the [MediaStreamSample](mediastreamsample.md).

## -property-value
The extended properties map.

## -remarks
The ExtendedProperties is used for less common properties which are not directly accessible on the [MediaStreamSamplePropertySet](mediastreamsamplepropertyset.md) object. The properties are accessed through their [GUID](/windows/win32/api/guiddef/ns-guiddef-guid) values. For example, the video stride property is accessed through the GUID value “0x644b4e48, 0x1e02, 0x4516, 0xb0, 0xeb, 0xc0, 0x1c, 0xa9, 0xd4, 0x9a, 0xc6”, which is the GUID for [MF_MT_DEFAULT_STRIDE](/windows/desktop/medfound/mf-mt-default-stride-attribute).

## -examples

## -see-also
