---
-api-id: M:Windows.UI.Xaml.Controls.IScrollAnchorProvider.RegisterAnchorCandidate(Windows.UI.Xaml.UIElement)
-api-type: winrt method
---

<!-- Method syntax.
public void IScrollAnchorProvider.RegisterAnchorCandidate(UIElement element)
-->

# Windows.UI.Xaml.Controls.IScrollAnchorProvider.RegisterAnchorCandidate

## -description
Registers an [UIElement](../windows.ui.xaml/uielement) as a potential scroll anchor candidate.

## -parameters
### -param element
A [UIElement](../windows.ui.xaml/uielement) within the subtree of the [IScrollAnchorProvider](iscrollanchorprovider).

## -remarks
When an element has [CanBeScrollAnchor](../windows.ui.xaml/uielement_canbescrollanchor) set to true the framework locates the first [IScrollAnchorProvider](iscrollanchorprovider) in that element's chain of ancestors and automatically calls its RegisterAnchorCandidate method.  This occurs both when the property is set on an existing element or an element is added to the live tree with the property already set.

Similarly, when the property is set to false (or an element is removed from the visual tree with the property set to true) the framework calls the [UnregisterAnchorCandidate](iscrollanchorprovider_unregisteranchorcandidate_667335027) on the first [IScrollAnchorProvider](iscrollanchorprovider).

## -see-also
* [UnregisterAnchorCandidate](iscrollanchorprovider_unregisteranchorcandidate_667335027)
* [CanBeScrollAnchor](../windows.ui.xaml/uielement_canbescrollanchor) 

## -examples

