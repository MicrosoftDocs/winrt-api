---
-api-id: P:Windows.ApplicationModel.Package.Current
-api-type: winrt property
---

<!-- Property syntax
public Windows.ApplicationModel.Package Current { get; }
-->

# Windows.ApplicationModel.Package.Current

## -description
Gets the package for the current app.

## -property-value
The package.

## -remarks

> [!IMPORTANT]
> Although the [Package](package.md) class is supported in an unpackaged process (that is, a process belonging to an app that lacks package identity), the **Package.Current** property is supported only in a *packaged* process (that is, a process belonging to an app that *has* package identity). To access a package object from an unpackaged process, use [Windows.Management.Deployment.PackageManager](../windows.management.deployment/packagemanager.md). And for more info about packaging, see [Package a desktop or UWP app in Visual Studio](/windows/msix/package/packaging-uwp-apps).

## -examples

## -see-also
[App package information sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Package)
