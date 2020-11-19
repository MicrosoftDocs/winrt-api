---
-api-id: T:Windows.Devices.Input.MouseEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class MouseEventArgs : Windows.Devices.Input.IMouseEventArgs
-->

# Windows.Devices.Input.MouseEventArgs

## -description
Contains event data for the [MouseMoved](mousedevice_mousemoved.md) event.

## -remarks
**JavaScript:** This object is accessed when you implement a handler to respond to [MouseMoved](mousedevice_mousemoved.md) events.

The [Device Capabilities Sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/411c271e537727d737a53fa2cbe99eaecac00cc0/Official%20Windows%20Platform%20Sample/Input%20Device%20capabilities%20sample) demonstrates how to detect the presence of input devices and retrieve the capabilities and attributes of each device.

<!-- confirmed -->
> [!NOTE]
> This class is not agile, which means that you need to consider its threading model and marshaling behavior. For more info, see [Threading and Marshaling (C++/CX)](/cpp/cppcx/threading-and-marshaling-c-cx) and [Using Windows Runtime objects in a multithreaded environment (.NET)](/windows/uwp/threading-async/using-windows-runtime-objects-in-a-multithreaded-environment).

## -examples

## -see-also
[Windows.Devices.Input](windows_devices_input.md)