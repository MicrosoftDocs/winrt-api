---
-api-id: P:Windows.Management.Deployment.AddPackageOptions.LimitToExistingPackages
-api-type: winrt property
---

# Windows.Management.Deployment.AddPackageOptions.LimitToExistingPackages

<!--
public bool LimitToExistingPackages { get; set; }
-->


## -description

Gets or sets a value indicating whether missing referenced packages should be downloaded.

## -property-value

True if missing referenced packages should be download; otherwise, false.

## -remarks

This property is only applicable if a URI to an .appinstaller file is used in the [AddPackageByUri](xref:Windows.Management.Deployment.PackageManager.AddPackageByUriAsync(Windows.Foundation.Uri,Windows.Management.Deployment.AddPackageOptions)) call. This does nothing if the associated URI is for a package.

## -see-also

## -examples


