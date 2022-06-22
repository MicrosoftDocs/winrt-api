---
-api-id: M:Windows.UI.Xaml.Controls.IScrollAnchorProvider.RegisterAnchorCandidate(Windows.UI.Xaml.UIElement)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public void IScrollAnchorProvider.RegisterAnchorCandidate(UIElement element)
-->

# Windows.UI.Xaml.Controls.IScrollAnchorProvider.RegisterAnchorCandidate

## -description

Registers a [UIElement](../windows.ui.xaml/uielement.md) as a potential scroll anchor candidate.



## -parameters

### -param element

A [UIElement](../windows.ui.xaml/uielement.md) within the subtree of the [IScrollAnchorProvider](iscrollanchorprovider.md).

## -remarks

When an element has [CanBeScrollAnchor](../windows.ui.xaml/uielement_canbescrollanchor.md) set to **true** the framework locates the first [IScrollAnchorProvider](iscrollanchorprovider.md) in that element's chain of ancestors and automatically calls its RegisterAnchorCandidate method. This occurs both when the property is set on an existing element or an element is added to the live tree with the property already set.

Similarly, when the property is set to **false** (or an element is removed from the visual tree with the property set to **true**), the framework calls [UnregisterAnchorCandidate](iscrollanchorprovider_unregisteranchorcandidate_667335027.md) on the first [IScrollAnchorProvider](iscrollanchorprovider.md).

## -see-also

[UnregisterAnchorCandidate](iscrollanchorprovider_unregisteranchorcandidate_667335027.md), [CanBeScrollAnchor](../windows.ui.xaml/uielement_canbescrollanchor.md)

## -examples
