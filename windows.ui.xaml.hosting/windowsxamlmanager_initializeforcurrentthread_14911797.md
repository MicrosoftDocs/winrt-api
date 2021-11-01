---
-api-id: M:Windows.UI.Xaml.Hosting.WindowsXamlManager.InitializeForCurrentThread
-api-type: winrt method
ms.custom: RS5, 19H1
---

<!-- Method syntax.
public WindowsXamlManager WindowsXamlManager.InitializeForCurrentThread()
-->

# Windows.UI.Xaml.Hosting.WindowsXamlManager.InitializeForCurrentThread

## -description
Initializes the UWP XAML framework in a non-UWP desktop application (for example, a WPF or Windows Forms application) on the current thread.

Equivalent WinUI method: [Microsoft.UI.Xaml.Hosting.WindowsXamlManager.InitializeForCurrentThread](/windows/winui/api/microsoft.ui.xaml.hosting.windowsxamlmanager.initializeforcurrentthread).

## -returns
An object that contains a reference to the UWP XAML framework.

## -remarks
Call this method to initialize the internal UWP XAML framework for the current thread in a desktop application in which you want to host [Windows.UI.Xaml.UIElement](../windows.ui.xaml/uielement.md) objects in a [DesktopWindowXamlSource](desktopwindowxamlsource.md). Call this method if your application creates the **Windows.UI.Xaml.UIElement** objects before it creates the **DesktopWindowXamlSource** object that will host them, or if your program uses XAML from more than one thread. 

This method must be called before creating the **DesktopWindowXamlSource** on the thread.

This method returns a [WindowsXamlManager](windowsxamlmanager.md) object that contains a reference to the UWP XAML framework. Call this method as many times as you want but generally get one instance and run it down after running down the **DesktopWindowXamlSource** instances. Note, after releasing this object a message loop must be run to finish the resource rundown, otherwise the associated resources will be leaked.

```cpp

// Break the cycle between the WindowsXamlManager and the DesktopWindowXamlSource.
m_xamlSource.Close();
m_xamlManager = nullptr;

// Drain the message queue after releasing WindowsXamlManager since rundown is async
while (PeekMessageW(&msg, nullptr, 0, 0, PM_REMOVE))
{
    ::DispatchMessageW(&msg);
}
```

## -see-also

## -examples
