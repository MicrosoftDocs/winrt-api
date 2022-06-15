---
-api-id: P:Windows.UI.Xaml.Navigation.FrameNavigationOptions.IsNavigationStackEnabled
-api-type: winrt property
ms.custom: RS5
---

<!-- Property syntax.
public bool IsNavigationStackEnabled { get;  set; }
-->

# Windows.UI.Xaml.Navigation.FrameNavigationOptions.IsNavigationStackEnabled

## -description

Gets or sets a value that indicates whether navigation is recorded in the Frame's ForwardStack or BackStack.

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.Navigation.FrameNavigationOptions.IsNavigationStackEnabled](/windows/winui/api/microsoft.ui.xaml.navigation.framenavigationoptions.isnavigationstackenabled) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -property-value

**true** if navigation is recorded in the Frame's ForwardStack or BackStack; otherwise, **false**. The default is **true**.

## -remarks

FrameNavigationOptions is used as a parameter of the [Frame.NavigateToType](../windows.ui.xaml.controls/frame_navigatetotype_853885036.md) method.

## -see-also

[Frame.NavigateToType](../windows.ui.xaml.controls/frame_navigatetotype_853885036.md)

## -examples

