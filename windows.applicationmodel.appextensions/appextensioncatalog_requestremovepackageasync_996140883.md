---
-api-id: M:Windows.ApplicationModel.AppExtensions.AppExtensionCatalog.RequestRemovePackageAsync(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<bool> RequestRemovePackageAsync(System.String packageFullName)
-->

# Windows.ApplicationModel.AppExtensions.AppExtensionCatalog.RequestRemovePackageAsync

## -description

Attempts to remove the specified extension package from the machine.

## -parameters

### -param packageFullName

The name of the package to remove, which you can get from [AppExtension.Package.Id.FullName](/uwp/api/windows.applicationmodel.packageid).

## -returns

Returns **true** if the request to the user to remove the package was made; otherwise, **false**.

This function will return **false** if you try to use a **Package** name that is not associated with an extension in the **AppExtensionCatalog** instance. The return value doesn't reflect whether the package was actually removed or not. If the user accepts the prompt to remove the package, a [PackageUninstalling](appextensioncatalog_packageuninstalling.md) event will be raised.

## -remarks

The user is prompted to allow or deny the package removal. You can only remove packages that contain extensions found in the **AppExtensionCatalog** instance you make the call from. See [AppExtensionCatalog::Open](/uwp/api/windows.applicationmodel.appextensions.appextensioncatalog.open) for more details.

The unit of deployment for [AppExtensions](appextension.md) is the [Package](/uwp/api/windows.applicationmodel.package). You cannot remove **AppExtensions**; you can only remove **Packages**. **Packages** may contain multiple **AppExtensions**.

The user may not understand the relationship between **AppExtensions** and **Packages**, or between an **AppExtension** and an app on the machine (because an app may be designed to also serve as an extension). The user may accept the request to remove a package thinking that they are only removing an extension but then find that one of their favorite apps is now gone. Only use this method if you are certain that the **AppExtension** is the only thing in the package.

Avoid using this method if you do not control the ecosystem of extensions involved. This method is intended for convenience in a closed ecosystem of extensions, such as in an enterprise environment.

**Desktop Bridge** app extension hosts cannot use this method directly. Desktop Bridge app extension hosts should use their Universal Windows Platform component to manage app extensions. For more information, see [Building an MSIX package from your code](/windows/msix/desktop/source-code-overview).

## -examples

## -see-also

[Building an MSIX package from your code](/windows/msix/desktop/source-code-overview)
