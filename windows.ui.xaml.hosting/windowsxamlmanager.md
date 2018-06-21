---
-api-id: T:Windows.UI.Xaml.Hosting.WindowsXamlManager
-api-type: winrt class
---

<!-- Class syntax.
public class WindowsXamlManager : IClosable
-->

# Windows.UI.Xaml.Hosting.WindowsXamlManager

## -description
Represents the framework for hosting [Windows.UI.Xaml.UIElement](../windows.ui.xaml/uielement.md) content in a non-UWP desktop application (for example, a WPF or Windows Forms application). This class provides a static [InitializeForCurrentThread](windowsxamlmanager_initializeforcurrentthread_14911797.md) method you can use to initialize this framework on the current thread. Call this method early in your desktop application's lifecycle if you want to create [Windows.UI.Xaml.UIElement](../windows.ui.xaml/uielement.md) objects before you instantiate the [DesktopWindowXamlSource](desktopwindowxamlsource.md) object that will host them.

## -remarks

## -see-also

## -examples
