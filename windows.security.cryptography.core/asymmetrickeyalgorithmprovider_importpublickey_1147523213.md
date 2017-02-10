---
-api-id: M:Windows.Security.Cryptography.Core.AsymmetricKeyAlgorithmProvider.ImportPublicKey(Windows.Storage.Streams.IBuffer,Windows.Security.Cryptography.Core.CryptographicPublicKeyBlobType)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Security.Cryptography.Core.CryptographicKey ImportPublicKey(Windows.Storage.Streams.IBuffer keyBlob, Windows.Security.Cryptography.Core.CryptographicPublicKeyBlobType BlobType)
-->

# Windows.Security.Cryptography.Core.AsymmetricKeyAlgorithmProvider.ImportPublicKey

## -description
Imports a public key into a buffer for a specified format.

## -parameters
### -param keyBlob
Buffer that contains the key to import.

### -param BlobType
A [CryptographicPublicKeyBlobType](cryptographicpublickeyblobtype.md) enumeration value that specifies the format of the public key contained in the *keyBlob* buffer. The default value is **X509SubjectPublicKeyInfo**.

## -returns
Represents the imported key.

## -remarks

## -examples

## -see-also
[ImportPublicKey(IBuffer)](asymmetrickeyalgorithmprovider_importpublickey_1997765285.md)