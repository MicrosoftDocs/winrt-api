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

The [Device Capabilities Sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/411c271e537727d737a53fa2cbe99eaecac00cc0/Official%20Windows%20Platform%20Sample/Input%20Device%20capabilities%20sample) demonstrates how to detect the presence of input devices and retrieve the capabilities and attributes of each device.

<!-- confirmed -->
> [!NOTE]
> This class is not agile, which means that you need to consider its threading model and marshaling behavior. For more info, see [Threading and Marshaling (C++/CX)](/cpp/cppcx/threading-and-marshaling-c-cx) and [Using Windows Runtime objects in a multithreaded environment (.NET)](/windows/uwp/threading-async/using-windows-runtime-objects-in-a-multithreaded-environment).

## -examples
The following code shows how to use PointerDevice.

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

```cppwinrt
#include <sstream>
#include <winrt/Windows.Devices.Input.h>
#include <winrt/Windows.Foundation.Collections.h>
#include <winrt/Windows.UI.Xaml.Controls.h>
using namespace winrt;
using namespace Windows::Devices::Input;
using namespace Windows::UI::Xaml::Controls;

...

void PointerGetSettings_Click(Windows::Foundation::IInspectable const& sender, Windows::UI::Xaml::RoutedEventArgs const& args)
{
    auto b{ sender.try_as<Button>() };
    if (b)
    {
        Windows::Foundation::Collections::IVectorView<PointerDevice> pointerDeviceList{ PointerDevice::GetPointerDevices() };
        std::wostringstream buffer;

        for (uint32_t i = 0; i < pointerDeviceList.Size(); i++)
        {
            winrt::hstring displayIndex{ winrt::to_hstring(i + 1) };
            buffer << L"Pointer device " << displayIndex.c_str() << std::endl;
            buffer << L"This pointer device type is ";

            switch (pointerDeviceList.GetAt(i).PointerDeviceType())
            {
            case PointerDeviceType::Mouse:
                buffer << L"Mouse" << std::endl;
                break;
            case PointerDeviceType::Pen:
                buffer << L"Pen" << std::endl;
                break;
            case PointerDeviceType::Touch:
                buffer << L"Touch" << std::endl;
                break;
            default:
                buffer << L"unknown" << std::endl;
            }

            buffer << L"This pointer device is " << (pointerDeviceList.GetAt(i).IsIntegrated() ? L"not " : L"") << L"external" << std::endl;
            buffer << L"This pointer device has a maximum of " << pointerDeviceList.GetAt(i).MaxContacts() << L" contacts" << std::endl;
            buffer << L"The physical device rect is " <<
                pointerDeviceList.GetAt(i).PhysicalDeviceRect().X << L", " <<
                pointerDeviceList.GetAt(i).PhysicalDeviceRect().Y << L", " <<
                pointerDeviceList.GetAt(i).PhysicalDeviceRect().Width << L", " <<
                pointerDeviceList.GetAt(i).PhysicalDeviceRect().Height << std::endl;
            buffer << L"The screen rect is " <<
                pointerDeviceList.GetAt(i).ScreenRect().X << L", " <<
                pointerDeviceList.GetAt(i).ScreenRect().Y << L", " <<
                pointerDeviceList.GetAt(i).ScreenRect().Width << L", " <<
                pointerDeviceList.GetAt(i).ScreenRect().Height << std::endl << std::endl;
        }

        PointerOutputTextBlock().Text(buffer.str());
    }
}
```

```cppcx
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

[Windows.Devices.Input](windows_devices_input.md), [Quickstart: Identifying input devices](/windows/uwp/design/input/identify-input-devices)