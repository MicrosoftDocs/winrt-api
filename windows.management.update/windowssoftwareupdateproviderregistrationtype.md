---
-api-id: T:Windows.Management.Update.WindowsSoftwareUpdateProviderRegistrationType
-api-type: winrt enum
---

# Windows.Management.Update.WindowsSoftwareUpdateProviderRegistrationType

<!--
public enum WindowsSoftwareUpdateProviderRegistrationType
-->


## -description

Defines constants that specify the registration state of a [WindowsSoftwareUpdateProvider](./windowssoftwareupdateprovider.md).

## -enum-fields

### -field None: 0
The provider has no registration state.

### -field System: 1
The provider is a built-in system provider.

### -field Windows: 2
The provider is a built-in Windows provider.

### -field Pending: 3
Registration (or unregistration) of the provider is in progress and has not yet completed.

### -field Registered: 4
The provider is registered with the Windows Update Orchestrator and is eligible to be scanned.

### -field Unregistered: 5
The provider is not registered with the Windows Update Orchestrator.

## -remarks


## -see-also

[WindowsSoftwareUpdateProvider](./windowssoftwareupdateprovider.md)

## -examples

