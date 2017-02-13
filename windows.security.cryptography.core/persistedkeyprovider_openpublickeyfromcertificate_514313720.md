---
-api-id: M:Windows.Security.Cryptography.Core.PersistedKeyProvider.OpenPublicKeyFromCertificate(Windows.Security.Cryptography.Certificates.Certificate,System.String,Windows.Security.Cryptography.Core.CryptographicPadding)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Security.Cryptography.Core.CryptographicKey OpenPublicKeyFromCertificate(Windows.Security.Cryptography.Certificates.Certificate certificate, System.String hashAlgorithmName, Windows.Security.Cryptography.Core.CryptographicPadding padding)
-->

# Windows.Security.Cryptography.Core.PersistedKeyProvider.OpenPublicKeyFromCertificate

## -description
Opens the persisted public key from the specified [Certificate](../windows.security.cryptography.certificates/certificate.md) object.

## -parameters
### -param certificate
The certificate that contains the public key.

### -param hashAlgorithmName
The has algorithm for signature operations.

### -param padding
The padding mode for asymmetric algorithm signature or encryption operations.

## -returns
The public key retrieved from the supplied [Certificate](../windows.security.cryptography.certificates/certificate.md) object.

## -remarks

## -examples

## -see-also
[CryptographicKey](cryptographickey.md)