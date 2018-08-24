---
-api-id: M:Windows.Devices.PointOfService.IPosPrinterJob.ExecuteAsync
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<bool> ExecuteAsync()
-->

# Windows.Devices.PointOfService.IPosPrinterJob.ExecuteAsync

## -description
Runs the print job on the printer station asynchronously.

## -returns
The operation to run the print job. This operation returns true if the print job succeeds; otherwise, the operation returns false.

## -remarks
The print job is sent to the claimed printer station object that created the print job.
The claimed printer station object must remain valid when calling this method.

## -examples

## -see-also
[JournalPrintJob.ExecuteAsync](journalprintjob_executeasync_2108924004.md), [ReceiptPrintJob.ExecuteAsync](receiptprintjob_executeasync_2108924004.md), [SlipPrintJob.ExecuteAsync](slipprintjob_executeasync_2108924004.md)
