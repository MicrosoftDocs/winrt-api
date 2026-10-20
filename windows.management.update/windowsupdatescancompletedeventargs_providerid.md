---
-api-id: P:Windows.Management.Update.WindowsUpdateScanCompletedEventArgs.ProviderId
-api-type: winrt property
---

# Windows.Management.Update.WindowsUpdateScanCompletedEventArgs.ProviderId

<!--
public string ProviderId { get; }
-->


## -description

Gets the provider ID associated with the scan-completed event.

## -property-value

A string value containing the provider ID associated with the scan-completed event.

## -remarks

The provider ID indicates which update provider was used for the scan. Updates serviced by built-in Windows Update have a provider ID such as `WuProvider`. Third-party software-update providers — authored with the [WindowsSoftwareUpdateProvider](./windowssoftwareupdateprovider.md) platform — report their own provider IDs. For provider authoring guidance and samples, see the [microsoft/windows-uop](https://github.com/microsoft/windows-uop) repository.

## -see-also

[WindowsUpdateScanCompletedEventArgs](./windowsupdatescancompletedeventargs.md)

## -examples
