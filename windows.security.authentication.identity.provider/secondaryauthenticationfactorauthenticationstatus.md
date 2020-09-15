---
-api-id: T:Windows.Security.Authentication.Identity.Provider.SecondaryAuthenticationFactorAuthenticationStatus
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Security.Authentication.Identity.Provider.SecondaryAuthenticationFactorAuthenticationStatus : int
-->

# SecondaryAuthenticationFactorAuthenticationStatus

## -description
Represents the status of an authentication operation using a companion device.

> [!NOTE]
> This API is not available to all apps. Unless your developer account is specially provisioned by Microsoft to use the **secondaryAuthenticationFactor** capability, calls to this API will fail. To apply for approval, contact [cdfonboard@microsoft.com](mailto:cdfonboard@microsoft.com). For more information on capabilities, see [App capability declarations](/windows/uwp/packaging/app-capability-declarations). For an overview of the Companion Device Framework, see the [Windows Unlock with companion (IoT) devices](/windows/uwp/security/companion-device-unlock) overview.

## -enum-fields
### -field Failed:0
Authentication failed.

### -field Started:1
Authentication started.

### -field UnknownDevice:2
Unknown companion device.

### -field DisabledByPolicy:3
Companion device framework disabled by policy.

### -field InvalidAuthenticationStage:4
Not a valid authentication stage.


## -remarks

## -examples

## -see-also
[Windows Unlock with companion (IoT) devices](/windows/uwp/security/companion-device-unlock)