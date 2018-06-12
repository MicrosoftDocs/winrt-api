---
-api-id: M:Windows.UI.Xaml.Hosting.WindowsXamlManager.InitializeForCurrentThread
-api-type: winrt method
---

<!-- Method syntax.
public WindowsXamlManager WindowsXamlManager.InitializeForCurrentThread()
-->

# Windows.UI.Xaml.Hosting.WindowsXamlManager.InitializeForCurrentThread

## -description
Initializes the [Windows.UI.Xaml.UIElement](../windows.ui.xaml/uielement.md) objects that you instantiate after calling this method so they can be hosted in a [DesktopWindowXamlSource](desktopwindowxamlsource.md) object.

## -returns
A [WindowsXamlManager](windowsxamlmanager.md) object that initializes the [Windows.UI.Xaml.UIElement](../windows.ui.xaml/uielement.md) objects that you instantiate after calling this method.

## -remarks
You only need to call this method if you create [Windows.UI.Xaml.UIElement](../windows.ui.xaml/uielement.md) objects before you create the **DesktopWindowXamlSource** object in which they will be hosted. In this case, you must call **InitializeForCurrentThread** before you instantiate the [Windows.UI.Xaml.UIElement](../windows.ui.xaml/uielement.md) objects.

If you create a **DesktopWindowXamlSource** object before you create the [Windows.UI.Xaml.UIElement](../windows.ui.xaml/uielement.md) objects that will be hosted in it, you don’t need to call this method. In this scenario, the framework makes sure all the objects are initialized to the same thread.

## -see-also

## -examples
