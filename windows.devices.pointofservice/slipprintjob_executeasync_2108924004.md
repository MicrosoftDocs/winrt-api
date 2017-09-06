---
-api-id: M:Windows.Devices.PointOfService.SlipPrintJob.ExecuteAsync
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<bool> ExecuteAsync()
-->

# Windows.Devices.PointOfService.SlipPrintJob.ExecuteAsync

## -description
Runs the print job on the slip printer station asynchronously.

## -returns
The operation to run the print job. This operation returns true if the print job succeeds; otherwise, the operation returns false.

## -remarks
The print job is sent to the claimed printer station object that created the print job.
The claimed printer station object must remain valid when calling this method.

## -examples

## -see-also
[IPosPrinterJob.ExecuteAsync](iposprinterjob_executeasync.md)
