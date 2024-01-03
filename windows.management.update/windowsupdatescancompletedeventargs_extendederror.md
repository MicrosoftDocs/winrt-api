---
-api-id: P:Windows.Management.Update.WindowsUpdateScanCompletedEventArgs.ExtendedError
-api-type: winrt property
---

# Windows.Management.Update.WindowsUpdateScanCompletedEventArgs.ExtendedError

<!--
public System.Exception ExtendedError { get; }
-->


## -description

Gets detailed information about an error associated with a completed scan event.

## -property-value

A **HRESULT** value containing detailed information about an error associated with a completed scan event.

## -remarks

If the scan completed successfully, then the value is **S_OK** (0). Otherwise, the value is an error code explaining why the scan failed.

## -see-also

## -examples
