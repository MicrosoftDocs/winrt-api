---
-api-id: T:Windows.Management.Deployment.DeploymentOptions
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Management.Deployment.DeploymentOptions : uint
-->

# DeploymentOptions

## -description
Specifies the package deployment options.

## -enum-fields
### -field None:0
The default behavior is used.

### -field ForceApplicationShutdown:1
If this package, or any package that depends on this package, is currently in use, the processes associated with the package are shut down forcibly so that registration can continue.

### -field DevelopmentMode:2
When you set this option, the app is installed in development mode. For info about development mode, see **Remarks**. Use this option to enable key app development scenarios.You can't use this option in conjunction with a bundle package. If you use this option with a bundle package, your call returns ERROR_INSTALL_FAILED.

### -field InstallAllResources:32
When you set this option, the app is instructed to skip resource applicability checks. This effectively stages or registers all resource packages that a user passes in to the command, which forces applicability for all packages contained in a bundle. If a user passes in a bundle, all contained resource packages will be registered. Windows only.

### -field ForceTargetApplicationShutdown:64
If this package is currently in use, the processes associated with the package are shut down forcibly so that registration can continue.

### -field RequiredContentGroupOnly:256
When you set this option, only the required content group will be staged. An app can be installed as a package with the required content group alone.

## -remarks
You can use the **DevelopmentMode** option to install apps without requiring an app package. Instead, the deployment engine processes the AppxManifest.xml file directly, which allows for a more rapid development cycle. The BlockMap.xml, [Content_Types].xml, and digital signature files are not required for app installation in **DevelopmentMode**.


To successfully install an app in **DevelopmentMode**, it must meet these additional conditions beyond what is typically required for Windows Store app:

+ The app must be unique to the current user account. No other user can have an app with the same package family name installed on the computer.
+ If a previous version of the app was installed, the previous version must also be installed in **DevelopmentMode**. Windows Store app can't be updated with a **DevelopmentMode** app and vice versa.
+ The app must be on an Microsoft Windows NT File System (NTFS) partition. Partitions with other formats are unsupported.
+ The app must be on a local drive. Installation from network locations is unsupported.
+ The app must be in an unencrypted location. Installation from encrypted directories is unsupported.
+ The app can't be installed from the WindowsApps directory.
If any of the preceding conditions aren't met, installation fails.


Additionally, to simplify and enhance the app development experience, these key operating system behaviors are modified when an app is installed in **DevelopmentMode**:

+ App payload files can be modified. If you modify an app payload file, the changes are reflected next time the app is launched. You don't need to reinstall the app unless you modify the AppxManifest.xml file.
+ Bytecode generation and NGEN are disabled. JS bytecode generation and .NET binary NGEN are disabled on **DevelopmentMode** packages to let you modify payload files without reinstalling your app.
+ App payload files aren't removed when the app is uninstalled. Because these files are potentially your source code, Windows doesn't delete these files when an app is uninstalled.
+ Network loopback is allowed. You must opt-in to network loopback as described in [How to enable loopback and troubleshoot network isolation](http://msdn.microsoft.com/library/1ba27347-56ff-453f-83c9-56b9bd1f5092).
+ The app can be launched in [DesignMode](../windows.applicationmodel/designmode.md). For info about the [DesignMode class](../windows.applicationmodel/designmode.md), see [DesignMode class](../windows.applicationmodel/designmode.md).


## -examples

## -see-also
[PackageManager.AddPackageAsync](packagemanager_addpackageasync.md), [PackageManager.RegisterPackageAsync](packagemanager_registerpackageasync.md), [PackageManager.UpdatePackageAsync](packagemanager_updatepackageasync.md)

