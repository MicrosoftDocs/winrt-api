---
-api-id: T:Windows.UI.Xaml.FrameworkView
-api-type: winrt class
---

<!-- Class syntax.
public class FrameworkView : Windows.ApplicationModel.Core.IFrameworkView, Windows.UI.Xaml.IFrameworkView
-->

# Windows.UI.Xaml.FrameworkView

## -description
Represents the UI window of an application.

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.FrameworkView](/windows/winui/api/microsoft.ui.xaml.frameworkview) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -remarks
This class provides the infrastructure support so that the [Application](application.md) class has correct threading and object lifetime considerations for the [IFrameworkView](../windows.applicationmodel.core/iframeworkview.md) pattern used by the core app model. Most UWP app using C++, C#, or Visual Basic development scenarios don't do anything with this class directly.

## -examples

## -see-also
[IFrameworkView](../windows.applicationmodel.core/iframeworkview.md)
