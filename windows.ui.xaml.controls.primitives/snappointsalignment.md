---
-api-id: T:Windows.UI.Xaml.Controls.Primitives.SnapPointsAlignment
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Xaml.Controls.Primitives.SnapPointsAlignment : int
-->

# SnapPointsAlignment

## -description
Defines constants that specify options for snap point alignment relative to an edge. Which edge depends on the orientation of the object where the alignment is applied.


## -xaml-syntax
```xaml
<object property="enumMemberName" />
```


## -enum-fields
### -field Near:0
Use snap points grouped closer to the orientation edge.

### -field Center:1
Use snap points that are centered in the orientation.

### -field Far:2
Use snap points grouped farther from the orientation edge.


## -remarks
This enumeration is used as a value by [ScrollViewer.HorizontalSnapPointsAlignment](../windows.ui.xaml.controls/scrollviewer_horizontalsnappointsalignment.md) and [ScrollViewer.VerticalSnapPointsAlignment](../windows.ui.xaml.controls/scrollviewer_verticalsnappointsalignment.md). It's also used as a parameter type for [IScrollSnapPointsInfo.GetIrregularSnapPoints](iscrollsnappointsinfo_getirregularsnappoints_889794128.md) and [IScrollSnapPointsInfo.GetRegularSnapPoints](iscrollsnappointsinfo_getregularsnappoints_980074349.md), and implementations of those methods on types, such as [StackPanel.GetIrregularSnapPoints](../windows.ui.xaml.controls/stackpanel_getirregularsnappoints_889794128.md).

For a vertically oriented element, **Near** is the top and **Far** is the bottom. For a horizontally oriented element, **Near** is left and **Far** is right.

To learn more about the swipe gesture and panning, see the "Panning behaviors" section of [Guidelines for panning](/windows/uwp/input-and-devices/guidelines-for-panning).


<!--Does RTL change these assumptions?-->

## -examples

## -see-also
[ScrollViewer](../windows.ui.xaml.controls/scrollviewer.md), [IScrollSnapPointsInfo](iscrollsnappointsinfo.md)
