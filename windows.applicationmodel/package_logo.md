---
-api-id: P:Windows.ApplicationModel.Package.Logo
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Uri Logo { get; }
-->

# Windows.ApplicationModel.Package.Logo

## -description
Gets the logo of the package.

## -property-value
The logo of the package.

## -remarks

On operating systems earlier than 10.0.19041.0, you must call this property on the package returned by [Package.Current](package_current.md), otherwise **Logo** will throw an exception.

## -examples

## -see-also
[App package information sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Package)
