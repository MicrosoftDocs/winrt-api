---
-api-id: M:Windows.Devices.PointOfService.JournalPrintJob.ExecuteAsync
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<bool> ExecuteAsync()
-->

# Windows.Devices.PointOfService.JournalPrintJob.ExecuteAsync

## -description
Runs the print job on the journal printer station asynchronously.

## -returns
The operation to run the print job. This operation returns true if the print job succeeds; otherwise, the operation returns false.

## -remarks
The print job is sent to the claimed printer station object that created the print job.
The claimed printer station object must remain valid when calling this method.

## -examples

## -see-also
[IPosPrinterJob.ExecuteAsync](iposprinterjob_executeasync_2108924004.md)
