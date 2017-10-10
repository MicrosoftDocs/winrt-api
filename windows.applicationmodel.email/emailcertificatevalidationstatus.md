---
-api-id: T:Windows.ApplicationModel.Email.EmailCertificateValidationStatus
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.ApplicationModel.Email.EmailCertificateValidationStatus : int
-->

# EmailCertificateValidationStatus

## -description
Describes the result of an attempt to validate a certificate.

## -enum-fields
### -field Success:0
Success. Certificate validated.

### -field NoMatch:1
Validation failed. No matching certificate found.

### -field InvalidUsage:2
Validation failed. Invalid usage of certificate.

### -field InvalidCertificate:3
Validation failed. Certificate is not valid.

### -field Revoked:4
Validation failed. Certificate revoked.

### -field ChainRevoked:5
Validation failed. One or more certificates in the chain, other than the current certificate, have been revoked.

### -field RevocationServerFailure:6
Validation failed. Revocation server failure.

### -field Expired:7
Validation failed. Certificate expired.

### -field Untrusted:8
Validation failed. Certificate untrusted.

### -field ServerError:9
Validation failed. Server failure.

### -field UnknownFailure:10
Validation failed. Unknown failure.


## -remarks

## -examples

## -see-also
## -capabilities
email, emailSystem
