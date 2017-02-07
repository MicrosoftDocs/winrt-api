---
-api-id: T:Windows.Security.Cryptography.Certificates.KeyProtectionLevel
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Security.Cryptography.Certificates.KeyProtectionLevel : int
-->

# KeyProtectionLevel

## -description
Specifies the key protection level. This enumeration type is used in the [KeyProtectionLevel](certificaterequestproperties_keyprotectionlevel.md) property of a [CertificateRequestProperties](certificaterequestproperties.md) object.

## -enum-fields
### -field NoConsent:0
No strong key protection.

### -field ConsentOnly:1
The user is notified through a dialog box when the private key is created or used.

### -field ConsentWithPassword:2
The user is prompted to enter a password for the key when the key is created or used.

### -field ConsentWithFingerprint:3
The user is prompted to enter a fingerprint verification for the key when the key is created or used.


## -remarks

## -examples

## -see-also
[CertificateRequestProperties](certificaterequestproperties.md), [KeyProtectionLevel](certificaterequestproperties_keyprotectionlevel.md), [Windows.Security.Cryptography.Certificates](windows_security_cryptography_certificates.md)