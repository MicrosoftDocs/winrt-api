---
-api-id: P:Windows.ApplicationModel.Package.InstalledPath
-api-type: winrt property
---

<!-- Property syntax.
public string InstalledPath { get; }
-->

# Windows.ApplicationModel.Package.InstalledPath

## -description

Gets the current package's path in the original install folder for the current package.

## -property-value

The current package's path in the original install folder for the current package.

## -remarks

There are several other ways to refer to a file in a package.

+ You can just begin a URI with a "/" to refer to the package root: `<img src="/file.png" alt="" />`
+ You can use the "ms-appx:///" protocol: `<img src="ms-appx://packageFullName/file.png" alt="" />`
+ You can also omit the package name to let the system fill in the domain: `<img src="ms-appx:///file.png" alt="" />`

For more info about how to refer to files in an app's package, see [URI schemes](/windows/uwp/app-resources/uri-schemes) and [Reference an image or other asset from XAML markup and code](/windows/uwp/app-resources/images-tailored-for-scale-theme-contrast#reference-an-image-or-other-asset-from-xaml-markup-and-code).

## -examples

## -see-also

[MutablePath](package_mutablepath.md),[EffectivePath](package_effectivepath.md),[App package information sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=620581)

