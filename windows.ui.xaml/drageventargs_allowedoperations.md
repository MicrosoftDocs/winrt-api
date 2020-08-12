---
-api-id: P:Windows.UI.Xaml.DragEventArgs.AllowedOperations
-api-type: winrt property
---

<!-- Property syntax
public Windows.ApplicationModel.DataTransfer.DataPackageOperation AllowedOperations { get; }
-->

# Windows.UI.Xaml.DragEventArgs.AllowedOperations

## -description
Gets the allowed data package operations (none, move, copy, and/or link) for the drag and drop operation.

## -property-value
The allowed data operations.

## -remarks
For more info about the allowed data operations, see [DataPackageOperation](../windows.applicationmodel.datatransfer/datapackageoperation.md).

This value is set in the [DragStarting](uielement_dragstarting.md) event handler. See the DragStartingEventArgs.AllowedOperations property.

## -examples

## -see-also
[Drag-and-drop overview](/windows/uwp/design/input/drag-and-drop), [DragStarting](uielement_dragstarting.md), DragStartingEventArgs.AllowedOperations, [CoreDragOperation.AllowedOperations](../windows.applicationmodel.datatransfer.dragdrop.core/coredragoperation_allowedoperations.md)
