---
-api-id: P:Windows.Management.Deployment.RegisterPackageOptions.ExternalLocationUri
-api-type: winrt property
---

## -description

Gets or sets the URI of an external disk location outside of the MSIX [Package](/uwp/api/windows.applicationmodel.package) where the package manifest can reference application content.

## -property-value

The URI of an external disk location outside of the MSIX package where the package manifest can reference application content.

## -remarks

This property can be used when you are granting package identity by packaging with external location. A package with external location contains only a package manifest (not an executable or other application content). The package manifest references application content in an external disk location outside of the package.

In this scenario, you can use the **ExternalLocationUri** property to specify the location where your application's executable and other content are installed to. In code that is run by your installer or your application, create a [RegisterPackageOptions](registerpackageoptions.md) object and assign this property to the external location. Then, call the [RegisterPackageByUriAsync](packagemanager_registerpackagebyuriasync_1415074502.md) method and pass the [RegisterPackageOptions](registerpackageoptions.md) object to *options* parameter.

In most cases, we recommend that you use the [ExternalLocationUri](addpackageoptions_externallocationuri.md) property of an [AddPackageOptions](addpackageoptions.md) object in conjunction with the [AddPackageByUriAsync](packagemanager_addpackagebyuriasync_797417417.md) method instead of this property and the [RegisterPackageByUriAsync](packagemanager_registerpackagebyuriasync_1415074502.md) method.

## -see-also

[Package](/uwp/api/windows.applicationmodel.package), [RegisterPackageOptions](registerpackageoptions.md)

## -examples

