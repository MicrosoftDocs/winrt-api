---
-api-id: M:Windows.Management.Update.WindowsSoftwareUpdateProviderStatus.SetScanResult(System.Boolean,System.UInt32,System.UInt64,Windows.Foundation.Collections.IIterable{Windows.Management.Update.WindowsSoftwareUpdate})
-api-type: winrt method
---

# Windows.Management.Update.WindowsSoftwareUpdateProviderStatus.SetScanResult(System.Boolean,System.UInt32,System.UInt64,Windows.Foundation.Collections.IIterable{Windows.Management.Update.WindowsSoftwareUpdate})

<!--
public Windows.Management.Update.WindowsSoftwareUpdateResult SetScanResult (bool succeeded, uint resultCode, ulong extendedError, System.Collections.Generic.IEnumerable<Windows.Management.Update.WindowsSoftwareUpdate> updates);
-->


## -description

Submits the result of a provider scan, including the updates that were discovered.

## -parameters

### -param succeeded

`true` if the scan succeeded; otherwise, `false`.

### -param resultCode

A result code for the scan.

### -param extendedError

Extended error information for the scan, or 0 on success.

### -param updates

The collection of [WindowsSoftwareUpdate](./windowssoftwareupdate.md) objects discovered by the scan.

## -returns

A [WindowsSoftwareUpdateResult](./windowssoftwareupdateresult.md) that indicates whether the submission succeeded.

## -remarks

The orchestrator validates each submitted update against the device's installed-product inventory; updates whose identity doesn't match an installed product are rejected.

## -see-also

[WindowsSoftwareUpdate](./windowssoftwareupdate.md)

## -examples

