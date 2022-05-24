---
-api-id: P:Windows.ApplicationModel.AppInstallerInfo.PolicySource
-api-type: winrt property
---

# Windows.ApplicationModel.AppInstallerInfo.PolicySource

<!--
public Windows.ApplicationModel.AppInstallerPolicySource PolicySource { get; }
-->


## -description

Gets a value from the [AppInstallerPolicySource](appinstallerpolicysource.md) enumeration indicating whether the update policy specified in the **AppInstallerInfo** was set using from a system or default source.

## -property-value

The source of the policy represented by the **AppInstallerInfo*.

## -remarks

The policy source is **Default** if the policy was set using [AppInstallerManager.GetDefault](../windows.management.deployment/appinstallermanager_getdefault_846721868.md). The policy source is **System** if the policy was set using [AppInstallerManager.GetForSystem](../windows.management.deployment/appinstallermanager_getforsystem_1121253078.md).

## -see-also

## -examples


