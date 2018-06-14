---
-api-id: T:Windows.UI.Xaml.Hosting.DesktopWindowXamlSource
-api-type: winrt class
---

<!-- Class syntax.
public class DesktopWindowXamlSource : IClosable
-->

# Windows.UI.Xaml.Hosting.DesktopWindowXamlSource

## -description
Enables a non-UWP desktop application (for example, a WPF or Windows Forms application) to host a [Windows.UI.Xaml.UIElement](../windows.ui.xaml/uielement.md) in an HWND.  

## -remarks
**DesktopWindowXamlSource** can only be used in one top-level window per thread. If you want to host XAML content in multiple top-level windows, each window must be on its own thread.

If you create a **DesktopWindowXamlSource** object before you create the [Windows.UI.Xaml.UIElement](../windows.ui.xaml/uielement.md) objects that will be hosted in it, the framework will ensure initialization occurs in the correct order. If you create the [Windows.UI.Xaml.UIElement](../windows.ui.xaml/uielement.md) objects before you create the **DesktopWindowXamlSource** object in which they will be hosted, you must call [WindowsXamlManager.InitializeForCurrentThread](windowsxamlmanager_initializeforcurrentthread.md) before you instantiate the [Windows.UI.Xaml.UIElement](../windows.ui.xaml/uielement.md) objects.

Because **DesktopWindowXamlSource** derives from [IClosable](../windows.foundation/iclosable.md), so it is recommended that you **Close** it (**Dispose** it in .NET) when you’re finished with it.

## -see-also

## -examples
