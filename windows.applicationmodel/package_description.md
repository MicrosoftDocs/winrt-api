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

On operating systems earlier than 10.0.19041.0, you must call this property on the package returned by [Package.Current](package_current.md), otherwise **Description** will return an empty string.

## -examples

## -see-also
[App package information sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Package)
