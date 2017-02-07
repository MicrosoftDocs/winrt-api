---
-api-id: T:Windows.Devices.Input.PointerDevice
-api-type: winrt class
---

<!-- Class syntax.
public class PointerDevice : Windows.Devices.Input.IPointerDevice, Windows.Devices.Input.IPointerDevice2
-->

# Windows.Devices.Input.PointerDevice

## -description
Supports the ability to identify the connected pointer devices and determine their capabilities.

## -remarks
The values returned by the properties discussed here are based on the total number of pointer devices connected: Boolean properties return true if one device supports a specific capability and numeric properties return the maximum value exposed by all devices.

The [Device Capabilities Sample](http://go.microsoft.com/fwlink/p/?linkid=231530) demonstrates how to detect the presence of input devices and retrieve the capabilities and attributes of each device.

> [!NOTE]
> : This class is not agile, which means that you need to consider its threading model and marshaling behavior. For more info, see [Threading and Marshaling (C++/CX)](http://go.microsoft.com/fwlink/p/?linkid=258275) and [Using Windows Runtime objects in a multithreaded environment (.NET)](http://go.microsoft.com/fwlink/p/?linkid=258277).

## -examples
The following code shows how to use [PointerDevice](pointerdevice.md).

```javascript
function getPointerDevicesAndAttributes() {
    var pointerDevices = Windows.Devices.Input.PointerDevice.GetPointerDevices();
    var htmlWrite = "";
    for (i = 0; i < pointerDevices.Size; i++)  {
         htmlWrite += "<tr><td>(" + i + ") Pointer Device Type</td><td>";
         htmlWrite += getPointerDeviceType(pointerDevices[i].PointerDeviceType) + "</td></tr>";
         htmlWrite += "<tr><td>(" + i + ") Is External</td><td>" + pointerDevices[i].IsExternal + "</td></tr>";
         htmlWrite += "<tr><td>(" + i + ") Max Contacts</td><td>" + pointerDevices[i].MaxContacts + "</td></tr>";
         htmlWrite += "<tr><td>(" + i + ") Physical Device Rect</td><td>" +
             pointerDevices[i].PhysicalDeviceRect.X + "," +
             pointerDevices[i].PhysicalDeviceRect.Y + "," +
             pointerDevices[i].PhysicalDeviceRect.Width + "," +
             pointerDevices[i].PhysicalDeviceRect.Height + "</td></tr>";
         htmlWrite += "<tr><td>(" + i + ") Screen Rect</td><td>" +
             pointerDevices[i].ScreenRect.X + "," +
             pointerDevices[i].ScreenRect.Y + "," +
             pointerDevices[i].ScreenRect.Width + "," +
             pointerDevices[i].ScreenRect.Height + "</td></tr>";
    }
    id("pointerDevices").innerHTML = htmlWrite;
}
```



## -see-also
[Windows.Devices.Input](windows_devices_input.md), [Quickstart: Identifying input devices](http://msdn.microsoft.com/library/7001b56d-081b-4683-84bb-24c361397c08)