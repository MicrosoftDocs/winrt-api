---
-api-id: T:Windows.Management.Update.WindowsSoftwareUpdateInstallationType
-api-type: winrt enum
---

# Windows.Management.Update.WindowsSoftwareUpdateInstallationType

<!--
public enum WindowsSoftwareUpdateInstallationType
-->


## -description

Defines constants that specify how a [WindowsSoftwareUpdate](./windowssoftwareupdate.md) is installed on the device.

## -enum-fields

### -field WindowsUpdate: 0
The update is serviced by the built-in Windows Update provider.

### -field AppPackage: 1
The update installs an MSIX/AppX application package. The system performs the installation using the package information supplied in [WindowsSoftwareUpdateAppPackageInfo](./windowssoftwareupdateapppackageinfo.md).

### -field Executable: 2
The update is applied by invoking a provider-supplied executable for each update action (download, install, deploy, restart).

### -field Powershell: 3
The update is applied by invoking a provider-supplied PowerShell script for each update action.

## -remarks

The installation type determines which information a provider must supply when constructing a [WindowsSoftwareUpdate](./windowssoftwareupdate.md). **Executable** and **Powershell** updates supply a [WindowsSoftwareUpdateExecutionInfo](./windowssoftwareupdateexecutioninfo.md); **AppPackage** updates supply a [WindowsSoftwareUpdateAppPackageInfo](./windowssoftwareupdateapppackageinfo.md).

## -see-also

[WindowsSoftwareUpdate](./windowssoftwareupdate.md), [WindowsSoftwareUpdateProviderType](./windowssoftwareupdateprovidertype.md)

## -examples

