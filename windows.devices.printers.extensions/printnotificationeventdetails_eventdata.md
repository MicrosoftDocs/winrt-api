---
-api-id: P:Windows.Devices.Printers.Extensions.PrintNotificationEventDetails.EventData
-api-type: winrt property
---

<!-- Property syntax
public string EventData { get;  set; }
-->

# Windows.Devices.Printers.Extensions.PrintNotificationEventDetails.EventData

## -description
Gets or sets the event data for a print notification event.

## -property-value
The print notification event data.

## -remarks
The  property is nested XML that is formatted as string. To get this property, parse for the Bidi request and response schema that is embedded in an `<Envelope>`, following the AsyncUI's [balloonUI](/windows-hardware/drivers/print/balloonui) element message, which contains the [action](/windows-hardware/drivers/print/action) element. The [action](/windows-hardware/drivers/print/action) element contains the `<Envelope>` where the Bidi response schema is found. Examine the Bidi response to determine the cause of the event.



## -examples

## -see-also
