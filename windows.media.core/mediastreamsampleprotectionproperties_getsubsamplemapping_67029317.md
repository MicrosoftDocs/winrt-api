---
-api-id: M:Windows.Media.Core.MediaStreamSampleProtectionProperties.GetSubSampleMapping(System.Byte[]@)
-api-type: winrt method
---

<!-- Method syntax
public void GetSubSampleMapping(System.Byte[] value)
-->

# Windows.Media.Core.MediaStreamSampleProtectionProperties.GetSubSampleMapping

## -description
Gets the Digital Rights Management (DRM) sub-sample mapping from the [MediaStreamSample](mediastreamsample.md).

## -parameters
### -param value
Receives the sub-sample mapping.

## -remarks
The sub-sample mapping is used when only portions of the data contained in the [MediaStreamSample](mediastreamsample.md) is encrypted. The sub-sample mapping specifies which parts are encrypted and which are in the clear. The syntax of the sub-sample mapping data is specific to each individual Digital Rights Management (DRM) protection scheme.

## -examples

## -see-also
