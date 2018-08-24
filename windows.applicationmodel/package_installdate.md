---
-api-id: P:Windows.ApplicationModel.Package.InstallDate
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.DateTime InstallDate { get; }
-->

# Windows.ApplicationModel.Package.InstallDate

## -description
Windows Phone only. Gets the date the application package was installed on the user's phone.

## -property-value
The date the application package was installed on the user's phone.

## -remarks
### Windows Phone 8

If you acquire the [Package](package.md) instance by using the [Windows.ApplicationModel.Package.Current](package_current.md) property, getting the [InstallDate](package_installdate.md) property raises an InvalidCastException. If you want to get the [InstallDate](package_installdate.md) property, acquire the [Package](package.md) instance by using the [Windows.Phone.Management.Deployment.InstallationManager.FindPackagesForCurrentPublisher](../windows.phone.management.deployment/installationmanager_findpackagesforcurrentpublisher_513234922.md) method.

```csharp

using Windows.ApplicationModel;

IEnumerable<Package> packages = Windows.Phone.Management.Deployment.InstallationManager.FindPackagesForCurrentPublisher();
Package package = packages.First();
DateTimeOffset packageInstallDate = package.InstallDate;

```



### Windows 10

This API is not implemented and will throw an exception if called.

## -examples

## -see-also
