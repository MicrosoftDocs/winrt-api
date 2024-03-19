---
-api-id: P:Windows.ApplicationModel.Package.PublisherDisplayName
-api-type: winrt property
---

<!-- Property syntax
public string PublisherDisplayName { get; }
-->

# Windows.ApplicationModel.Package.PublisherDisplayName

## -description
Gets the publisher display name of the package.

## -property-value
The publisher display name.

## -remarks

On operating systems earlier than 10.0.19041.0, you must call this property on the package returned by [Package.Current](package_current.md), otherwise **PublisherDisplayName** will return an empty string.

## -examples

## -see-also
[App package information sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Package)
