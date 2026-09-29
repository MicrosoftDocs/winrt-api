---
-api-id: M:Windows.Management.Update.WindowsSoftwareUpdate.#ctor(System.String,Windows.Management.Update.WindowsSoftwareUpdateInstallationType,System.String,System.String,System.String,Windows.Foundation.Uri,System.UInt64,System.UInt64,Windows.Management.Update.WindowsSoftwareUpdateIdentity,Windows.Management.Update.WindowsSoftwareUpdateVersion,Windows.Management.Update.WindowsSoftwareUpdateVersion,Windows.Management.Update.WindowsSoftwareUpdateAppPackageInfo,Windows.Management.Update.WindowsSoftwareUpdateExecutionInfo,Windows.Management.Update.WindowsSoftwareUpdateOptionalInfo)
-api-type: winrt constructor
---

# Windows.Management.Update.WindowsSoftwareUpdate.#ctor(System.String,Windows.Management.Update.WindowsSoftwareUpdateInstallationType,System.String,System.String,System.String,Windows.Foundation.Uri,System.UInt64,System.UInt64,Windows.Management.Update.WindowsSoftwareUpdateIdentity,Windows.Management.Update.WindowsSoftwareUpdateVersion,Windows.Management.Update.WindowsSoftwareUpdateVersion,Windows.Management.Update.WindowsSoftwareUpdateAppPackageInfo,Windows.Management.Update.WindowsSoftwareUpdateExecutionInfo,Windows.Management.Update.WindowsSoftwareUpdateOptionalInfo)

<!--
public WindowsSoftwareUpdate (string providerId, Windows.Management.Update.WindowsSoftwareUpdateInstallationType installationType, string updateId, string title, string description, System.Uri moreInfoUrl, ulong downloadSizeInBytes, ulong installSizeInBytes, Windows.Management.Update.WindowsSoftwareUpdateIdentity updateIdentity, Windows.Management.Update.WindowsSoftwareUpdateVersion sourceVersion, Windows.Management.Update.WindowsSoftwareUpdateVersion targetVersion, Windows.Management.Update.WindowsSoftwareUpdateAppPackageInfo appPackageInfo, Windows.Management.Update.WindowsSoftwareUpdateExecutionInfo executionInfo, Windows.Management.Update.WindowsSoftwareUpdateOptionalInfo optionalInfo);
-->


## -description

Creates a new [WindowsSoftwareUpdate](./windowssoftwareupdate.md) with all of its defining metadata. A provider calls this during a scan to describe an available update.

## -parameters

### -param providerId

The ID of the provider that owns the update.

### -param installationType

A [WindowsSoftwareUpdateInstallationType](./windowssoftwareupdateinstallationtype.md) that specifies how the update is installed.

### -param updateId

A provider-defined identifier for the update.

### -param title

The default (non-localized) title of the update.

### -param description

The default (non-localized) description of the update.

### -param moreInfoUrl

A URL that links to more information about the update.

### -param downloadSizeInBytes

The download size of the update payload, in bytes.

### -param installSizeInBytes

The installed size of the update, in bytes.

### -param updateIdentity

A [WindowsSoftwareUpdateIdentity](./windowssoftwareupdateidentity.md) that identifies the installed product the update targets.

### -param sourceVersion

The currently installed version of the product, or `null` if not applicable.

### -param targetVersion

The version the product is updated to.

### -param appPackageInfo

A [WindowsSoftwareUpdateAppPackageInfo](./windowssoftwareupdateapppackageinfo.md) for app-package updates, or `null` for other installation types.

### -param executionInfo

A [WindowsSoftwareUpdateExecutionInfo](./windowssoftwareupdateexecutioninfo.md) that describes the actions for executable/PowerShell updates, or `null` for other installation types.

### -param optionalInfo

A [WindowsSoftwareUpdateOptionalInfo](./windowssoftwareupdateoptionalinfo.md) with optional metadata such as category, localization, and compliance timing, or `null`.

## -remarks

Supply `null` for the information objects that don't apply to the update's installation type.

## -see-also

[WindowsSoftwareUpdate](./windowssoftwareupdate.md)

## -examples

