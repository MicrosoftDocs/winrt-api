---
-api-id: N:Windows.Embedded.DeviceLockdown
-api-type: winrt namespace
---

# Windows.Embedded.DeviceLockdown

## -description

Provides a simple and consistent interface for locking down the available applications and tiles on the device for specific user roles defined by the enterprise.

These APIs are available in the Mobile Extension SDK.

## -remarks

In order to use this API, you need to first configure roles that are deployed using the [EnterpriseAssignedAccess CSP](https://msdn.microsoft.com/library/windows/hardware/mt157024.aspx).

The device lockdown APIs in [Windows.Embedded.DeviceLockdown](windows_embedded_devicelockdown.md) require the **enterpriseDeviceLockdown** capability, which allows you to use a standard enterprise certificate. This capability is not available to standard 3rd party developers where the certificate is provided through Visual Studio. At this time, you must manually include this capability in your manifest file. For instructions about how to manually update your manifest file and more details about device capabilities, see [app capability declarations](https://msdn.microsoft.com/library/windows/apps/mt270968.aspx).

## -examples

## -see-also

[Device lockdown with Azure login sample (Windows 10)](http://go.microsoft.com/fwlink/?LinkID=703786)