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

Gets either the location of the installed folder or the mutable folder for the installed package, depending on whether the app is declared to be mutable in its package manifest.

## -property-value

The location of the installed folder or the mutable folder for the installed package, depending on whether the app is declared to be mutable in its package manifest.

## -remarks

If the app is declared to be mutable by including the [windows.mutablePackageDirectories extension](/uwp/schemas/appxpackage/uapmanifestschema/element-desktop6-package-extension) in its package manifest, this property gets the mutable folder for the installed package (that is, the folder under C:\Program Files\ModifiableWindowsApps where users can add files that modify the app). If the app is not declared to be mutable, this property gets the same value as the [InstalledLocation](package_installedlocation.md) property. The mutable folder feature is currently available only for certain types of desktop PC games that are published by Microsoft and our partners, and it enables these types of games to support mods.

## -see-also

[MutableLocation](package_mutablelocation.md),[InstalledLocation](package_installedlocation.md)

## -examples

