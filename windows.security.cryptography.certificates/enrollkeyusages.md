---
-api-id: T:Windows.Security.Cryptography.Certificates.EnrollKeyUsages
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Security.Cryptography.Certificates.EnrollKeyUsages : uint
-->

# EnrollKeyUsages

## -description
Specifies the cryptographic operations that can be performed by the private key. This enumeration type is used in the [KeyUsages](certificaterequestproperties_keyusages.md) property of a [CertificateRequestProperties](certificaterequestproperties.md) object.

## -enum-fields
### -field None:0
No usage is specified for the key.

### -field Decryption:1
The key can be used for decryption.

### -field Signing:2
The key can be used for signing.

### -field KeyAgreement:4
The key can be used for secret agreement encryption.

### -field All:16777215
The key can be used for decryption, signing. and key agreement.


## -remarks

## -examples

## -see-also
[CertificateRequestProperties](certificaterequestproperties.md), [KeyUsages](certificaterequestproperties_keyusages.md), [Windows.Security.Cryptography.Certificates](windows_security_cryptography_certificates.md)