---
-api-id: T:Windows.Security.Cryptography.Certificates.CertificateChainPolicy
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Security.Cryptography.Certificates.CertificateChainPolicy : int
-->

# CertificateChainPolicy

## -description
Describes the policy to use when performing a certificate chain validation.

## -enum-fields
### -field Base:0
Use the base chain policy verification checks.

### -field Ssl:1
Use the SSL client/server chain policy verification checks.

### -field NTAuthentication:2
Use the Windows NT Authentication chain policy checks.

### -field MicrosoftRoot:3
Check the last element of the first simple chain for a Microsoft root public key.


## -remarks

## -examples

## -see-also
[Validate](/uwp/api/windows.security.cryptography.certificates.certificatechain.validate)