---
-api-id: P:Windows.ApplicationModel.Package.InstalledLocation
-api-type: winrt property
---

<!-- Property syntax
public Windows.Storage.StorageFolder InstalledLocation { get; }
-->

# Windows.ApplicationModel.Package.InstalledLocation

## -description
Gets the location of the installed package.

## -property-value
The location of the installed package.

## -remarks
There are several other ways to refer to the a file in a package.


+ You can just begin a URI with a "/" to refer to the package root. For example: `<img src="/file.png" alt="" />`
+ You can use the "ms-appx:///" protocol. For example:`<img src="ms-appx://packageFullName/file.png" alt="" />`
+ You can also omit the package name to let the system fill in the domain, as shown here:

`<img src="ms-appx:///file.png" alt="" />`
For more info about how to refer to files in an app's package, see [How to load file resources](https://msdn.microsoft.com/library/2fc07702-7022-44b7-8471-8d477a105fc5).

## -examples

## -see-also
[App package information sample](https://code.msdn.microsoft.com/windowsapps/Package-sample-46e239fa), [App package information sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=620581)
