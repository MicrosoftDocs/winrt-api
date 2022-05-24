---
-api-id: T:Windows.ApplicationModel.AppInstallerPolicySource
-api-type: winrt enum
---

# Windows.ApplicationModel.AppInstallerPolicySource

<!--
public enum AppInstallerPolicySource
-->


## -description

Specifies the whether the source of the update policy for an app.

## -enum-fields

### -field Default: 0

Default policy source.

### -field System: 1

System policy source.

## -remarks

The policy source is **Default** if the policy was set using [AppInstallerManager.GetDefault](../windows.management.deployment/appinstallermanager_getdefault_846721868.md). The policy source is **System** if the policy was set using [AppInstallerManager.GetForSystem](../windows.management.deployment/appinstallermanager_getforsystem_1121253078.md). If a policy was set from a **System** source, then any of the [AppInstallerManager](../windows.management.deployment/appinstallermanager.md) methods acting on that *PackageFamilyName* must also be called from a **System** source.

## -see-also

## -examples


