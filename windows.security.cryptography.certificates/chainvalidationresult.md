---
-api-id: T:Windows.Security.Cryptography.Certificates.ChainValidationResult
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Security.Cryptography.Certificates.ChainValidationResult : int
-->

# ChainValidationResult

## -description
Describes the result of a certificate chain verification operation.

## -enum-fields
### -field Success:0
The certificate chain was verified.

### -field Untrusted:1
A certificate in the chain is not trusted.

### -field Revoked:2
A certificate in the chain has been revoked.

### -field Expired:3
A certificate in the chain has expired.

### -field IncompleteChain:4
The certificate chain is missing one or more certificates.

### -field InvalidSignature:5
The signature of a certificate in the chain cannot be verified.

### -field WrongUsage:6
A certificate in the chain is being used for a purpose other than one specified by its CA.

### -field InvalidName:7
A certificate in the chain has a name that is not valid. The name is either not included in the permitted list or is explicitly excluded.

### -field InvalidCertificateAuthorityPolicy:8
A certificate in the chain has a policy that is not valid.

### -field BasicConstraintsError:9
The basic constraint extension of a certificate in the chain has not been observed.

### -field UnknownCriticalExtension:10
A certificate in the chain contains an unknown extension that is marked "critical".

### -field RevocationInformationMissing:11
No installed or registered DLL was found to verify revocation.

### -field RevocationFailure:12
Unable to connect to the revocation server.

### -field OtherErrors:13
An unexpected error occurred while validating the certificate chain.


## -remarks

## -examples

## -see-also