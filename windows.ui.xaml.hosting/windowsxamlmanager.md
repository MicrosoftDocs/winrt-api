---
-api-id: T:Windows.UI.Xaml.Hosting.WindowsXamlManager
-api-type: winrt class
ms.custom: RS5
---

<!-- Class syntax.
public class WindowsXamlManager : IClosable
-->

# Windows.UI.Xaml.Hosting.WindowsXamlManager

## -description
Represents the UWP XAML framework in a non-UWP desktop application (for example, a WPF or Windows Forms application) that hosts UWP controls.

> [!NOTE]
> This API is currently available as a developer preview. Although we encourage you to try out this API in your own prototype code now, we do not recommend that you use it in production code at this time. This API will continue to mature and stabilize in future Windows releases. Microsoft makes no warranties, express or implied, with respect to the information provided here.

## -remarks
**WindowsXamlManager** is part of the *UWP XAML hosting API*. This API enables non-UWP desktop applications to host any control that derives from [Windows.UI.Xaml.UIElement](../windows.ui.xaml/uielement.md)) in a UI element that is associated with a window handle (HWND). This API can be used by desktop applications built using WPF, Windows Forms, and the Windows API (Win32). For more information, see [Using the UWP XAML hosting API in a desktop application](https://docs.microsoft.com/windows/uwp/xaml-platform/using-the-xaml-hosting-api).

**WindowsXamlManager** provides a static [InitializeForCurrentThread](windowsxamlmanager_initializeforcurrentthread_14911797.md) method you can use to initialize the UWP XAML framework on the current thread 

## -see-also
[Using the UWP XAML hosting API in a desktop application](https://docs.microsoft.com/windows/uwp/xaml-platform/using-the-xaml-hosting-api)

## -examples
