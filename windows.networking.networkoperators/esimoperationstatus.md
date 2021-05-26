---
-api-id: T:Windows.Networking.NetworkOperators.ESimOperationStatus
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum ESimOperationStatus : int 
-->

# Windows.Networking.NetworkOperators.ESimOperationStatus

## -description
Defines constants that specify the status of an [ESimOperationResult](esimoperationresult.md) object.

> [!NOTE]
> This functionality is available only to mobile operator apps and UWP apps given privileged access by mobile network operators.
>
> If you want to use this API and publish your app to the Microsoft Store, then you'll need to request special approval to use the custom capability **Microsoft.eSIMManagement_8wekyb3d8bbwe**. For more info, see [Custom capabilities](/windows/uwp/packaging/app-capability-declarations#custom-capabilities).

## -enum-fields

### -field CardBusy:11
Indicates that the SIM card is busy.

### -field CardGeneralFailure:13
Indicates that a card error occurred that prevented the download/install/other operation from completing successfully.

### -field CardRemoved:10
Indicates that the SIM card has been removed.

### -field ConfirmationCodeMaxRetriesExceeded:9
Indicates that the wrong confirmation code was supplied during the operation, and that no more retries are permitted.

### -field ConfirmationCodeMissing:14
Indicates that a confirmation code is needed in order to download the eSIM profile.

### -field EidMismatch:18
Indicates that an eSIM profile on the mobile operator (MO) server is already allocated for a different eSIM EID than the one the device has.

### -field IccidAlreadyExists:25
Indicates that the profile couldn't be added because another one with the same ID is already on the eSIM. Suggest that the user contact their mobile operator.

### -field IncorrectConfirmationCode:8
Indicates that the wrong confirmation code was supplied during the operation.

### -field InsufficientSpaceOnCard:4
Indicates that there is not enough storage space on the card to complete the operation.

### -field InvalidMatchingId:15
Indicates that the matching ID from the activation code or discovered event was refused.

### -field NoCorrespondingRequest:23
Indicates that no corresponding request could be found.

### -field NoEligibleProfileForThisDevice:16
Indicates that an eSIM profile compatible with this device could not be found. For example, a profile was found that requires LTE support, but the device only supports 3G.

### -field NotAuthorized:1
Indicates that the operation was not authorized.

### -field NotFound:2
Indicates that the specified eSIM profile was not found.

### -field OperationAborted:17
Indicates that the operation aborted.

### -field OperationProhibitedByProfileClass:21
Indicates that the operation is not allowed for the eSIM profile class.

### -field Other:12
Indicates a status that's not accounted for by a more specific status.

### -field PolicyViolation:3
Indicates that the operation violates policy.

### -field ProfileDownloadMaxRetriesExceeded:28
Indicates that the profile couldn't be added because because it was downloaded too many times. Suggest that the user contact their mobile operator.

### -field ProfileNotAvailableForNewBinding:19
Indicates that the user is trying to download an eSIM profile that has already been claimed/downloaded.

### -field ProfileNotPresent:22
Indicates that an eSIM profile could not be found.

### -field ProfileNotReleasedByOperator:20
Indicates that the eSIM profile is available, but it is not yet marked as released for download by the mobile operator (MO). You can only download a released profile, so the MO needs to mark the profile as released.

### -field ProfileProcessingError:26
Indicates that the profile couldn't be added because there was a problem installing it. Suggest that the user contact their mobile operator.

### -field ServerFailure:5
Indicates that a server failure occurred during the operation.

### -field ServerNotReachable:6
Indicates that the server could not be reached during the operation.

### -field ServerNotTrusted:27
Indicates that the profile couldn't be downloaded because the server isn't a trusted source. Suggest that the user contact their mobile operator.

### -field Success:0
Indicates that the operation was successful.

### -field TimeoutWaitingForResponse:24
The operation timed out waiting for card response. Suggest that the user try to add the profile again.

### -field TimeoutWaitingForUserConsent:7
Indicates that user consent was not granted within the timeout period of the operation.

## -remarks

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1809 | 17763 | CardGeneralFailure |
| 1809 | 17763 | ConfirmationCodeMissing |
| 1809 | 17763 | EidMismatch |
| 1809 | 17763 | InvalidMatchingId |
| 1809 | 17763 | NoCorrespondingRequest |
| 1809 | 17763 | NoEligibleProfileForThisDevice |
| 1809 | 17763 | OperationAborted |
| 1809 | 17763 | OperationProhibitedByProfileClass |
| 1809 | 17763 | ProfileNotAvailableForNewBinding |
| 1809 | 17763 | ProfileNotPresent |
| 1809 | 17763 | ProfileNotReleasedByOperator |

## -see-also

## -examples

## -capabilities
Microsoft.eSIMManagement_8wekyb3d8bbwe
