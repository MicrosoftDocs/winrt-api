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
VirtualizingStackPanel can only be used to display items in an [ItemsControl](itemscontrol.md). A primary scenario for VirtualizingStackPanel is that it provides the items panel template behavior for [FlipView](flipview.md) and [ListBox](listbox.md) in default templates.

> [!NOTE]
> Starting in Windows 8.1, [ItemsStackPanel](itemsstackpanel.md) is used as the default [ItemsPanel](itemscontrol_itemspanel.md) for [ListView](listview.md). If you modify the [ItemsPanel](itemscontrol_itemspanel.md), we recommend you use [ItemsStackPanel](itemsstackpanel.md) or [ItemsWrapGrid](itemswrapgrid.md) instead of VirtualizingStackPanel or [WrapGrid](wrapgrid.md).

### XAML attached properties

VirtualizingStackPanel is the host service class for several [XAML attached properties](/windows/uwp/xaml-platform/attached-properties-overview).

In order to support XAML processor access to the attached properties, and also to expose equivalent _get_ and _set_ operations to code, each XAML attached property has a pair of Get and Set accessor methods. Another way to get or set the value in code is to use the dependency property system, calling either [GetValue](../windows.ui.xaml/dependencyobject_getvalue_1188551207.md) or [SetValue](../windows.ui.xaml/dependencyobject_setvalue_52578133.md) and passing the identifier field as the dependency property identifier.

| Attached property | Description |
| - | - |
| [IsVirtualizing](virtualizingstackpanel_isvirtualizing.md) | See Remarks on property page. |
| [VirtualizationMode](virtualizingstackpanel_virtualizationmode.md) | Gets or sets a value that indicates the virtualization mode of items being virtualized by a parent VirtualizingStackPanel and items set. |

## -examples

## -see-also
[OrientedVirtualizingPanel](../windows.ui.xaml.controls.primitives/orientedvirtualizingpanel.md), [IScrollSnapPointsInfo](../windows.ui.xaml.controls.primitives/iscrollsnappointsinfo.md), [ItemsControl.ItemsPanel](itemscontrol_itemspanel.md), [ItemsPanelTemplate](itemspaneltemplate.md), [Quickstart: Adding ListView and GridView controls](/previous-versions/windows/apps/hh780650(v=win.10))
