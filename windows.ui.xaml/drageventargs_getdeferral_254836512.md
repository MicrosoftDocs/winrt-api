---
-api-id: M:Windows.UI.Xaml.DragEventArgs.GetDeferral
-api-type: winrt method
---

<!-- Method syntax
public Windows.UI.Xaml.DragOperationDeferral GetDeferral()
-->

# Windows.UI.Xaml.DragEventArgs.GetDeferral

## -description
Supports asynchronous drag-and-drop operations by creating and returning a [DragOperationDeferral](dragoperationdeferral.md) object.



## -returns
A deferral object that you can use to identify when the generation of the data package is complete.

## -remarks
The GetDeferral method allows your app to call a function during a drag-and-drop operation, so that your app can asynchronously generate the [DataPackage](../windows.applicationmodel.datatransfer/datapackage.md) object for the target app.


<!--Same behavior as DataRequest.GetDeferral?-->

## -examples

## -see-also

[Drag-and-drop overview](/windows/uwp/design/input/drag-and-drop)
