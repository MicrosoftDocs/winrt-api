---
-api-id: P:Windows.UI.Xaml.Controls.ContentPresenter.BackgroundSizing
-api-type: winrt property
ms.custom: RS5
---

<!-- Property syntax.
public BackgroundSizing BackgroundSizing { get;  set; }
-->

# Windows.UI.Xaml.Controls.ContentPresenter.BackgroundSizing

## -description

Gets or sets a value that indicates how far the background extends in relation to this element's border.

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.Controls.ContentPresenter.BackgroundSizing](/windows/winui/api/microsoft.ui.xaml.controls.contentpresenter.backgroundsizing) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -property-value

A value of the enumeration that indicates how far the background extends. The default is **InnerBorderEdge**.

## -remarks

You can set this property to **OuterBorderEdge** to make the element's background extend under the border. If the border is transparent, the background will show through it.

## -see-also

[BackgroundSizing](backgroundsizing.md), [Border.BackgroundSizing](border_backgroundsizing.md), [Control.BackgroundSizing](control_backgroundsizing.md), [Grid.BackgroundSizing](grid_backgroundsizing.md), [RelativePanel.BackgroundSizing](relativepanel_backgroundsizing.md), [StackPanel.BackgroundSizing](stackpanel_backgroundsizing.md)

## -examples

