---
-api-id: P:Windows.UI.Xaml.Controls.ScrollViewer.CurrentAnchor
-api-type: winrt property
ms.custom: RS5
---

<!-- Property syntax.
public UIElement CurrentAnchor { get; }
-->

# Windows.UI.Xaml.Controls.ScrollViewer.CurrentAnchor

## -description

The currently chosen anchor element to use for scroll anchoring.

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.Controls.ScrollViewer.CurrentAnchor](/windows/winui/api/microsoft.ui.xaml.controls.scrollviewer.currentanchor) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -property-value

The most recently chosen [UIElement](../windows.ui.xaml/uielement.md) for scroll anchoring after a layout pass, or **null**.

## -remarks

If there are no anchor candidates registered with the [ScrollViewer](scrollviewer.md) or none have been chosen, then CurrentAnchor is **null**.

## -see-also

[IScrollAnchorProvider](iscrollanchorprovider.md)

## -examples
