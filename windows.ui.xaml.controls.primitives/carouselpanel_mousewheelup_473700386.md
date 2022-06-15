---
-api-id: M:Windows.UI.Xaml.Controls.Primitives.CarouselPanel.MouseWheelUp
-api-type: winrt method
---

<!-- Method syntax
public void MouseWheelUp()
-->

# Windows.UI.Xaml.Controls.Primitives.CarouselPanel.MouseWheelUp

## -description
Scrolls content by one mousewheel click towards the top.

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.Controls.Primitives.CarouselPanel.MouseWheelUp](/windows/winui/api/microsoft.ui.xaml.controls.primitives.carouselpanel.mousewheelup) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -remarks
This implementation calls [SetVerticalOffset](carouselpanel_setverticaloffset_1333703417.md) using a default value for "mousewheel click" of 48 pixels (3 lines) that comes from a default [ScrollViewer](../windows.ui.xaml.controls/scrollviewer.md).

## -examples

## -see-also
