---
-api-id: P:Windows.UI.Xaml.DragStartingEventArgs.AllowedOperations
-api-type: winrt property
---

<!-- Property syntax
public Windows.ApplicationModel.DataTransfer.DataPackageOperation AllowedOperations { get;  set; }
-->

# Windows.UI.Xaml.DragStartingEventArgs.AllowedOperations

## -description

Gets or sets a value that specifies which operations (none, move, copy, and/or link) are allowed by the source of the drag event.

## -property-value

A value or bitwise combination of values that specifies which operations are allowed by the source of the drag event.

## -remarks

This value is set in the [UIElement.DragStarting](uielement_dragstarting.md) event handler. It can then be read from the [DragEventArgs.AllowedOperations](drageventargs_allowedoperations.md) property in the [DragEnter](uielement_dragenter.md) and [DragOver](uielement_dragover.md) events of the `UIElement` that is a potential drop target of the drag and drop operation. It notifies the target which data package operations (none, move, copy, and/or link) are allowed by the source.

For more info about the allowed data operations, see the [DataPackageOperation](../windows.applicationmodel.datatransfer/datapackageoperation.md) enumeration.

## -examples

## -see-also

[Drag-and-drop overview](/windows/uwp/design/input/drag-and-drop), [DragEventArgs.AllowedOperations](drageventargs_allowedoperations.md), [CoreDragOperation.AllowedOperations](../windows.applicationmodel.datatransfer.dragdrop.core/coredragoperation_allowedoperations.md)
