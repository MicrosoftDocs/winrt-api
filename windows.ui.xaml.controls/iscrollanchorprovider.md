---
-api-id: T:Windows.UI.Xaml.Controls.IScrollAnchorProvider
-api-type: winrt interface
ms.custom: RS5
---

<!-- Interface syntax.
public interface IScrollAnchorProvider 
-->

# Windows.UI.Xaml.Controls.IScrollAnchorProvider

## -description

Specifies a contract for a scrolling control that supports scroll anchoring.



## -remarks

### Scroll Anchoring

Scroll anchoring is when a scrolling control automatically changes the position of its viewport to prevent the content from visibly jumping. The jump is caused by a change in the content's layout. The scroll anchor provider applies a shift after observing a change in the position of an *anchor element* within the content.

It's the responsibility of the implementing scroll control to determine what policy it will use in choosing a [CurrentAnchor](iscrollanchorprovider_currentanchor.md) from the set of registered candidates.  

#### Expected Behavior

When a layout change impacts the size/position of the anchor element, the viewport should automatically shift to maintain the previous position of the anchor element relative to the viewport.

Scroll anchoring (i.e. an automatic viewport shift) doesn't apply at all times. It should happen as a result of candidate elements being added to or removed from the tree or changing in size.  Other situations that may trigger a layout pass, but do not necessarily cause automatic viewport shifts would include:

- A user panning the content
- A developer programmatically changing the view
- Handling a [BringIntoViewRequested](../windows.ui.xaml/uielement_bringintoviewrequested.md) event

#### The Anchor Element

The implementing control should choose an *anchor element* from the set of previously registered candidates and set it as its [CurrentAnchor](iscrollanchorprovider_currentanchor.md).

#### Candidate Anchor Elements

The set of candidate anchor elements may change during any of the situations called out previously. Elements are registered as potential anchor candidates by:

1. setting their [UIElement.CanBeScrollAnchor](../windows.ui.xaml/uielement_canbescrollanchor.md) property to **true**, or
1. programmatically registering the element using the [RegisterAnchorCandidate](iscrollanchorprovider_registeranchorcandidate_178281111.md) method.

The [CanBeScrollAnchor](../windows.ui.xaml/uielement_canbescrollanchor.md) property can be set at any time. When set, the framework implicitly calls [RegisterAnchorCandidate](iscrollanchorprovider_registeranchorcandidate_178281111.md)/[UnregisterAnchorCandidate](iscrollanchorprovider_unregisteranchorcandidate_667335027.md), but only on the first IScrollAnchorProvider found in that element's chain of ancestors.

The framework similarly registers/unregisters elements with [CanBeScrollAnchor](../windows.ui.xaml/uielement_canbescrollanchor.md) set to **true** as they are added or removed from the live visual tree. But, once again, it is only done with the first IScrollAnchorProvider found in the element's chain of ancestors.

A virtualizing control may choose to automatically set the [CanBeScrollAnchor](../windows.ui.xaml/uielement_canbescrollanchor.md) on its generated children elements.

### ScrollViewer: An Example

The [ScrollViewer](scrollviewer.md) control performs scroll anchoring during its [ArrangeOverride](../windows.ui.xaml/frameworkelement_arrangeoverride_1795048387.md). It raises an [AnchorRequested](../windows.ui.xaml.controls/scrollviewer_anchorrequested.md) event at the beginning of [ArrangeOverride](../windows.ui.xaml/frameworkelement_arrangeoverride_1795048387.md), which provides you with an opportunity to explicitly specify the anchor element. Otherwise, it chooses a candidate in the viewport that is closest to a viewport-relative *anchor point* and then sets that element as its [CurrentAnchor](scrollviewer_currentanchor.md).  

The anchor point comes from the [HorizontalAnchorRatio](scrollviewer_horizontalanchorratio.md) and [VerticalAnchorRatio](scrollviewer_verticalanchorratio.md) properties. When the ratios are zero (default), the anchor point is the top left corner of the viewport (assuming the FlowDirection is LeftToRight). If the ratios are both set to 0.5 then the anchor point is the center of the viewport. Similarly, when the ratios are both 1.0 then the anchor point is the bottom right corner of the viewport.  

#### Special Case: Anchoring at the edge

The beginning or end of the scrollable content represents a special anchor scenario. For example, consider the expected behavior when a user in an email application has vertically scrolled down the list by some amount. When a new message arrives it is inserted at the top of the list (outside the bounds of content the user currently sees). What the user currently sees should not suddenly jump to a new position due to the arrival of a new message at the top of the list. However, if their current scroll position is at the top, then the existing content should appear to shift down to make room for the new message.  

The inverse scenario is a chat experience. When the user is scrolled to the very bottom and a new message arrives the content should appear to shift up to make room to display the new message. In reality, what happens is that the viewport needs to shift down to track the new end of the scrollable content. When the user is not scrolled to the very beginning/end of the content, then the position of the viewport with respect to some visible content that is considered "interesting" should remain in sync (i.e. anchored).

The ScrollViewer treats the values of 0.0 and 1.0 for the [HorizontalAnchorRatio](scrollviewer_horizontalanchorratio.md) and [VerticalAnchorRatio](scrollviewer_verticalanchorratio.md) properties with special behavior. If both the value is 0.0 and the user is scrolled to the start, then the start position is used as the anchor instead of an anchor candidate. Similarly, if both the value is 1.0 and the user is scrolled to the end then the end of the content is used as the anchor. If the position of the end grows due to size changes then the new end is used.

## -see-also

[ScrollViewer.AnchorRequested](scrollviewer_anchorrequested.md), [UIElement.CanBeScrollAnchor](../windows.ui.xaml/uielement_canbescrollanchor.md), [UIElement.BringIntoViewRequested](../windows.ui.xaml/uielement_bringintoviewrequested.md), [UIElement.RegisterAsScrollPort](../windows.ui.xaml/uielement_registerasscrollport_591917999.md)

## -examples
