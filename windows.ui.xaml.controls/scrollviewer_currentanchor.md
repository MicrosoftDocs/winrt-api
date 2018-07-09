---
-api-id: P:Windows.UI.Xaml.Controls.ScrollViewer.CurrentAnchor
-api-type: winrt property
---

<!-- Property syntax.
public UIElement CurrentAnchor { get; }
-->

# Windows.UI.Xaml.Controls.ScrollViewer.CurrentAnchor

## -description
The currently chosen anchor element to use for scroll anchoring.

## -property-value
The most recently chosen [UIElement](../windows.ui.xaml/uielement) for scroll anchoring after a layout pass, or **null**.

## -remarks
If there are no anchor candidates registered with the [ScrollViewer](scrollviewer) or none have been chosen, then [CurrentAnchor](scrollviewer_currentanchor) is **null**. 

## -see-also
* [IScrollAnchorProvider](iscrollanchorprovider)

## -examples

