---
-api-id: P:Windows.UI.Xaml.Controls.AnchorRequestedEventArgs.Anchor
-api-type: winrt property
---

<!-- Property syntax.
public UIElement Anchor { get;  set; }
-->

# Windows.UI.Xaml.Controls.AnchorRequestedEventArgs.Anchor

## -description
Gets or sets the *anchor element* to use when performing scroll anchoring.

## -property-value
The [UIElement](../windows.ui.xaml/uielement) to use as the [CurrentAnchor](iscrollanchorprovider_currentanchor).  By default, the value is **null**.

## -remarks
The element must be a descendent of the scrolling control.

## -see-also
* [IScrollAnchorProvider](iscrollanchorprovider)
* [ScrollViewer.AnchorRequested](scrollviewer_anchorrequested)

## -examples

