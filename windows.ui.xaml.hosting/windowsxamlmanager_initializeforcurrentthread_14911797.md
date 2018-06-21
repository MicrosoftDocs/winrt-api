---
-api-id: M:Windows.UI.Xaml.Hosting.WindowsXamlManager.InitializeForCurrentThread
-api-type: winrt method
---

<!-- Method syntax.
public WindowsXamlManager WindowsXamlManager.InitializeForCurrentThread()
-->

# Windows.UI.Xaml.Hosting.WindowsXamlManager.InitializeForCurrentThread

## -description
Initializes the framework for hosting [Windows.UI.Xaml.UIElement](../windows.ui.xaml/uielement.md) content in a non-UWP desktop application (for example, a WPF or Windows Forms application) on the current thread.

## -returns
The object that represents the initialized framework for hosting [Windows.UI.Xaml.UIElement](../windows.ui.xaml/uielement.md) content on the current thread.

## -remarks
Call this method early in your desktop application's lifecycle if you want to create [Windows.UI.Xaml.UIElement](../windows.ui.xaml/uielement.md) objects before you instantiate the [DesktopWindowXamlSource](desktopwindowxamlsource.md) object that will host them. In this case, you must call **InitializeForCurrentThread** before you instantiate the [Windows.UI.Xaml.UIElement](../windows.ui.xaml/uielement.md) objects.

If you create a **DesktopWindowXamlSource** object before you create the [Windows.UI.Xaml.UIElement](../windows.ui.xaml/uielement.md) objects that will be hosted in it, you don’t need to call this method. In this scenario, the framework for hosting [Windows.UI.Xaml.UIElement](../windows.ui.xaml/uielement.md) content makes sure all the objects are initialized to the same thread.

You can create as many [WindowsXamlManager](windowsxamlmanager.md) objects as you want on a given thread. However, each object holds a reference to the UWP XAML framework, and therefore you must **Close** (**Dispose** in .NET) the objects to ensure that XAML resources are eventually released.

## -see-also

## -examples

The following example demonstrates the common usage pattern for calling **InitializeForCurrentThread** in a C# WPF application.

```csharp
Thread uiThread = new Thread(UIThreadProc);

void UIThreadProc()
{
    using (WindowsXamlManager manager = WindowsXamlManager.InitializeForCurrentThread())
    {
        // Instantiate and run the main application object to start up the message pump.
        this.application = new System.Windows.Application();
        var window = new System.Windows.Window();

        this.application.Run(window);
    }
    // The WindowsXamlManager will be disposed here.
}
```
