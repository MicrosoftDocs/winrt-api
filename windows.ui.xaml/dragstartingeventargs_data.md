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

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.DragStartingEventArgs.Data](/windows/winui/api/microsoft.ui.xaml.dragstartingeventargs.data) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -property-value
The data payload. The default is an empty [DataPackage](../windows.applicationmodel.datatransfer/datapackage.md).

## -remarks
In your [DragStarting](uielement_dragstarting.md) event handler, use the [DataPackage.SetData](../windows.applicationmodel.datatransfer/datapackage_setdata_2074524277.md) method to provide the data being dragged.

## -examples

## -see-also

[Drag-and-drop overview](/windows/uwp/design/input/drag-and-drop)
