---
-api-id: N:Windows.Embedded.DeviceLockdown
-api-type: winrt namespace
---

# Windows.Embedded.DeviceLockdown

## -description

Provides a simple and consistent interface for locking down the available applications and tiles on the device for specific user roles defined by the enterprise.

These APIs are available in the Mobile Extension SDK.

## -remarks

In order to use this API, you need to first configure roles that are deployed using the [EnterpriseAssignedAccess CSP](/windows/client-management/mdm/enterpriseassignedaccess-csp).

The device lockdown APIs in Windows.Embedded.DeviceLockdown require the **enterpriseDeviceLockdown** capability, which allows you to use a standard enterprise certificate. This capability is not available to standard 3rd party developers where the certificate is provided through Visual Studio. At this time, you must manually include this capability in your manifest file. For instructions about how to manually update your manifest file and more details about device capabilities, see [app capability declarations](/windows/uwp/packaging/app-capability-declarations).

## -examples

## -see-also

[Device lockdown with Azure login sample](https://github.com/lotzi11/Windows-universal-samples/blob/master/Samples/DeviceLockdownAzureLogin/README.md)
