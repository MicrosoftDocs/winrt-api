---
-api-id: M:Windows.Security.Cryptography.Core.PersistedKeyProvider.OpenKeyPairFromCertificateAsync(Windows.Security.Cryptography.Certificates.Certificate,System.String,Windows.Security.Cryptography.Core.CryptographicPadding)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Security.Cryptography.Core.CryptographicKey> OpenKeyPairFromCertificateAsync(Windows.Security.Cryptography.Certificates.Certificate certificate, System.String hashAlgorithmName, Windows.Security.Cryptography.Core.CryptographicPadding padding)
-->

# Windows.Security.Cryptography.Core.PersistedKeyProvider.OpenKeyPairFromCertificateAsync

## -description
Opens the persisted private key from the specified [Certificate](../windows.security.cryptography.certificates/certificate.md) object.

## -parameters
### -param certificate
The certificate that is associated with the private key.

### -param hashAlgorithmName
The hash algorithm for signature operations. For encryption, the hash algorithm is ignored.

### -param padding
The padding mode for asymmetric algorithm signature or encryption operations.

## -returns
An asynchronous operation for retrieving a private key from the supplied [Certificate](../windows.security.cryptography.certificates/certificate.md) object.

## -remarks

## -examples

## -see-also
[CryptographicKey](cryptographickey.md)