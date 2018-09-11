---
-api-id: M:Windows.Devices.PointOfService.ClaimedSlipPrinter.InsertSlipAsync(Windows.Foundation.TimeSpan)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<bool> InsertSlipAsync(Windows.Foundation.TimeSpan timeout)
-->

# Windows.Devices.PointOfService.ClaimedSlipPrinter.InsertSlipAsync

## -description
Waits for the user to insert a slip into the slip printer station.

## -parameters
### -param timeout
The interval of time that the operation should wait for the user to insert the slip before exiting.

## -returns
An asynchronous operation that returns true if the user inserts the slip within the specified time span, and returns false otherwise.

## -remarks

## -examples

## -see-also
[RemoveSlipAsync](claimedslipprinter_removeslipasync_1430912393.md), [OpenJaws](claimedslipprinter_openjaws_1310830337.md), [CloseJaws](claimedslipprinter_closejaws_455707994.md)