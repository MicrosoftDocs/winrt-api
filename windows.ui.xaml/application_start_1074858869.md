---
-api-id: M:Windows.UI.Xaml.Application.Start(Windows.UI.Xaml.ApplicationInitializationCallback)
-api-type: winrt method
---

<!-- Method syntax
public void Start(Windows.UI.Xaml.ApplicationInitializationCallback callback)
-->

# Windows.UI.Xaml.Application.Start

## -description
Provides the entry point and requests initialization of the application. Use the callback to instantiate the [Application](application.md) class.

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.Application.Start](/windows/winui/api/microsoft.ui.xaml.application.start) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -parameters
### -param callback
The callback that should be invoked during the initialization sequence.

## -remarks
Typically, you will not need to call this method directly. If you use Visual Studio to develop your apps, the build system will generate code that includes the necessary call for you.

The callback runs in the same thread as the main view.

## -examples

## -see-also
