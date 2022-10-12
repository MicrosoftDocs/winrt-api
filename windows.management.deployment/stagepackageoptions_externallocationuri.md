---
-api-id: P:Windows.Management.Deployment.StagePackageOptions.ExternalLocationUri
-api-type: winrt property
---

## -description

Gets or sets the URI of an external disk location outside of the MSIX package where the package manifest can reference application content.

## -property-value

The URI of an external disk location outside of the MSIX package where the package manifest can reference application content.

## -remarks

This property is intended to be used when you are granting package identity by packaging with external location. A package with external location contains only a package manifest (not an executable or other application content). The package manifest references application content in an external disk location outside of the package.

In this scenario, you can use the **ExternalLocationUri** property to specify the location where your application's executable and other content are installed to. In code that is run by your installer or your application, create a [StagePackageOptions](stagepackageoptions.md) object and assign this property to the external location. Then, call the [StagePackageByUriAsync](packagemanager_stagepackagebyuriasync_446584280.md) method and pass the [StagePackageOptions](stagepackageoptions.md) object to *options* parameter.

## -see-also

[StagePackageOptions](stagepackageoptions.md)

## -examples

