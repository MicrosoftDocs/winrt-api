---
-api-id: T:Windows.Devices.Printers.Extensions.PrintExtensionContext
-api-type: winrt class
---

<!-- Class syntax.
public class PrintExtensionContext 
-->

# Windows.Devices.Printers.Extensions.PrintExtensionContext

## -description
Provides the context for the printer extension object.

## -remarks
The following JavaScript code snippet retrieves the **PrinterExtensionContext** using a [DeviceInformation](../windows.devices.enumeration/deviceinformation.md) ID, and then uses the context to create a helper object:





```javascript
// This function runs when the user taps the Back button
function getInkStatus(deviceInformationId) {
    var responseString;
    try {
        var context = Windows.Devices.Printers.Extensions.
            PrintExtensionContext.fromDeviceId(deviceInformationId);
        var helper = new Microsoft.Samples.Printing.WwaDca.
            PrintHelperClass(context);
        var responseString = helper.getInkLevel(1);
    } catch (e) {
        responseString = "deviceInformationId: " + deviceInformationId + 
            " Message: " + e.message;
    }
    return responseString
}

```

For more information about using the **PrinterExtensionContext** class, see the [UWP device apps for printers](/windows-hardware/drivers/devapps/windows-store-device-apps-for-printers) topic on the Hardware Dev Center.

## -examples

## -see-also
[DeviceInformation class](/uwp/api/windows.devices.enumeration.deviceinformation), [UWP device apps for printers](/windows-hardware/drivers/devapps/windows-store-device-apps-for-printers)
