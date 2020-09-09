---
-api-id: P:Windows.ApplicationModel.Package.MutablePath
-api-type: winrt property
---

<!-- Property syntax.
public string MutablePath { get; }
-->

# Windows.ApplicationModel.Package.MutablePath

## -description

Gets the current package's path in the mutable folder for the installed package, if the app is declared to be mutable in its package manifest.

## -property-value

The location of the mutable folder for the installed package.

## -remarks

If the app is declared to be mutable by including the [windows.mutablePackageDirectories extension](/uwp/schemas/appxpackage/uapmanifestschema/element-desktop6-package-extension) in its package manifest, it exposes a folder under C:\Program Files\ModifiableWindowsApps where the contents of the application's install folder are projected so that users can modify the installation files. This folder is called the *mutable folder*. The mutable folder feature is currently available only for certain types of desktop PC games that are published by Microsoft and our partners, and it enables these types of games to support mods.

## -see-also

[InstalledPath](package_installedpath.md),[EffectivePath](package_effectivepath.md)

## -examples

