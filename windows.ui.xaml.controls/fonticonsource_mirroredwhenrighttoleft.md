---
-api-id: P:Windows.UI.Xaml.Controls.FontIconSource.MirroredWhenRightToLeft
-api-type: winrt property
---

<!-- Property syntax.
public bool MirroredWhenRightToLeft { get;  set; }
-->

# Windows.UI.Xaml.Controls.FontIconSource.MirroredWhenRightToLeft

## -description

Gets or sets a value that indicates whether the icon is mirrored when its containing element's [FlowDirection](../windows.ui.xaml/frameworkelement_flowdirection.md) is **RightToLeft**.

## -xaml-syntax

```xaml
<FontIconSource MirroredWhenRightToLeft="bool"/>
```

## -property-value

**true** if the icon is mirrored when the [FlowDirection](../windows.ui.xaml/frameworkelement_flowdirection.md) is [FlowDirection.RightToLeft](../windows.ui.xaml/flowdirection.md); otherwise, **false**. The default is **false**.

## -remarks

You can set the [MirroredWhenRightToLeft](fonticon_mirroredwhenrighttoleft.md) property to have the glyph appear mirrored when its containing element's [FlowDirection](../windows.ui.xaml/frameworkelement_flowdirection.md) is [RightToLeft](../windows.ui.xaml/flowdirection.md). You typically use this property when a [FontIcon](fonticon.md) is used to display an icon as part of a control template and the icon needs to be mirrored along with the rest of the control.

## -see-also

## -examples

