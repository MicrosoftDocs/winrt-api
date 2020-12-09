---
-api-id: P:Windows.ApplicationModel.DataTransfer.DataPackage.RequestedOperation
-api-type: winrt property
---

<!-- Property syntax
public Windows.ApplicationModel.DataTransfer.DataPackageOperation RequestedOperation { get;  set; }
-->

# Windows.ApplicationModel.DataTransfer.DataPackage.RequestedOperation

## -description
Specifies the [DataPackageOperation](datapackageoperation.md) (none, move, copy, or link) for the operation.

## -property-value
The operation requested by the source app.

## -remarks
This property specifies the operation the consumer of a data package should perform in clipboard or drag and drop scenarios. The supported options are specified in the [DataPackageOperation](datapackageoperation.md) enumeration.

When implementing clipboard functionality, [DataPackageOperation.Move](datapackageoperation.md) corresponds to the "Cut" command and [DataPackageOperation.Copy](datapackageoperation.md) to "Copy" command. It is the target of the operation's responsibility to respect this value and report that they performed a cut or copy by calling [DataPackageView.ReportOperationComplete](datapackageview_reportoperationcompleted_467480582.md) with the appropriate value.

In drag and drop scenarios, [CoreDragOperation.AllowedOperations](../windows.applicationmodel.datatransfer.dragdrop.core/coredraginfo_allowedoperations.md) should specify the complete set of operations the source allows, and DataPackage.RequestedOperation should specify the source's desired default. Users can override this choices by using **SHIFT** and **CTRL** keys. Target apps must inspect the key state to determine the operation the user has selected. 

> [!NOTE]
> [CoreDragOperation.AllowedOperations](../windows.applicationmodel.datatransfer.dragdrop.core/coredraginfo_allowedoperations.md) is not supported in XAML. To specify more than one allowed operation in XAML, pass multiple flags to the DataPackage.RequestedOperation property instead. If you do, you should not set [CoreDragOperation.AllowedOperations](../windows.applicationmodel.datatransfer.dragdrop.core/coredraginfo_allowedoperations.md) elsewhere. Doing so will throw an exception and reset the specified flags of DataPackage.RequestedOperation to one.

Normally, DataPackage.RequestedOperation property should specify only a single operation. However, in some interop scenarios (such as copying between a Universal Windows Platform (UWP) app and File Explorer), it can contain more. In this case, the target app should select the best operation (assuming keyboard modifiers have not overridden that choice).

You do not need this property for sharing operations.

## -examples
```csharp
// Request a copy operation 
datapackage.RequestedOperation = DataPackageOperation.Copy;

// find what the requested operation is
DataPackageOperation operation = dataPackageView.RequestedOperation;
```

## -see-also
[DataPackageOperation](datapackageoperation.md)
