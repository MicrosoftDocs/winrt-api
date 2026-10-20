---
-api-id: P:Windows.Management.Update.WindowsUpdateItem.ProviderId
-api-type: winrt property
---

# Windows.Management.Update.WindowsUpdateItem.ProviderId

<!--
public string ProviderId { get; }
-->


## -description

Gets the identity of the provider that processed the update.

## -property-value

A string value indicating the identity of the provider that processed the update.

## -remarks

Updates serviced by built-in Windows Update have a provider ID such as `WuProvider`. Third-party software-update providers — authored with the [WindowsSoftwareUpdateProvider](./windowssoftwareupdateprovider.md) platform — report their own provider IDs. For provider authoring guidance and samples, see the [microsoft/windows-uop](https://github.com/microsoft/windows-uop) repository.

## -see-also

[WindowsUpdateItem](./windowsupdateitem.md)

## -examples
