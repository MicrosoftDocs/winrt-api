---
-api-id: T:Windows.Media.Protection.RevocationAndRenewalReasons
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Media.Protection.RevocationAndRenewalReasons : uint
-->

# RevocationAndRenewalReasons

## -description
Defines reasons for the revocation and renewal of a certificate for a media component.

## -enum-fields
### -field UserModeComponentLoad:1
User-mode component.

### -field KernelModeComponentLoad:2
Kernel-mode component.

### -field AppComponent:4
App component.

### -field GlobalRevocationListLoadFailed:16
Could not load the global revocation list (GRL).

### -field InvalidGlobalRevocationListSignature:32
The GRL signature is invalid.

### -field GlobalRevocationListAbsent:4096
The GRL was not found.

### -field ComponentRevoked:8192
A trusted component was revoked.

### -field InvalidComponentCertificateExtendedKeyUse:16384
A certificate's extended key usage (EKU) object is invalid.

### -field ComponentCertificateRevoked:32768
A certificate in a trusted component's certificate chain was revoked.

### -field InvalidComponentCertificateRoot:65536
The root certificate is not valid.

### -field ComponentHighSecurityCertificateRevoked:131072
The high-security certificate for authenticating the protected environment (PE) was revoked.

The high-security certificate is typically used by ITAs that handle high-definition content and next-generation formats such as HD-DVD.

### -field ComponentLowSecurityCertificateRevoked:262144
The low-security certificate for authenticating the PE was revoked.

The low-security certificate is typically used by ITAs that handle standard-definition content and current-generation formats.

### -field BootDriverVerificationFailed:1048576
A boot driver could not be verified.

### -field ComponentSignedWithTestCertificate:16777216
A component was signed by a test certificate.

### -field EncryptionFailure:268435456
A certificate chain was not well-formed, or a boot driver is unsigned or is signed with an untrusted certificate.


## -remarks

## -examples

## -see-also