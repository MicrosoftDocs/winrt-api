---
-api-id: M:Windows.ApplicationModel.PackageCatalog.OpenForPackage(Windows.ApplicationModel.Package)
-api-type: winrt method
---

# Windows.ApplicationModel.PackageCatalog.OpenForPackage(Windows.ApplicationModel.Package)

<!--
public static Windows.ApplicationModel.PackageCatalog OpenForPackage (Windows.ApplicationModel.Package package);
-->

## -description

Allows listening to any **Package** and its dependents (optional, resource, and hostRuntime).

## -parameters

### -param package

The **Package** which will be monitored for notifications.

## -returns

The **PackageCatalog** used to listen for deployment notifications.

## -remarks

This API requires the **PackageQuery** capability (unless the call is for the current package).

This API allows a package to listen to deployment notifications for another package and its dependents (like PWAs).

## -examples

This example uses the **OpenForPackage** method to listen to notifications on the current package (**Package.Current**). The event handler acts on any optional package that has finished updating.

```csharp
void RegisterForDeploymentNotifications()
{
    if (catalog == null)
    {
        catalog = PackageCatalog.OpenForPackage(Package.Current);
        catalog.PackageUpdating += OptionalPackageUpdatingCallback;
    }
}

void OptionalPackageUpdatingCallback(object sender, PackageUpdatingEventArgs args)
{
    if (args.IsComplete && args.TargetPackage.IsOptional)
    {
        // Let the user know the Optional package has updated, and can be used now
        var messageDialog = new MessageDialog(args.TargetPackage.DisplayName + 
                        " has been updated. Please restart the app to enjoy our latest features.");
    }
}
```

## -see-also

[OpenForCurrentPackage](packagecatalog_openforcurrentpackage_1766019189.md),[Package](package.md),[PackageCatalog](packagecatalog.md)
