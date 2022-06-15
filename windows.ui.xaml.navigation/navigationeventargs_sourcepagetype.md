---
-api-id: P:Windows.UI.Xaml.Navigation.NavigationEventArgs.SourcePageType
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Interop.TypeName SourcePageType { get; }
-->

# Windows.UI.Xaml.Navigation.NavigationEventArgs.SourcePageType

## -description
Gets the data type of the source page.

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.Navigation.NavigationEventArgs.SourcePageType](/windows/winui/api/microsoft.ui.xaml.navigation.navigationeventargs.sourcepagetype) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -property-value
The data type of the source page, represented as *namespace*.*type* or simply *type*.

## -remarks
When the navigation occurs as a result of the app being launched, the [SourcePageType](navigatingcanceleventargs_sourcepagetype.md) is equal to the **typeof** the page being navigated to.

## -examples

## -see-also
