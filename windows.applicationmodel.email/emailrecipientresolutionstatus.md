---
-api-id: T:Windows.ApplicationModel.Email.EmailRecipientResolutionStatus
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.ApplicationModel.Email.EmailRecipientResolutionStatus : int
-->

# EmailRecipientResolutionStatus

## -description
Describes the state of an attempt to resolve an email recipient.

## -enum-fields
### -field Success:0
Success. Email recipient resolved.

### -field RecipientNotFound:1
Resolution failed. Recipient cannot be resolved because no match found in distribution list.

### -field AmbiguousRecipient:2
Resolution failed. Multiple results returned. Refinement needed.

### -field NoCertificate:3
Resolution failed. No valid certificate present.

### -field CertificateRequestLimitReached:4
Resolution failed. The limit of allowed requests for the current certificate has been reached.

### -field CannotResolveDistributionList:5
Resolution failed. The distribution list cannot be accessed.

### -field ServerError:6
Resolution failed. There has been an error on the server.

### -field UnknownFailure:7
Resolution failed for unknown reason.


## -remarks

## -examples

## -see-also