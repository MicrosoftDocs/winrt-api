---
-api-id: P:Windows.UI.Xaml.Controls.AnchorRequestedEventArgs.Anchor
-api-type: winrt property
ms.custom: RS5
---

<!-- Property syntax.
public UIElement Anchor { get;  set; }
-->

# Windows.UI.Xaml.Controls.AnchorRequestedEventArgs.Anchor

## -description

Gets or sets the *anchor element* to use when performing scroll anchoring.

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.Controls.AnchorRequestedEventArgs.Anchor](/windows/winui/api/microsoft.ui.xaml.controls.anchorrequestedeventargs.anchor) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -property-value

The [UIElement](../windows.ui.xaml/uielement.md) to use as the [CurrentAnchor](iscrollanchorprovider_currentanchor.md). The default is **null**.

## -remarks

The element must be a descendent of the scrolling control.

## -see-also

[IScrollAnchorProvider](iscrollanchorprovider.md), [ScrollViewer.AnchorRequested](scrollviewer_anchorrequested.md)

## -examples

