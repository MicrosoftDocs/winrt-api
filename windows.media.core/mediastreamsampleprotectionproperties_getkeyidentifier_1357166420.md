---
-api-id: M:Windows.Media.Core.MediaStreamSampleProtectionProperties.GetKeyIdentifier(System.Byte[]@)
-api-type: winrt method
---

<!-- Method syntax
public void GetKeyIdentifier(System.Byte[] value)
-->

# Windows.Media.Core.MediaStreamSampleProtectionProperties.GetKeyIdentifier

## -description
Gets the Digital Rights Management (DRM) key identifier from the [MediaStreamSample](mediastreamsample.md).

## -parameters
### -param value
Receives the key identifier used to decrypt the data.

## -remarks
This method is used with encrypted [MediaStreamSample](mediastreamsample.md) objects that belonging to a protection scheme that uses multiple keys. The key identifier allows the decryptor to know which key to use to decrypt the data.

## -examples

## -see-also
