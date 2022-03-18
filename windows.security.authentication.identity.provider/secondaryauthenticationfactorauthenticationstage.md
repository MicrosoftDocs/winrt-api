---
-api-id: T:Windows.Security.Authentication.Identity.Provider.SecondaryAuthenticationFactorAuthenticationStage
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Security.Authentication.Identity.Provider.SecondaryAuthenticationFactorAuthenticationStage : int
-->

# SecondaryAuthenticationFactorAuthenticationStage

## -description
Gets the stage of the companion device authentication.

> [!NOTE]
> This API is not available to all apps. Unless your developer account is specially provisioned by Microsoft to use the **secondaryAuthenticationFactor** capability, calls to this API will fail. To apply for approval, contact [cdfonboard@microsoft.com](mailto:cdfonboard@microsoft.com). For more information on capabilities, see [App capability declarations](/windows/uwp/packaging/app-capability-declarations). For an overview of the Companion Device Framework, see the [Windows Unlock with companion (IoT) devices](/windows/uwp/security/companion-device-unlock) overview.

## -enum-fields
### -field NotStarted:0
Authentication not started.

### -field WaitingForUserConfirmation:1
Waiting for user confirmation.

### -field CollectingCredential:2
Collecting credential.

### -field SuspendingAuthentication:3
Suspending authentication.

### -field CredentialCollected:4
Credential collected

### -field CredentialAuthenticated:5
Credential authenticated.

### -field StoppingAuthentication:6
Stopping authentication.

### -field ReadyForLock:7
Ready for lock.

### -field CheckingDevicePresence:8
**Deprecated.** Checking for device presence.

## -remarks

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1703 | 15063 | CheckingDevicePresence |

## -examples

## -see-also
[Windows Unlock with companion (IoT) devices](/windows/uwp/security/companion-device-unlock)