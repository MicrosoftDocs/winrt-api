---
-api-id: M:Windows.Management.Deployment.AppInstallerManager.GetDefault
-api-type: winrt method
---

# Windows.Management.Deployment.AppInstallerManager.GetDefault

<!--
public static Windows.Management.Deployment.AppInstallerManager GetDefault ();
-->


## -description

Retrieves an instance of [AppInstallerManager](appinstallermanager.md) with default priority.

## -returns

An instance of **AppInstallerManager** with default priority.

## -remarks

**AppInstallerManager** methods called on an instance with default priority will replace values set by the most recent update or add the settings if an entry doesn’t already exist. Similarly, when an update takes place, the update will override these settings. To have the settings persist, use the **AppInstallerManager** returned by [AppInstallerManager.GetForSystem](appinstallermanager_getforsystem_1121253078.md).

## -see-also

[AppInstallerManager.GetForSystem](appinstallermanager_getforsystem_1121253078.md)

## -examples


