---
-api-id: M:Windows.Security.Cryptography.Core.AsymmetricKeyAlgorithmProvider.ImportKeyPair(Windows.Storage.Streams.IBuffer,Windows.Security.Cryptography.Core.CryptographicPrivateKeyBlobType)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Security.Cryptography.Core.CryptographicKey ImportKeyPair(Windows.Storage.Streams.IBuffer keyBlob, Windows.Security.Cryptography.Core.CryptographicPrivateKeyBlobType BlobType)
-->

# Windows.Security.Cryptography.Core.AsymmetricKeyAlgorithmProvider.ImportKeyPair

## -description
Imports a public/private key pair from a buffer in the specified format.

## -parameters
### -param keyBlob
Buffer that contains the key pair to import.

### -param BlobType
A [CryptographicPrivateKeyBlobType](cryptographicprivatekeyblobtype.md) enumeration value that specifies information about the private key contained in the *keyBlob* buffer. The default value is **Pkcs8RawPrivateKeyInfo**.

## -returns
Represents the imported key pair.

## -remarks

## -examples

## -see-also
[ImportKeyPair(IBuffer)](asymmetrickeyalgorithmprovider_importkeypair_1440785557.md)