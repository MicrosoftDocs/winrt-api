---
-api-id: M:Windows.UI.Xaml.Controls.ScrollViewer.UnregisterAnchorCandidate(Windows.UI.Xaml.UIElement)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public void ScrollViewer.UnregisterAnchorCandidate(UIElement element)
-->

# Windows.UI.Xaml.Controls.ScrollViewer.UnregisterAnchorCandidate

## -description

Unregisters a [UIElement](../windows.ui.xaml/uielement.md) as a potential scroll anchor.



## -parameters

### -param element

A [UIElement](../windows.ui.xaml/uielement.md) within the subtree of the [ScrollViewer](scrollviewer.md).

## -remarks

When an element's [CanBeScrollAnchor](../windows.ui.xaml/uielement_canbescrollanchor.md) property changes to **false** (or the element is removed from the visual tree), the framework locates the first [IScrollAnchorProvider](iscrollanchorprovider.md) in that element's chain of ancestors and automatically calls its UnregisterAnchorCandidate method.

## -see-also

[IScrollAnchorProvider](iscrollanchorprovider.md), [RegisterAnchorCandidate](iscrollanchorprovider_registeranchorcandidate_178281111.md), [CanBeScrollAnchor](../windows.ui.xaml/uielement_canbescrollanchor.md)

## -examples

