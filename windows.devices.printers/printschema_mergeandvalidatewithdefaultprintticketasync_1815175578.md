---
-api-id: M:Windows.Devices.Printers.PrintSchema.MergeAndValidateWithDefaultPrintTicketAsync(Windows.Storage.Streams.IRandomAccessStreamWithContentType)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Storage.Streams.IRandomAccessStreamWithContentType> MergeAndValidateWithDefaultPrintTicketAsync(Windows.Storage.Streams.IRandomAccessStreamWithContentType deltaTicket)
-->

# Windows.Devices.Printers.PrintSchema.MergeAndValidateWithDefaultPrintTicketAsync

## -description
Creates a new print ticket by merging the user’s selection with the default print ticket and validating that it will work for the device.

## -parameters
### -param deltaTicket
The delta print ticket, specifies the differences between the default print ticket and the user's selections.

## -returns
An XML PrintTicket document containing the suggested print ticket.

## -remarks
This method attempts to merge the user's selections with a default print ticket - even one for a different 3D printer. The returned print ticket is "suggested" because it may fail upon submission to the 3D printer. If that ticket fails, it indicates that the print ticket is invalid for the printer. If that ticket succeeds, it can be reused by the 3D designer in subsequent submissions.

## -examples

## -see-also
[GetDefaultPrintTicketAsync](printschema_getdefaultprintticketasync.md)