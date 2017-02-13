---
-api-id: P:Windows.UI.Xaml.Controls.InkToolbar.Children
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.DependencyObjectCollection Children { get; }
-->

# Windows.UI.Xaml.Controls.InkToolbar.Children

## -description
Gets the collection of custom buttons displayed on the [InkToolbar](inktoolbar.md).

## -property-value
A collection of [InkToolbar](inktoolbar.md) custom buttons.

## -remarks
[Children](inktoolbar_children.md) returns only the number of buttons on the [InkToolbar](inktoolbar.md) that have been added manually (see [ActiveTool](inktoolbar_activetool.md) and [InitialControls](inktoolbar_initialcontrols.md)). The default [InkToolbar](inktoolbar.md) does not add any buttons to the value of this property.

[Children](inktoolbar_children.md) does not include buttons declared in markup.


The [InkToolbar](inktoolbar.md) consists of two distinct groups of button types:

+ One group of "tool" buttons containing the built-in drawing ([InkToolbarBallpointPenButton](inktoolbarballpointpenbutton.md), [InkToolbarPencilButton](inktoolbarpencilbutton.md)), erasing ([InkToolbarEraserButton](inktoolbareraserbutton.md)), and highlighting ([InkToolbarHighlighterButton](inktoolbarhighlighterbutton.md)) buttons. Custom tools ([InkToolbarCustomPenButton](inktoolbarcustompenbutton.md) and [InkToolbarCustomToolButton](inktoolbarcustomtoolbutton.md)) are added here.

> Feature selection is mutually exclusive.
+ A second group of "toggle" buttons containing the built-in ruler ([InkToolbarRulerButton](inktoolbarrulerbutton.md)) button. Custom toggles ([InkToolbarCustomToggleButton](inktoolbarcustomtogglebutton.md)) are added here.

> Features are not mutually exclusive and can be used concurrently with other active tools.


## -examples

## -see-also
[ChildrenProperty](inktoolbar_childrenproperty.md)