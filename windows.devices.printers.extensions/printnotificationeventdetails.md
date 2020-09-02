---
-api-id: T:Windows.Devices.Printers.Extensions.PrintNotificationEventDetails
-api-type: winrt class
---

<!-- Class syntax.
public class PrintNotificationEventDetails : Windows.Devices.Printers.Extensions.IPrintNotificationEventDetails
-->

# Windows.Devices.Printers.Extensions.PrintNotificationEventDetails

## -description
Contains properties that allow a client to access and/or manipulate print event data and print device name information.

## -remarks
Background task handlers can use local storage to save the [PrinterName](printnotificationeventdetails_printername.md) and [EventData](printnotificationeventdetails_eventdata.md) values of the **PrintNotificationEventDetails** class, so that the information can be used later by an app.





```javascript
    // Save the printer name and asyncUI xml
    //
    var keyPrinterName = "BA5857FA-DE2C-4A4A-BEF2-49D8B4130A39";
    var keyAsyncUIXML = "55DCA47A-BEE9-43EB-A7C8-92ECA2FA0685";
    var settings = Windows.Storage.ApplicationData.current.localSettings;

    //
    // The background task instance's activation parameters are available
    // via Windows.UI.WebUI.WebUIBackgroundTaskInstance.current
    //
    var backgroundTaskInstance = Windows.UI.WebUI.WebUIBackgroundTaskInstance.current;

    // Save data into a user-defined var, "settings" 
    var details = backgroundTaskInstance.triggerDetails;
    settings.values[keyPrinterName] = details.printerName;
    settings.values[keyAsyncUIXML] = details.eventData;

    // Save directly into PrintNotificationEventDetails
    Windows.Devices.Printers.Extensions.PrintNotificationEventDetails = details;

```

For more information about using the **PrintNotificationEventDetails** class, see the [UWP device apps for printers](/windows-hardware/drivers/devapps/windows-store-device-apps-for-printers) topic on the Hardware Dev Center.

## -examples

## -see-also
[UWP device apps for printers](/windows-hardware/drivers/devapps/windows-store-device-apps-for-printers)
