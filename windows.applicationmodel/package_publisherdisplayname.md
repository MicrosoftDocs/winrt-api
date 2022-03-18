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
> [!IMPORTANT]
> This property is only supported for UWP app. If you call this property on an instance of a package that was created by any mechanism other than [Package.Current](package_current.md), this property returns an empty string ("").

## -examples

## -see-also
[App package information sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Package)
