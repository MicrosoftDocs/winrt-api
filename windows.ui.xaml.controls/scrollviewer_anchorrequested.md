---
-api-id: E:Windows.UI.Xaml.Controls.ScrollViewer.AnchorRequested
-api-type: winrt event
---

<!-- Event syntax.
public event TypedEventHandler AnchorRequested<ScrollViewer, AnchorRequestedEventArgs>
-->

# Windows.UI.Xaml.Controls.ScrollViewer.AnchorRequested

## -description
Occurs when an anchor is requested at the beginning of the Arrange pass.  Use this event to override the ScrollViewer's default logic to select an anchor element as part of *scroll anchoring*.

## -remarks
Explicitly set the [Anchor](anchorrequestedeventargs_anchor) property of the [AnchorRequestedEventArgs](anchorrequestedeventargs) to a UIElement within the [ScrollViewer](scrollviewer)'s subtree to override the default policy of choosing an anchor element.  The [AnchorCandidates](anchorrequestedeventargs_anchorcandidates) property provides the list of candidates currently registered with the [ScrollViewer](scrollviewer).

## -see-also
* [IScrollAnchorProvider](iscrollanchorprovider)

## -examples

