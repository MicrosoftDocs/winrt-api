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

DragEventArgs is used as event data for these events:

+ [UIElement.DragEnter](uielement_drop.md)
+ [UIElement.DragLeave](uielement_dragleave.md)
+ [UIElement.DragOver](uielement_dragover.md)
+ [UIElement.Drop](uielement_drop.md)

These events are routed events. Changing the value of the [Handled](drageventargs_handled.md) property of DragEventArgs from an event handler can influence how a routed event behaves. For more info on the routed event concept, see [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview).

The [Control](../windows.ui.xaml.controls/control.md) class has pre-wired event handlers that [Control](../windows.ui.xaml.controls/control.md) derived types can override to provide class-based handling for the drag-drop events, and these methods also use DragEventArgs as a parameter. These methods are:

+ [Control.OnDragEnter](../windows.ui.xaml.controls/control_ondragenter_196818472.md)
+ [Control.OnDragLeave](../windows.ui.xaml.controls/control_ondragleave_545548419.md)
+ [Control.OnDragOver](../windows.ui.xaml.controls/control_ondragover_783114431.md)
+ [Control.OnDrop](../windows.ui.xaml.controls/control_ondrop_1015747496.md)

The Windows Runtime implementation of drag-drop concepts permits only certain controls and input actions to initiate a drag-drop action. There is no generalized **DoDragDrop** method that would permit any UI element to initiate a drag-drop action. The main source of a drag-drop action is when you drag the items of a list such as [GridView](../windows.ui.xaml.controls/gridview.md). For a list item drag-drop action, the [Data](drageventargs_data.md) value in event data can potentially be modified from the control-defined default data about the item. This is done by handling the [DragItemsStarting](../windows.ui.xaml.controls/listviewbase_dragitemsstarting.md) event, and working with the [DataPackage](../windows.applicationmodel.datatransfer/datapackage.md) object that is obtained from the [DragItemsStartingEventArgs.Data](../windows.ui.xaml.controls/dragitemsstartingeventargs_data.md) property in the event data.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | AllowedOperations |

## -examples

## -see-also

[Drag-and-drop overview](/windows/uwp/design/input/drag-and-drop), [RoutedEventArgs](routedeventargs.md), [ListViewBase](../windows.ui.xaml.controls/listviewbase.md), [UIElement](uielement.md), [AllowDrop](uielement_allowdrop.md), [Drag and drop sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlDragAndDrop)
