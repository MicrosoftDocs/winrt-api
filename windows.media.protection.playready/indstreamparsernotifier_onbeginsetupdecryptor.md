---
-api-id: M:Windows.Media.Protection.PlayReady.INDStreamParserNotifier.OnBeginSetupDecryptor(Windows.Media.Core.IMediaStreamDescriptor,System.Guid,System.Byte[])
-api-type: winrt method
---

<!-- Method syntax
public void OnBeginSetupDecryptor(Windows.Media.Core.IMediaStreamDescriptor descriptor, System.Guid keyID, System.Byte[] proBytes)
-->

# Windows.Media.Protection.PlayReady.INDStreamParserNotifier.OnBeginSetupDecryptor

## -description
Called by the stream parser when it requests a setup decryptor.

## -parameters
### -param descriptor
The descriptor of the media stream being decrypted.

### -param keyID
The key identifier used for decryption.

### -param proBytes
The byte array of a PlayReadyObject for creating the decryptor. For MPEG2 TS, the PlayReadyObject is in the entitlement control messages (ECM) packet.

## -remarks

## -examples

## -see-also
