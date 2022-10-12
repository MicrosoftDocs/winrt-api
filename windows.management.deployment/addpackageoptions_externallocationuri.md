---
-api-id: P:Windows.Management.Deployment.AddPackageOptions.ExternalLocationUri
-api-type: winrt property
---

## -description

Gets or sets the URI of an external disk location outside of the MSIX package where the package manifest can reference application content.

## -property-value

The URI of an external disk location outside of the MSIX package where the package manifest can reference application content.

## -remarks

This property is intended to be used when you are granting package identity by packaging with external location. A package with external location contains only a package manifest (not an executable or other application content). The package manifest references application content in an external disk location outside of the package.

In this scenario, you can use this property property to specify the location where your application's executable and other content are installed to. In code that is run by your installer or your application, create a [AddPackageOptions](addpackageoptions.md) object and assign this property to the external location. Then, call the [AddPackageByUriAsync](packagemanager_addpackagebyuriasync_797417417.md) method and pass the [AddPackageOptions](addpackageoptions.md) object to *options* parameter.

## -see-also

[AddPackageOptions](addpackageoptions.md)

## -examples

