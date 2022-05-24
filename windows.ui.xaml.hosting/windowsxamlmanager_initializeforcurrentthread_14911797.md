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


## -returns
An object that contains a reference to the UWP XAML framework.

## -remarks
Call this method to initialize the internal UWP XAML framework for the current thread in a desktop application in which you want to host [Windows.UI.Xaml.UIElement](../windows.ui.xaml/uielement.md) objects in a [DesktopWindowXamlSource](desktopwindowxamlsource.md). You only need to explicitly call this method if your application creates the **Windows.UI.Xaml.UIElement** objects before it creates the **DesktopWindowXamlSource** object that will host them. Your application should typically should call this method when the parent UI object that hosts the **DesktopWindowXamlSource** is instantiated.

If you create a **DesktopWindowXamlSource** object before you create the **Windows.UI.Xaml.UIElement** objects that will be hosted in it, you don’t need to call this method. In this scenario, the UWP XAML framework will be initialized for you when you instantiate the **DesktopWindowXamlSource** object.

This method returns a [WindowsXamlManager](windowsxamlmanager.md) object that contains a reference to the UWP XAML framework. You can create as many **WindowsXamlManager** objects as you want on a given thread. However, because each object holds a reference to the UWP XAML framework, you should **Close** (**Dispose** in .NET) the objects to ensure that XAML resources are eventually released.

## -see-also

## -examples
