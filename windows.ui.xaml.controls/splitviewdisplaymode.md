---
-api-id: T:Windows.UI.Xaml.Controls.SplitViewDisplayMode
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Xaml.Controls.SplitViewDisplayMode : int
-->

# SplitViewDisplayMode

## -description
Defines constants that specify how the pane is shown in a [SplitView](splitview.md).



## -enum-fields
### -field Overlay:0
The pane covers the content when it's open and does not take up space in the control layout. The pane closes when the user taps outside of it.

### -field Inline:1
The pane is shown side-by-side with the content and takes up space in the control layout. The pane does not close when the user taps outside of it.

### -field CompactOverlay:2
The amount of the pane defined by the [CompactPaneLength](splitview_compactpanelength.md) property is shown side-by-side with the content and takes up space in the control layout. The remaining part of the pane covers the content when it's open and does not take up space in the control layout. The pane closes when the user taps outside of it.

### -field CompactInline:3
The amount of the pane defined by the [CompactPaneLength](splitview_compactpanelength.md) property is shown side-by-side with the content and takes up space in the control layout. The remaining part of the pane pushes the content to the side when it's open and takes up space in the control layout. The pane does not close when the user taps outside of it.


## -remarks
These enumeration values are used with the [SplitView.DisplayMode](splitview_displaymode.md) property.

## -examples

## -see-also
[SplitView](splitview.md), [SplitView.DisplayMode](splitview_displaymode.md)
