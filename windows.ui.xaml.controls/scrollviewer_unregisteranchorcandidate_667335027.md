---
-api-id: M:Windows.UI.Xaml.Controls.ScrollViewer.UnregisterAnchorCandidate(Windows.UI.Xaml.UIElement)
-api-type: winrt method
---

<!-- Method syntax.
public void ScrollViewer.UnregisterAnchorCandidate(UIElement element)
-->

# Windows.UI.Xaml.Controls.ScrollViewer.UnregisterAnchorCandidate

## -description
Unregisters an [UIElement](../windows.ui.xaml/uielement) as a potential scroll anchor candidate.

## -parameters
### -param element
A [UIElement](../windows.ui.xaml/uielement) within the subtree of the [ScrollViewer](scrollviewer).

## -remarks
When an element's [CanBeScrollAnchor](../windows.ui.xaml/uielement_canbescrollanchor) property changes to false (or the element is removed from the visual tree) the framework locates the first [IScrollAnchorProvider](iscrollanchorprovider) in that element's chain of ancestors and automatically calls its UnregisterAnchorCandidate method.

## -see-also
* [IScrollAnchorProvider](iscrollanchorprovider)
* [RegisterAnchorCandidate](iscrollanchorprovider_registeranchorcandidate_178281111) 
* [CanBeScrollAnchor](../windows.ui.xaml/uielement_canbescrollanchor) 

## -examples

