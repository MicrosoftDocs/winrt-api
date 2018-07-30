---
-api-id: T:Windows.UI.Xaml.DragEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class DragEventArgs : Windows.UI.Xaml.RoutedEventArgs, Windows.UI.Xaml.IDragEventArgs, Windows.UI.Xaml.IDragEventArgs2, Windows.UI.Xaml.IDragEventArgs3
-->

# Windows.UI.Xaml.DragEventArgs

## -description

Provides data for drag-and-drop events.

## -remarks

[DragEventArgs](drageventargs.md) is used as event data for these events:

+ [UIElement.DragEnter](uielement_drop.md)
+ [UIElement.DragLeave](uielement_dragleave.md)
+ [UIElement.DragOver](uielement_dragover.md)
+ [UIElement.Drop](uielement_drop.md)

These events are routed events. Changing the value of the [Handled](drageventargs_handled.md) property of [DragEventArgs](drageventargs.md) from an event handler can influence how a routed event behaves. For more info on the routed event concept, see [Events and routed events overview](http://msdn.microsoft.com/library/34c219e8-3efb-45bc-8bbd-6fd937698832).

The [Control](../windows.ui.xaml.controls/control.md) class has pre-wired event handlers that [Control](../windows.ui.xaml.controls/control.md) derived types can override to provide class-based handling for the drag-drop events, and these methods also use [DragEventArgs](drageventargs.md) as a parameter. These methods are:

+ [Control.OnDragEnter](../windows.ui.xaml.controls/control_ondragenter.md)
+ [Control.OnDragLeave](../windows.ui.xaml.controls/control_ondragleave.md)
+ [Control.OnDragOver](../windows.ui.xaml.controls/control_ondragover.md)
+ [Control.OnDrop](../windows.ui.xaml.controls/control_ondrop.md)

The Windows Runtime implementation of drag-drop concepts permits only certain controls and input actions to initiate a drag-drop action. There is no generalized **DoDragDrop** method that would permit any UI element to initiate a drag-drop action. The main source of a drag-drop action is when you drag the items of a list such as [GridView](../windows.ui.xaml.controls/gridview.md). For a list item drag-drop action, the [Data](drageventargs_data.md) value in event data can potentially be modified from the control-defined default data about the item. This is done by handling the [DragItemsStarting](../windows.ui.xaml.controls/listviewbase_dragitemsstarting.md) event, and working with the [DataPackage](../windows.applicationmodel.datatransfer/datapackage.md) object that is obtained from the [DragItemsStartingEventArgs.Data](../windows.ui.xaml.controls/dragitemsstartingeventargs_data.md) property in the event data.

## -examples

## -see-also

[RoutedEventArgs](routedeventargs.md), [ListViewBase](../windows.ui.xaml.controls/listviewbase.md), [UIElement](uielement.md), [AllowDrop](uielement_allowdrop.md), [Drag and drop sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=620634)