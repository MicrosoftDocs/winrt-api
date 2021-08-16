---
-api-id: T:Windows.Devices.Enumeration.DevicePicker
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class DevicePicker : Windows.Devices.Enumeration.IDevicePicker
-->

# Windows.Devices.Enumeration.DevicePicker

## -description

Represents a picker flyout that contains a list of devices for the user to choose from.

## -remarks

To use an instance of this class in a desktop app (.NET or native C++), you must cast the instance to the [IInitializeWithWindow](/windows/win32/api/shobjidl_core/nn-shobjidl_core-iinitializewithwindow) interface and pass the owner window for the operation to the [Initialize](/windows/win32/api/shobjidl_core/nf-shobjidl_core-iinitializewithwindow-initialize) method. For more information, see [Classes that use IInitializeWithWindow](/windows/apps/desktop/modernize/desktop-to-uwp-supported-api#classes-that-use-iinitializewithwindow).

## -examples

## -see-also

[Advanced casting sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/AdvancedCasting), [Classes that use IInitializeWithWindow](/windows/apps/desktop/modernize/desktop-to-uwp-supported-api#classes-that-use-iinitializewithwindow)
