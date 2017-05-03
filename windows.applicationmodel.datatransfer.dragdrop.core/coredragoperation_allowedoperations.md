---
-api-id: P:Windows.ApplicationModel.DataTransfer.DragDrop.Core.CoreDragOperation.AllowedOperations
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.ApplicationModel.DataTransfer.DataPackageOperation AllowedOperations { get;  set; }
-->

# Windows.ApplicationModel.DataTransfer.DragDrop.Core.CoreDragOperation.AllowedOperations

## -description
Gets or sets the allowed [DataPackageOperations](../windows.applicationmodel.datatransfer/datapackageoperation.md) (none, move, copy, and/or link) for the drag and drop operation.

## -property-value
The allowed operations. The default is **Copy** | **Move** | **Link**.

## -remarks
Use this property to set the complete set of operations the source app wishes to allow in drag and drop scenarios. You can specify zero or more flags. To set a desired default operation, use the [DataPackage.RequestedOperation](../windows.applicationmodel.datatransfer/datapackage_requestedoperation.md) property.

Users can override this choices by using **SHIFT** and **CTRL** keys. In this case, the target app must inspect the key state to determine the operation the user selected.

## -examples

## -see-also
