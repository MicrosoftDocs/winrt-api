---
-api-id: M:Windows.Security.Authentication.Identity.Provider.SecondaryAuthenticationFactorRegistration.IsDevicePresenceMonitoringSupported
-api-type: winrt method
---

<!-- Method syntax.
public bool SecondaryAuthenticationFactorRegistration.IsDevicePresenceMonitoringSupported()
-->

# Windows.Security.Authentication.Identity.Provider.SecondaryAuthenticationFactorRegistration.IsDevicePresenceMonitoringSupported

## -description
**Deprecated.** Checks whether the main device is able to monitor for the presence of companion devices.

> [!NOTE]
> This API is not available to all apps. Unless your developer account is specially provisioned by Microsoft to use the **secondaryAuthenticationFactor** capability, calls to this API will fail. To apply for approval, contact [cdfonboard@microsoft.com](mailto:cdfonboard@microsoft.com). For more information on capabilities, see [App capability declarations](/windows/uwp/packaging/app-capability-declarations). For an overview of the Companion Device Framework, see the [Windows Unlock with companion (IoT) devices](/windows/uwp/security/companion-device-unlock) overview.

## -returns
A value of **true** if the device can monitor companion devices, otherwise **false**.

## -remarks

## -see-also

## -examples