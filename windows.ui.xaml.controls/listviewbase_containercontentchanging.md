---
-api-id: E:Windows.UI.Xaml.Controls.ListViewBase.ContainerContentChanging
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler ContainerContentChanging<Windows.UI.Xaml.Controls.ListViewBase,  Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs>
-->

# Windows.UI.Xaml.Controls.ListViewBase.ContainerContentChanging

## -description
Occurs when the data item associated with a UI container changes.

## -xaml-syntax
```xaml
<listViewBase ContainerContentChanging="eventhandler" />
```


## -remarks
This event is raised only if the list or grid's [ItemsPanel](itemscontrol_itemspanel.md) is an [ItemsStackPanel](itemsstackpanel.md) or [ItemsWrapGrid](itemswrapgrid.md). If you replace the [ItemsPanel](itemscontrol_itemspanel.md) with another panel, the event is not raised.

For info and examples, see the [Update ListView and GridView items incrementally](https://msdn.microsoft.com/library/26df15e8-2c05-4174-a714-7df2e8273d32) section of [Optimize ListView and GridView](https://msdn.microsoft.com/library/26df15e8-2c05-4174-a714-7df2e8273d32).

For more examples, download the [XAML GridView grouping and SemanticZoom sample](https://go.microsoft.com/fwlink/p/?linkid=226564).

## -examples

## -see-also
[Optimize ListView and GridView](https://msdn.microsoft.com/library/26df15e8-2c05-4174-a714-7df2e8273d32), [XAML GridView grouping and SemanticZoom sample](https://go.microsoft.com/fwlink/p/?linkid=226564)
