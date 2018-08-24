---
-api-id: T:Windows.Security.Cryptography.Certificates.SignatureValidationResult
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Security.Cryptography.Certificates.SignatureValidationResult : int
-->

# SignatureValidationResult

## -description
Describes the result of a signature verification operation.

## -enum-fields
### -field Success:0
The signature was verified.

### -field InvalidParameter:1
An invalid argument was encountered while verifying the signature.

### -field BadMessage:2
A severe error occurred such as missing key provider information or an incorrect algorithm id.

### -field InvalidSignature:3
The signature was not verified.

### -field OtherErrors:4
Additional errors were encountered.


## -remarks

## -examples

## -see-also
[VerifySignature](cmsattachedsignature_verifysignature_168064265.md), [VerifySignatureAsync](cmsdetachedsignature_verifysignatureasync_103550404.md)