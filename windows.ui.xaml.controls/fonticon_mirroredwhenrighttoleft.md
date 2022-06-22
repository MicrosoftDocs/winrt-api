---
-api-id: P:Windows.UI.Xaml.Controls.FontIcon.MirroredWhenRightToLeft
-api-type: winrt property
---

<!-- Property syntax
public bool MirroredWhenRightToLeft { get;  set; }
-->

# Windows.UI.Xaml.Controls.FontIcon.MirroredWhenRightToLeft

## -description
Gets or sets a value that indicates whether the icon is mirrored when the [FlowDirection](../windows.ui.xaml/frameworkelement_flowdirection.md) is **RightToLeft**.



## -property-value
**true** if the icon is mirrored when the [FlowDirection](../windows.ui.xaml/frameworkelement_flowdirection.md) is [FlowDirection.RightToLeft](../windows.ui.xaml/flowdirection.md); otherwise, **false**. The default is **false**.

## -remarks
You can set the MirroredWhenRightToLeft property to have the glyph appear mirrored when the [FlowDirection](../windows.ui.xaml/frameworkelement_flowdirection.md) is [RightToLeft](../windows.ui.xaml/flowdirection.md). You typically use this property when a [FontIcon](fonticon.md) is used to display an icon as part of a control template and the icon needs to be mirrored along with the rest of the control.

## -examples

## -see-also
[FlowDirection](../windows.ui.xaml/frameworkelement_flowdirection.md), [How to support bidirectional UI](/previous-versions/windows/apps/jj712703(v=win.10)), [How to adjust layout and fonts for various languages, and support RTL layouts](/previous-versions/windows/apps/hh967760(v=win.10))
