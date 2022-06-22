---
-api-id: P:Windows.UI.Xaml.DragStartingEventArgs.Data
-api-type: winrt property
---

<!-- Property syntax
public Windows.ApplicationModel.DataTransfer.DataPackage Data { get; }
-->

# Windows.UI.Xaml.DragStartingEventArgs.Data

## -description
Gets the data payload associated with a drag action.



## -property-value
The data payload. The default is an empty [DataPackage](../windows.applicationmodel.datatransfer/datapackage.md).

## -remarks
In your [DragStarting](uielement_dragstarting.md) event handler, use the [DataPackage.SetData](../windows.applicationmodel.datatransfer/datapackage_setdata_2074524277.md) method to provide the data being dragged.

## -examples

## -see-also

[Drag-and-drop overview](/windows/uwp/design/input/drag-and-drop)
