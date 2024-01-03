---
-api-id: M:Windows.ApplicationModel.PackageExtensions.PackageExtensionCatalog.RequestRemovePackageAsync(System.String)
-api-type: winrt method
---

# Windows.ApplicationModel.PackageExtensions.PackageExtensionCatalog.RequestRemovePackageAsync(System.String)

<!--
public Windows.Foundation.IAsyncOperation<bool> RequestRemovePackageAsync (string packageFullName);
-->

## -description

Attempts to remove the specified extension package from the machine.

## -parameters

### -param packageFullName

The name of the package to remove, which you can get from [PackageExtension.Package.Id.FullName](../windows.applicationmodel/packageid_fullname.md).

## -returns

Returns **true** if the request to the user to remove the package was made; otherwise, **false**.

This function will return **false** if you try to use a [Package](../windows.applicationmodel/package.md) name that is not associated with an extension in the [PackageExtensionCatalog](packageextensioncatalog.md) instance. The return value doesn't reflect whether the package was actually removed or not. If the user accepts the prompt to remove the package, a [PackageUninstalling](packageextensioncatalog_packageuninstalling.md) event will be raised.

## -remarks

The user is prompted to allow or deny the package removal. You can only remove packages that contain extensions found in the **PackageExtensionCatalog** instance you make the call from.

The unit of deployment for [PackageExtensions](packageextension.md) is the [Package](../windows.applicationmodel/package.md). You cannot remove **PackageExtensions**; you can only remove **Packages**. **Packages** may contain multiple **PackageExtensions**.

The user may not understand the relationship between **PackageExtensions** and **Packages**, or between an **PackageExtension** and an app on the machine (because an app may be designed to also serve as an extension). The user may accept the request to remove a package thinking that they are only removing an extension but then find that one of their favorite apps is now gone. Only use this method if you are certain that the **PackageExtension** is the only thing in the package.

Avoid using this method if you do not control the ecosystem of extensions involved. This method is intended for convenience in a closed ecosystem of extensions, such as in an enterprise environment.

**Desktop Bridge** extension hosts cannot use this method directly. Desktop Bridge extension hosts should use their Universal Windows Platform component to manage package extensions. For more information, see [Building an MSIX package from your code](/windows/msix/desktop/source-code-overview).

## -see-also

[Building an MSIX package from your code](/windows/msix/desktop/source-code-overview), [PackageExtension](packageextension.md), [Package](../windows.applicationmodel/package.md)

## -examples
