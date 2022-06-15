---
-api-id: P:Windows.UI.Xaml.UIElement.CanBeScrollAnchor
-api-type: winrt property
ms.custom: RS5
---

<!-- Property syntax.
public bool CanBeScrollAnchor { get;  set; }
-->

# Windows.UI.Xaml.UIElement.CanBeScrollAnchor

## -description

Gets or sets a value that indicates whether the [UIElement](uielement.md) can be a candidate for scroll anchoring.

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.UIElement.CanBeScrollAnchor](/windows/winui/api/microsoft.ui.xaml.uielement.canbescrollanchor) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -property-value

**true** if an element should be considered as a candidate for scroll anchoring; otherwise, **false**. The default is **false**.

## -remarks

For more info, see the remarks for the [IScrollAnchorProvider](../windows.ui.xaml.controls/iscrollanchorprovider.md) interface.

## -see-also

[IScrollAnchorProvider](../windows.ui.xaml.controls/iscrollanchorprovider.md), [IScrollAnchorProvider.RegisterAnchorCandidate](../windows.ui.xaml.controls/iscrollanchorprovider_registeranchorcandidate_178281111.md), [IScrollAnchorProvider.UnregisterAnchorCandidate](../windows.ui.xaml.controls/iscrollanchorprovider_unregisteranchorcandidate_667335027.md)

## -examples
