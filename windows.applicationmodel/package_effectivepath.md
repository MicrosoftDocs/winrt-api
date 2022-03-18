---
-api-id: P:Windows.ApplicationModel.Package.EffectivePath
-api-type: winrt property
---

<!-- Property syntax.
public string EffectivePath { get; }
-->

# Windows.ApplicationModel.Package.EffectivePath

## -description

Gets either the path of the installed folder or the mutable folder for the installed package, depending on whether the app is declared to be mutable in its package manifest.

## -property-value

The path of the installed folder or the mutable folder for the installed package, depending on whether the app is declared to be mutable in its package manifest.

## -remarks

If the app is declared to be mutable by including the [windows.mutablePackageDirectories extension](/uwp/schemas/appxpackage/uapmanifestschema/element-desktop6-package-extension) in its package manifest, this property gets the path of the mutable folder for the installed package (that is, the folder under C:\Program Files\ModifiableWindowsApps where users can add files that modify the app). If the app is not declared to be mutable, this property gets the same value as the [InstalledPath](package_installedpath.md) property. The mutable folder feature is currently available only for certain types of desktop PC games that are published by Microsoft and our partners, and it enables these types of games to support mods.

## -see-also

[MutablePath](package_mutablepath.md),[InstalledPath](package_installedpath.md)

## -examples
