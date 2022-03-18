---
-api-id: N:Windows.Security.Authentication.Identity.Provider
-api-type: winrt namespace
---

# Windows.Security.Authentication.Identity.Provider

## -description
Supports unlocking Windows with a companion device.

> [!NOTE]
> This API is not available to all apps. Unless your developer account is specially provisioned by Microsoft to use the **secondaryAuthenticationFactor** capability, calls to this API will fail. To apply for approval, contact [cdfonboard@microsoft.com](mailto:cdfonboard@microsoft.com). For more information on capabilities, see [App capability declarations](/windows/uwp/packaging/app-capability-declarations).

## -remarks
A companion device is a device that cannot act as a standalone authenticator but can function as a companion to an authenticator for better user experience. The companion device must have a corresponding UWP app that can receive authentication information from the device (such as biometric info) and pass it on to the main device through the APIs in this namespace.

## -examples

## -see-also
[Windows Unlock with companion (IoT) devices](/windows/uwp/security/companion-device-unlock)