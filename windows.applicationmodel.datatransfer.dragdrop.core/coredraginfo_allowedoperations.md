---
-api-id: P:Windows.ApplicationModel.DataTransfer.DragDrop.Core.CoreDragInfo.AllowedOperations
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.ApplicationModel.DataTransfer.DataPackageOperation AllowedOperations { get; }
-->

# Windows.ApplicationModel.DataTransfer.DragDrop.Core.CoreDragInfo.AllowedOperations

## -description
Gets the allowed [DataPackageOperations](../windows.applicationmodel.datatransfer/datapackageoperation.md) (none, move, copy, and/or link) for the drag and drop operation.

## -property-value
The allowed operations.

## -remarks
This property specifies the complete set of operations the source app wishes to allow in drag and drop scenarios. There can be zero or more flags. To get the requested default operation, use the [DataPackage.RequestedOperation](../windows.applicationmodel.datatransfer/datapackage_requestedoperation.md) property.

Users can override this choices by using **SHIFT** and **CTRL** keys. In this case, inspect the key state to determine the operation the user selected.

## -examples

## -see-also
