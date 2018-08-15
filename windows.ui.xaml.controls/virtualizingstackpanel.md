---
-api-id: T:Windows.UI.Xaml.Controls.VirtualizingStackPanel
-api-type: winrt class
---

<!-- Class syntax.
public class VirtualizingStackPanel : Windows.UI.Xaml.Controls.Primitives.OrientedVirtualizingPanel, Windows.UI.Xaml.Controls.IVirtualizingStackPanel, Windows.UI.Xaml.Controls.IVirtualizingStackPanelOverrides
-->

# Windows.UI.Xaml.Controls.VirtualizingStackPanel

## -description
Arranges and virtualizes content on a single line that is oriented either horizontally or vertically. Can only be used to display items in an [ItemsControl](itemscontrol.md).

## -xaml-syntax
```xaml
<VirtualizingStackPanel .../>
-or-
<VirtualizingStackPanel ...>
  oneOrMoreChildren
</VirtualizingStackPanel>

```


## -remarks
[VirtualizingStackPanel](virtualizingstackpanel.md) can only be used to display items in an [ItemsControl](itemscontrol.md). A primary scenario for [VirtualizingStackPanel](virtualizingstackpanel.md) is that it provides the items panel template behavior for [FlipView](flipview.md) and [ListBox](listbox.md) in default templates.

> [!NOTE]
> Starting in Windows 8.1, [ItemsStackPanel](itemsstackpanel.md) is used as the default [ItemsPanel](itemscontrol_itemspanel.md) for [ListView](listview.md). If you modify the [ItemsPanel](itemscontrol_itemspanel.md), we recommend you use [ItemsStackPanel](itemsstackpanel.md) or [ItemsWrapGrid](itemswrapgrid.md) instead of [VirtualizingStackPanel](virtualizingstackpanel.md) or [WrapGrid](wrapgrid.md).

### VirtualizingStackPanel attached properties

[VirtualizingStackPanel](virtualizingstackpanel.md) is the host service class for several attached properties that control or report the virtualization mode:


+ [VirtualizingStackPanel.VirtualizationMode](virtualizingstackpanel_virtualizationmode.md)
+ **VirtualizingStackPanel.IsVirtualizing**


[VirtualizingStackPanel.VirtualizationMode](virtualizingstackpanel_virtualizationmode.md) is an Extensible Application Markup Language (XAML) attached property, and child elements set this property in markup to declare how the item should be virtualized when included as a [VirtualizingStackPanel](virtualizingstackpanel.md) child element.

**VirtualizingStackPanel.IsVirtualizing** uses the attached property model as a property store, but does not support a Extensible Application Markup Language (XAML) usage. Instead, the property serves as a sentinel that any [VirtualizingStackPanel](virtualizingstackpanel.md) child element can check to determine whether that child is currently being represented as virtualized. To find out if an item is being virtualized, call [GetIsVirtualizing](virtualizingstackpanel_getisvirtualizing_1946654319.md), passing the item as the input parameter.

## -examples

## -see-also
[OrientedVirtualizingPanel](../windows.ui.xaml.controls.primitives/orientedvirtualizingpanel.md), [IScrollSnapPointsInfo](../windows.ui.xaml.controls.primitives/iscrollsnappointsinfo.md), [ItemsControl.ItemsPanel](itemscontrol_itemspanel.md), [ItemsPanelTemplate](itemspaneltemplate.md), [Quickstart: Adding ListView and GridView controls](http://msdn.microsoft.com/library/b237d616-33de-4ddd-9df5-27c47f81b064)