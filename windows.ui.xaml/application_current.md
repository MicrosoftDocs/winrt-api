---
-api-id: P:Windows.UI.Xaml.Application.Current
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Application Current { get; }
-->

# Windows.UI.Xaml.Application.Current

## -description
Gets the [Application](application.md) object for the current application.

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.Application.Current](/windows/winui/api/microsoft.ui.xaml.application.current) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -property-value
The [Application](application.md) object for the current application.

## -remarks
[Application](application.md) is a singleton that implements the static Current property to provide shared access to the [Application](application.md) instance for the current application. The singleton pattern ensures that state managed by [Application](application.md), including shared resources and properties, is available from a single, shared location.

## -examples

## -see-also
