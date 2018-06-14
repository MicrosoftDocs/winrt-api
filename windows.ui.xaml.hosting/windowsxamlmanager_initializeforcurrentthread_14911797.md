---
-api-id: M:Windows.UI.Xaml.Hosting.WindowsXamlManager.InitializeForCurrentThread
-api-type: winrt method
---

<!-- Method syntax.
public WindowsXamlManager WindowsXamlManager.InitializeForCurrentThread()
-->

# Windows.UI.Xaml.Hosting.WindowsXamlManager.InitializeForCurrentThread

## -description
Initializes the UWP XAML framework early in your desktop application's lifecycle so you can then create [Windows.UI.Xaml.UIElement](../windows.ui.xaml/uielement.md) objects before you instantiate a [DesktopWindowXamlSource](desktopwindowxamlsource.md) object. These [Windows.UI.Xaml.UIElement](../windows.ui.xaml/uielement.md) objects can then be set as the [Content](desktopwindowxamlsource_content.md) of a [DesktopWindowXamlSource](desktopwindowxamlsource.md) to host UWP XAML elements.

## -returns
An object that initializes the [Windows.UI.Xaml.UIElement](../windows.ui.xaml/uielement.md) objects that you instantiate after calling this method.

## -remarks
You only need to call this method if you create [Windows.UI.Xaml.UIElement](../windows.ui.xaml/uielement.md) objects before you create the **DesktopWindowXamlSource** object in which they will be hosted. In this case, you must call **InitializeForCurrentThread** before you instantiate the [Windows.UI.Xaml.UIElement](../windows.ui.xaml/uielement.md) objects.

If you create a **DesktopWindowXamlSource** object before you create the [Windows.UI.Xaml.UIElement](../windows.ui.xaml/uielement.md) objects that will be hosted in it, you don’t need to call this method. In this scenario, the UWP XAML framework makes sure all the objects are initialized to the same thread.

You can create as many [WindowsXamlManager](windowsxamlmanager.md) objects as you want on a given thread. However, each object holds a reference to the UWP XAML framework, and therefore it is critical to **Close** (**Dispose** in .NET) the objects to ensure that XAML resources are eventually released. 

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

