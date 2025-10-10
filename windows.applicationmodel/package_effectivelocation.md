---
-api-id: P:Windows.ApplicationModel.Package.EffectiveLocation
-api-type: winrt property
ms.custom: 19H1
---

<!-- Property syntax.
public StorageFolder EffectiveLocation { get; }
-->

# Windows.ApplicationModel.Package.EffectiveLocation

## -description

Gets the effective location for the installed package, depending on how the app is declared in its package manifest. For details, see **Remarks**.

## -property-value

The effective location for the installed package, depending on how the app is declared in its package manifest. For details, see **Remarks**.

## -remarks

If the package has a User-External location, then get that folder. Otherwise, if the package has a Machine-External location, then get that folder. Otherwise, if the package has a [Mutable location](/uwp/schemas/appxpackage/uapmanifestschema/element-desktop8-mutablepackagedirectories), then get the Mutable folder for the installed package (that is, the folder under `C:\Program Files\ModifiableWindowsApps` where users can add files that modify the app). Also see [Create a directory in any location based on packaged app directory](/windows/msix/manage/create-directory). Otherwise, get the same value as the [InstalledLocation](package_installedlocation.md) property. The mutable folder feature is currently available only for certain types of desktop PC games that are published by Microsoft and partners, and it enables those types of games to support modifications (mods).

## -see-also

[MutableLocation](package_mutablelocation.md),[InstalledLocation](package_installedlocation.md)

## -examples
