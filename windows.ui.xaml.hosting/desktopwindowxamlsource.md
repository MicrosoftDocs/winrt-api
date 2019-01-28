---
-api-id: T:Windows.UI.Xaml.Hosting.DesktopWindowXamlSource
-api-type: winrt class
ms.custom: RS5
---

<!-- Class syntax.
public class DesktopWindowXamlSource : IClosable
-->

# Windows.UI.Xaml.Hosting.DesktopWindowXamlSource

## -description
Enables a non-UWP desktop application (for example, a WPF or Windows Forms application) to host UWP controls in any UI element that is associated with a window handle (HWND).

> [!NOTE]
> This API is currently available as a developer preview. Although we encourage you to try out this API in your own prototype code now, we do not recommend that you use it in production code at this time. This API will continue to mature and stabilize in future Windows releases. Microsoft makes no warranties, express or implied, with respect to the information provided here.

## -remarks

**DesktopWindowXamlSource** is the main class in the *UWP XAML hosting API*. This API enables non-UWP desktop applications to host any control that derives from [Windows.UI.Xaml.UIElement](../windows.ui.xaml/uielement.md)) in a UI element that is associated with a window handle (HWND). This API can be used by desktop applications built using WPF, Windows Forms, and the Windows API (Win32). For more information, see [Using the UWP XAML hosting API in a desktop application](https://docs.microsoft.com/windows/uwp/xaml-platform/using-the-xaml-hosting-api).

**DesktopWindowXamlSource** can only be used in one top-level window per thread. If you want to host XAML content in multiple top-level windows, each window must be on its own thread.

If you create a **DesktopWindowXamlSource** object before you create the [Windows.UI.Xaml.UIElement](../windows.ui.xaml/uielement.md) objects that will be hosted in it, the framework for hosting [Windows.UI.Xaml.UIElement](../windows.ui.xaml/uielement.md) content makes sure all the objects are initialized to the same thread. If you create the [Windows.UI.Xaml.UIElement](../windows.ui.xaml/uielement.md) objects before you create the **DesktopWindowXamlSource** object in which they will be hosted, you must call [WindowsXamlManager.InitializeForCurrentThread](windowsxamlmanager_initializeforcurrentthread_14911797.md) before you instantiate the [Windows.UI.Xaml.UIElement](../windows.ui.xaml/uielement.md) objects.

Because **DesktopWindowXamlSource** derives from [IClosable](../windows.foundation/iclosable.md), so it is recommended that you **Close** it (**Dispose** it in .NET) when you’re finished with it.

## -see-also
[Using the UWP XAML hosting API in a desktop application](https://docs.microsoft.com/windows/uwp/xaml-platform/using-the-xaml-hosting-api)

## -examples
