---
-api-id: P:Windows.ApplicationModel.Package.Description
-api-type: winrt property
---

<!-- Property syntax
public string Description { get; }
-->

# Windows.ApplicationModel.Package.Description

## -description
Gets the description of the package.

## -property-value
The description of the package.

## -remarks
> [!IMPORTANT]
> This property is only supported for UWP app. If you call this property on an instance of a package that was created by any mechanism other than [Package.Current](package_current.md), this property returns an empty string ("").

## -examples

## -see-also
[App package information sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Package)
