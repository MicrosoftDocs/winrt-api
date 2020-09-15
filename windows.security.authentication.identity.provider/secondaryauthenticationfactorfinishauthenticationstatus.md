---
-api-id: T:Windows.Security.Authentication.Identity.Provider.SecondaryAuthenticationFactorFinishAuthenticationStatus
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Security.Authentication.Identity.Provider.SecondaryAuthenticationFactorFinishAuthenticationStatus : int
-->

# SecondaryAuthenticationFactorFinishAuthenticationStatus

## -description
Represents the status of finishing authentication with a companion device.

> [!NOTE]
> This API is not available to all apps. Unless your developer account is specially provisioned by Microsoft to use the **secondaryAuthenticationFactor** capability, calls to this API will fail. To apply for approval, contact [cdfonboard@microsoft.com](mailto:cdfonboard@microsoft.com). For more information on capabilities, see [App capability declarations](/windows/uwp/packaging/app-capability-declarations). For an overview of the Companion Device Framework, see the [Windows Unlock with companion (IoT) devices](/windows/uwp/security/companion-device-unlock) overview.

## -enum-fields
### -field Failed:0
The operation failed.

### -field Completed:1
The operation completed.

### -field NonceExpired:2
The nonce expired.


## -remarks

## -examples

## -see-also
[Windows Unlock with companion (IoT) devices](/windows/uwp/security/companion-device-unlock)