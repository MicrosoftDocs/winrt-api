---
-api-id: P:Windows.Management.Update.WindowsUpdate.ProviderId
-api-type: winrt property
---

# Windows.Management.Update.WindowsUpdate.ProviderId

<!--
public string ProviderId { get; }
-->


## -description

Gets the provider ID associated with the [WindowsUpdate](./windowsupdate.md) object.

## -property-value

The provider ID associated with the [WindowsUpdate](./windowsupdate.md) object.

## -remarks

The provider ID indicates which update provider is processing the update. Updates serviced by built-in Windows Update have a provider ID such as `WuProvider`. Third-party software-update providers — authored with the [WindowsSoftwareUpdateProvider](./windowssoftwareupdateprovider.md) platform — report their own provider IDs. For provider authoring guidance and samples, see the [microsoft/windows-uop](https://github.com/microsoft/windows-uop) repository.

## -see-also

[WindowsUpdate](./windowsupdate.md)

## -examples
