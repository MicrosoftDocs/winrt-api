---
-api-id: M:Windows.Security.Cryptography.Core.CryptographicEngine.VerifySignatureWithHashInput(Windows.Security.Cryptography.Core.CryptographicKey,Windows.Storage.Streams.IBuffer,Windows.Storage.Streams.IBuffer)
-api-type: winrt method
---

<!-- Method syntax
public bool VerifySignatureWithHashInput(Windows.Security.Cryptography.Core.CryptographicKey key, Windows.Storage.Streams.IBuffer data, Windows.Storage.Streams.IBuffer signature)
-->

# Windows.Security.Cryptography.Core.CryptographicEngine.VerifySignatureWithHashInput

## -description
Verifies the signature of the specified input data against a known signature.

## -parameters
### -param key
The key to use to retrieve the signature from the input data. This key must be an asymmetric key obtained from a [PersistedKeyProvider](persistedkeyprovider.md) or [AsymmetricKeyAlgorithmProvider](asymmetrickeyalgorithmprovider.md).

### -param data
The data to be verified. The data is a hashed value of raw data.

### -param signature
The known signature to use to verify the signature of the input data.

## -returns
True if the signature is verified; otherwise false.

## -remarks

## -examples

## -see-also
