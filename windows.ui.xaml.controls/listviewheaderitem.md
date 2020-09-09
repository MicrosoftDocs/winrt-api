---
-api-id: T:Windows.UI.Xaml.Controls.ListViewHeaderItem
-api-type: winrt class
---

<!-- Class syntax.
public class ListViewHeaderItem : Windows.UI.Xaml.Controls.ListViewBaseHeaderItem, Windows.UI.Xaml.Controls.IListViewHeaderItem
-->

# Windows.UI.Xaml.Controls.ListViewHeaderItem

## -description
Represents items in the header for grouped data inside a [ListView](listview.md).

## -remarks
ListViewHeaderItem is a control that's created by the system and added to the visual tree when the data templates for a grouped [ListView](listview.md) are realized. Specifically, it's created when realizing the [GroupStyle.HeaderTemplate](groupstyle_headertemplate.md). You don't typically define elements for ListViewHeaderItem in XAML. There's a default template for ListViewHeaderItem as part of the built-in templates. The main app scenario for the ListViewHeaderItem class is to copy and replace the default style and template with a style of your own, which also implicitly targets ListViewHeaderItem.

There's a dedicated automation peer class for ListViewHeaderItem, [ListViewHeaderItemAutomationPeer](../windows.ui.xaml.automation.peers/listviewheaderitemautomationpeer.md). This is because after the [ListView](listview.md) is realized, all the created item parts need automation representation, so that Microsoft UI Automation can report them in the tree it provides for assistive technology and other Microsoft UI Automation clients.

If you use the [GroupStyle.HeaderContainerStyle](groupstyle_headercontainerstyle.md) property, the [Style](../windows.ui.xaml/style.md) it contains must have a [TargetType](../windows.ui.xaml/style_targettype.md) value of either ListViewHeaderItem or [GridViewHeaderItem](gridviewheaderitem.md).

### Control style and template

You can modify the default [Style](../windows.ui.xaml/style.md) and [ControlTemplate](controltemplate.md) to give the control a unique appearance. For information about modifying a control's style and template, see [Styling controls](/windows/uwp/controls-and-patterns/styling-controls). The default style, template, and resources that define the look of the control are included in the generic.xaml file. For design purposes, generic.xaml is available in the \(Program Files)\Windows Kits\10\DesignTime\CommonConfiguration\Neutral\UAP\ &lt;SDK version&gt;\Generic folder from a Windows Software Development Kit (SDK) installation. Styles and resources from different versions of the SDK might have different values.

Starting in Windows 10, version 1607 (SDK 14393), generic.xaml includes resources that you can use to modify the colors of a control in different visual states without modifying the control template. In apps that target this software development kit (SDK) or later, modifying these resources is preferred to setting properties such as [Background](control_background.md) and [Foreground](control_foreground.md). For more info, see the [Light-weight styling](/windows/uwp/controls-and-patterns/styling-controls) section of the [Styling controls](/windows/uwp/controls-and-patterns/styling-controls) article.

This table shows the resources used by the ListViewHeaderItem control.

<table>
   <tr><th>Resource key</th><th>Description</th></tr>
   <tr><td>ListViewHeaderItemBackground</td><td>Item background color</td></tr>
   <tr><td>ListViewHeaderItemDividerStroke</td><td>Divider line color</td></tr>
</table>

## -examples

## -see-also
[ListViewBaseHeaderItem](listviewbaseheaderitem.md), [ListView](listview.md), [GroupStyle property](itemscontrol_groupstyle.md), [GroupStyle.HeaderTemplate](groupstyle_headertemplate.md), [ListViewHeaderItem styles and templates](/windows/uwp/design/controls-and-patterns/xaml-styles)
