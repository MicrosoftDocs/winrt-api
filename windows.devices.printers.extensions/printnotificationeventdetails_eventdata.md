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
The  property is nested XML that is formatted as string. To get this property, parse for the Bidi request and response schema that is embedded in an `<Envelope>`, following the AsyncUI's [balloonUI](http://msdn.microsoft.com/library/8db15dcb-26ed-429e-ad4c-e5dc59f9bbca) element message, which contains the [action](http://msdn.microsoft.com/library/dae207ad-072e-4de6-b6a2-f1188ce91065) element. The [action](http://msdn.microsoft.com/library/dae207ad-072e-4de6-b6a2-f1188ce91065) element contains the `<Envelope>` where the Bidi response schema is found. Examine the Bidi response to determine the cause of the event.



## -examples

## -see-also
