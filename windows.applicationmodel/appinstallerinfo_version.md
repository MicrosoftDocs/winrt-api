---
-api-id: P:Windows.ApplicationModel.AppInstallerInfo.Version
-api-type: winrt property
---

# Windows.ApplicationModel.AppInstallerInfo.Version

<!--
public Windows.ApplicationModel.PackageVersion Version { get; }
-->


## -description

Gets a [PackageVersion](packageversion.md) object expressing the version of the App Installer file represented by the **AppInstallerInfo** object.

## -property-value

The version of the App Installer file.

## -remarks

Note that this is the version of the App Installer file itself, not the version of the schema the App Installer uses, and will typically be assigned to match the version of the main package the installer file is associated with.

This property is equivalent to the *Version* attribute of the [AppInstaller](/uwp/schemas/appinstallerschema/element-appinstaller) element of the App Installer file schema.

## -see-also

## -examples


