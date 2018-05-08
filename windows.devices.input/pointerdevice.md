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
function getPointerCapabilities() { 
        var pointerDevices = 
            Windows.Devices.Input.PointerDevice.getPointerDevices(); 
        var htmlWrite = ""; 
        var i; 
        for (i = 0; i < pointerDevices.size; i++) { 
            var displayIndex = /*@static_cast(String)*/(i + 1); 
            htmlWrite += 
                "<tr><td>(" + displayIndex + ") Pointer Device Type</td>  <td>" + 
                getPointerDeviceType(pointerDevices[i].pointerDeviceType) + "</td></tr>"; 
            htmlWrite += "<tr><td>(" + displayIndex + ") Is Integrated</td><td>" + 
                /*@static_cast(String)*/pointerDevices[i].isIntegrated + "</td></tr>"; 
            htmlWrite += "<tr><td>(" + displayIndex + ") Max Contacts</td><td>" + 
                pointerDevices[i].maxContacts + "</td></tr>"; 
            htmlWrite += "<tr><td>(" + displayIndex + ") Physical Device Rect</td><td>" + 
                 pointerDevices[i].physicalDeviceRect.x + "," + 
                 pointerDevices[i].physicalDeviceRect.y + "," + 
                 pointerDevices[i].physicalDeviceRect.width + "," + 
                 pointerDevices[i].physicalDeviceRect.height + "</td></tr>"; 
            htmlWrite += "<tr><td>(" + displayIndex + ") Screen Rect</td><td>" + 
                 pointerDevices[i].screenRect.x + "," + 
                 pointerDevices[i].screenRect.y + "," + 
                 pointerDevices[i].screenRect.width + "," + 
                 pointerDevices[i].screenRect.height + "</td></tr>"; 
        } 
        id("pointerDevices").innerHTML = htmlWrite; 
    }
```

```csharp
/// <summary> 
/// Invoked when this page is about to be displayed in a Frame. 
/// </summary> 
/// <param name="e">Event data that describes how this page was reached.  The Parameter 
/// property is typically used to configure the page.</param> 
protected override void OnNavigatedTo(NavigationEventArgs e) 
{ 
    string Buffer; 

    Buffer = "List of all pointer devices: \n\n"; 

    var PointerDeviceList = Windows.Devices.Input.PointerDevice.GetPointerDevices(); 
    int displayIndex = 1; 

    foreach (Windows.Devices.Input.PointerDevice PointerDevice in PointerDeviceList) 
    { 
        Buffer += string.Format("Pointer device " + displayIndex + ":\n"); 
        Buffer += string.Format("This pointer device type is " + 
            PointerType(PointerDevice) + "\n"); 
        Buffer += string.Format("This pointer device is " + 
            (PointerDevice.IsIntegrated ? "not " : "") + "external\n"); 
        Buffer += string.Format("This pointer device has a maximum of " + 
            PointerDevice.MaxContacts + " contacts\n"); 
        Buffer += string.Format("The physical device rect is " + 
            PointerDevice.PhysicalDeviceRect.X.ToString() + ", " + 
            PointerDevice.PhysicalDeviceRect.Y.ToString() + ", " + 
            PointerDevice.PhysicalDeviceRect.Width.ToString() + ", " + 
            PointerDevice.PhysicalDeviceRect.Height.ToString() + "\n"); 
        Buffer += string.Format("The screen rect is " + 
            PointerDevice.ScreenRect.X.ToString() + ", " + 
            PointerDevice.ScreenRect.Y.ToString() + ", " + 
            PointerDevice.ScreenRect.Width.ToString() + ", " + 
            PointerDevice.ScreenRect.Height.ToString() + "\n\n"); 
    }  
    PointerOutputTextBlock.Text = Buffer; 
}
```

```cpp
void SDKSample::DeviceCaps::Pointer::PointerGetSettings_Click(Platform::Object^ sender, Windows::UI::Xaml::RoutedEventArgs^ e) 
{ 
    Button^ b = safe_cast<Button^>(sender); 
    if (b != nullptr) 
    { 
        Windows::Foundation::Collections::IVectorView<PointerDevice^>^ PointerDeviceList = PointerDevice::GetPointerDevices(); 
        Platform::String^ Buffer; 
 
        for (unsigned i = 0; i < PointerDeviceList->Size; i++) { 
            Platform::String^ displayIndex = (i + 1).ToString(); 
            Buffer += "Pointer device " + displayIndex + ":\n"; 
            Buffer += "This pointer device type is " + PointerType(PointerDeviceList->GetAt(i)) + "\n"; 
            Buffer += "This pointer device is " + (PointerDeviceList->GetAt(i)->IsIntegrated ? "not " : "") + "external\n"; 
            Buffer += "This pointer device has a maximum of " + PointerDeviceList->GetAt(i)->MaxContacts.ToString() + " contacts\n"; 
            Buffer += "The physical device rect is " + 
                PointerDeviceList->GetAt(i)->PhysicalDeviceRect.X.ToString() + ", " + 
                PointerDeviceList->GetAt(i)->PhysicalDeviceRect.Y.ToString() + ", " + 
                PointerDeviceList->GetAt(i)->PhysicalDeviceRect.Width.ToString() + ", " + 
                PointerDeviceList->GetAt(i)->PhysicalDeviceRect.Height.ToString() + "\n"; 
            Buffer += "The screen rect is " + 
                PointerDeviceList->GetAt(i)->ScreenRect.X.ToString() + ", " + 
                PointerDeviceList->GetAt(i)->ScreenRect.Y.ToString() + ", " + 
                PointerDeviceList->GetAt(i)->ScreenRect.Width.ToString() + ", " + 
                PointerDeviceList->GetAt(i)->ScreenRect.Height.ToString() + "\n\n"; 
        } 
         
        PointerOutputTextBlock->Text = Buffer; 
    } 
}
```

## -see-also

- [Windows.Devices.Input](windows_devices_input.md)
- [Quickstart: Identifying input devices](https://docs.microsoft.com/en-us/windows/uwp/design/input/identify-input-devices)