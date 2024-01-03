---
-api-id: P:Windows.UI.Xaml.Controls.Control.RequiresPointer
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Controls.RequiresPointer RequiresPointer { get;  set; }
-->

# Windows.UI.Xaml.Controls.Control.RequiresPointer

## -description
Gets or sets whether a UI element supports mouse mode, which emulates pointer interaction experiences with non-pointer input devices such as an game pad or remote control.



## -xaml-syntax
```xaml
<control RequiresPointer="requiresPointerMemberName"/>
```


## -xaml-values
<dl><dt>requiresPointerMemberName</dt><dd>requiresPointerMemberNameA named constant of the RequiresPointer enumeration, such as WhenEngaged.</dd>
</dl>
## -property-value
The pointer emulation mode. The default is **Never**.

## -remarks
For non-pointer input devices, focus is moved between controls through a variety of methods, such as the Tab and arrow keys on a keyboard, the directional pad (D-pad) on a remote, or thumb sticks on a game controller. For some user experiences, such as maps and drawing surfaces, it is not possible or practical to use XY focus navigation. RequiresPointer enables an app to provide a more pointer-like interaction experience through a cursor that can be moved freely using game input devices.

RequiresPointer is supported only on the Xbox device family, and only when using a game pad or remote control. The property is ignored otherwise.

[RequiresPointerMode](../windows.ui.xaml/application_requirespointermode.md) sets mouse mode at the application level.

For more info, see the [Mouse mode](/windows/uwp/input-and-devices/designing-for-tv) section of [Designing for Xbox and TV](/windows/uwp/input-and-devices/designing-for-tv).

### Version compatibility

The RequiresPointer property is not available prior to Windows 10, version 1607. If your app’s 'minimum platform version' setting in Microsoft Visual Studio is less than the 'introduced version' shown in the Requirements block later in this page, you must design and test your app to account for this. For more info, see [Version adaptive code](/windows/uwp/debug-test-perf/version-adaptive-code).

To avoid exceptions when your app runs on previous versions of Windows 10, do not set this property in XAML or use it without performing a runtime check. This example shows how to use the [ApiInformation](../windows.foundation.metadata/apiinformation.md) class to check for the presence of this property before you set it.

```csharp

if (ApiInformation.IsPropertyPresent("Windows.UI.Xaml.Controls.Control", "RequiresPointer"))
{
    mapControl1.RequiresPointer = RequiresPointer.WhenEngaged;
}
```

## -examples

## -see-also
[RequiresPointerMode](../windows.ui.xaml/application_requirespointermode.md)
