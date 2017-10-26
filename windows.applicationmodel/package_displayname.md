---
-api-id: P:Windows.ApplicationModel.Package.DisplayName
-api-type: winrt property
---

<!-- Property syntax
public string DisplayName { get; }
-->

# Windows.ApplicationModel.Package.DisplayName

## -description
Gets the display name of the package.

## -property-value
The display name.

## -remarks
> [!IMPORTANT]
> This property is only supported for UWP app. If you call this property on an instance of a package that was created by any mechanism other than [Package.Current](package_current.md), this property returns an empty string ("").

## -examples

## -see-also
[App package information sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=620581)