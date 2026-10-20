---
-api-id: T:Windows.Management.Update.WindowsSoftwareUpdateProviderType
-api-type: winrt enum
---

# Windows.Management.Update.WindowsSoftwareUpdateProviderType

<!--
public enum WindowsSoftwareUpdateProviderType
-->


## -description

Defines constants that specify how a registered [WindowsSoftwareUpdateProvider](./windowssoftwareupdateprovider.md) is invoked to perform scan and update actions.

## -enum-fields

### -field WindowsUpdate: 0
A built-in provider serviced by Windows Update.

### -field Executable: 1
A provider whose scan and actions are performed by invoking a signed executable.

### -field Powershell: 2
A provider whose scan and actions are performed by invoking a signed PowerShell script.

## -remarks

The provider type is declared in the provider's `provider.json` manifest and surfaced through [WindowsSoftwareUpdateProvider.Type](./windowssoftwareupdateprovider_type.md). For the manifest format, see the provider authoring guide in the [windows-uop](https://github.com/microsoft/windows-uop) repository.

## -see-also

[WindowsSoftwareUpdateProvider](./windowssoftwareupdateprovider.md)

## -examples

