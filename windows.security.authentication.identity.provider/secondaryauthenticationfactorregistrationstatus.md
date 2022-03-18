---
-api-id: T:Windows.Security.Authentication.Identity.Provider.SecondaryAuthenticationFactorRegistrationStatus
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Security.Authentication.Identity.Provider.SecondaryAuthenticationFactorRegistrationStatus : int
-->

# SecondaryAuthenticationFactorRegistrationStatus

## -description
Represents the status of a companion device registration.

> [!NOTE]
> This API is not available to all apps. Unless your developer account is specially provisioned by Microsoft to use the **secondaryAuthenticationFactor** capability, calls to this API will fail. To apply for approval, contact [cdfonboard@microsoft.com](mailto:cdfonboard@microsoft.com). For more information on capabilities, see [App capability declarations](/windows/uwp/packaging/app-capability-declarations). For an overview of the Companion Device Framework, see the [Windows Unlock with companion (IoT) devices](/windows/uwp/security/companion-device-unlock) overview.

## -enum-fields
### -field Failed:0
Registration failed.

### -field Started:1
Registration started.

### -field CanceledByUser:2
Registration cancelled by the user.

### -field PinSetupRequired:3
PIN setup is required before registration can occur.

### -field DisabledByPolicy:4
Registration is disabled by policy.


## -remarks

## -examples

## -see-also
[Windows Unlock with companion (IoT) devices](/windows/uwp/security/companion-device-unlock)