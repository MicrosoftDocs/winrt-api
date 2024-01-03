---
-api-id: P:Windows.UI.Xaml.Application.RequiresPointerMode
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.ApplicationRequiresPointerMode RequiresPointerMode { get;  set; }
-->

# Windows.UI.Xaml.Application.RequiresPointerMode

## -description
Gets or sets whether a UWP app supports mouse mode, which emulates pointer interaction experiences with non-pointer input devices such as an game pad or remote control. (All nested elements inherit this behavior.)

## -property-value
The pointer emulation mode. The default is [Auto](applicationrequirespointermode.md) (the default system experience for the input device).

## -remarks
For non-pointer input devices, focus is moved between controls through a variety of methods, such as the Tab and arrow keys on a keyboard, the directional pad (D-pad) on a remote, or thumb sticks on a controller. For some user experiences, such as maps and drawing surfaces, it is not possible or practical to use XY focus navigation. RequiresPointerMode enables an app to provide a more pointer-like interaction experience through a cursor that can be moved freely using the game input devices.

RequiresPointerMode is supported only on the Xbox device family, and only when using a game pad or remote control. The property is ignored otherwise.

[RequiresPointer](../windows.ui.xaml.controls/control_requirespointer.md) sets mouse mode at the UI element level.

For more info, see the [Mouse mode](/windows/uwp/input-and-devices/designing-for-tv) section of [Designing for Xbox and TV](/windows/uwp/input-and-devices/designing-for-tv).

## -version-compatibility
RequiresPointerMode is not available prior to Windows 10, version 1607. If your app’s 'minimum platform version' setting in Visual Studio is less than the 'introduced version' shown in the Requirements block later in this page, you must design and test your app to account for this. For more info, see [Version adaptive code](/windows/uwp/debug-test-perf/version-adaptive-code). 

To avoid exceptions when your app runs on previous versions of Windows 10, do not set this property in XAML or use it without performing a runtime check. This example shows how to use the [ApiInformation class](apiinformation.md) to check for the presence of this property before you set it.

```csharp
if (ApiInformation.IsPropertyPresent("Windows.UI.Xaml.Application", "RequiresPointerMode"))
{
    application.RequiresPointerMode = RequiresPointerMode.WhenRequested;
}
```

## -examples

## -see-also
[RequiresPointer](../windows.ui.xaml.controls/control_requirespointer.md)
