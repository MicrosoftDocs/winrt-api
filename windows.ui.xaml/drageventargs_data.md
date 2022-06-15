---
-api-id: P:Windows.UI.Xaml.DragEventArgs.Data
-api-type: winrt property
---

<!-- Property syntax
public Windows.ApplicationModel.DataTransfer.DataPackage Data { get;  set; }
-->

# Windows.UI.Xaml.DragEventArgs.Data

## -description
Gets or sets a data object ([DataPackage](../windows.applicationmodel.datatransfer/datapackage.md)) that contains the data associated with the corresponding drag event. This value is not useful in all event cases; specifically, the event must be handled by a valid drop target.

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.DragEventArgs.Data](/windows/winui/api/microsoft.ui.xaml.drageventargs.data) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -property-value
The data object that contains data payload that is associated with the corresponding drag event.

## -remarks

## -examples

## -see-also
[Drag-and-drop overview](/windows/uwp/design/input/drag-and-drop), [ListViewBase](../windows.ui.xaml.controls/listviewbase.md), [AllowDrop](uielement_allowdrop.md), [UIElement.Drop](uielement_drop.md)
