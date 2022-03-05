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

To use an object of this class in a desktop app, cast it to the [IInitializeWithWindow](/windows/win32/api/shobjidl_core/nn-shobjidl_core-iinitializewithwindow) interface, and pass an owner window's handle to the [Initialize](/windows/win32/api/shobjidl_core/nf-shobjidl_core-iinitializewithwindow-initialize) method. For more info, and code examples, see [Display WinRT UI objects that depend on CoreWindow](/windows/apps/develop/ui-input/display-ui-objects).

## -examples

## -see-also

[Advanced casting sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/AdvancedCasting), [Display WinRT UI objects that depend on CoreWindow](/windows/apps/develop/ui-input/display-ui-objects)
