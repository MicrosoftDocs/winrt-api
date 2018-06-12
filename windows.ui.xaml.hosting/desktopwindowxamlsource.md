---
-api-id: T:Windows.UI.Xaml.Hosting.DesktopWindowXamlSource
-api-type: winrt class
---

<!-- Class syntax.
public class DesktopWindowXamlSource : IClosable
-->

# Windows.UI.Xaml.Hosting.DesktopWindowXamlSource

## -description
Enables a non-UWP desktop application (for example, a WPF or Windows Forms application) to host a [Windows.UI.Xaml.UIElement](../windows.ui.xaml/uielement.md) in a window.  

## -remarks
The thread of the window’s handle must belong to the same thread in which the **DesktopWindowXamlSource** is created.

If you create a **DesktopWindowXamlSource** object before you create the [Windows.UI.Xaml.UIElement](../windows.ui.xaml/uielement.md) objects that will be hosted in it, the framework makes sure all the objects are initialized to the same thread. If you create the [Windows.UI.Xaml.UIElement](../windows.ui.xaml/uielement.md) objects before you create the **DesktopWindowXamlSource** object in which they will be hosted, you must call [WindowsXamlManager.InitializeForCurrentThread](windowsxamlmanager_initializeforcurrentthread.md) before you instantiate the [Windows.UI.Xaml.UIElement](../windows.ui.xaml/uielement.md) objects. 

## -see-also

## -examples
