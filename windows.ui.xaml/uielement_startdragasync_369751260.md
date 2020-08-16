---
-api-id: M:Windows.UI.Xaml.UIElement.StartDragAsync(Windows.UI.Input.PointerPoint)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.ApplicationModel.DataTransfer.DataPackageOperation> StartDragAsync(Windows.UI.Input.PointerPoint pointerPoint)
-->

# Windows.UI.Xaml.UIElement.StartDragAsync

## -description
Initiates a drag-and-drop operation.

## -parameters
### -param pointerPoint
The coordinates of the pointer where the user interacts with the screen, and where the drag visual is attached.

## -returns
A [DataPackageOperation](../windows.applicationmodel.datatransfer/datapackageoperation.md) value that indicates the type of drag-and-drop operation, and whether the operation was successful.

## -remarks
If you implement custom gesture detection to initiate a drag operation, you can call the StartDragAsync method to programmatically initiate a drag operation on any [UIElement](uielement.md). Calling this method results in the [DragStarting](uielement_dragstarting.md) event being raised. Handle the [DragStarting](uielement_dragstarting.md) event to specify other properties of the operation, such as the data package and drag visual.

The *pointerPoint* parameter is the point at which the user interacts with the screen using an input device (touch, mouse, or pen). The drag visual that is shown during the drag operation is attached to the pointer indicated in the caller-provided [PointerPoint](../windows.ui.input/pointerpoint.md).

The [DataPackageOperation](../windows.applicationmodel.datatransfer/datapackageoperation.md) returned by this method indicates whether the drag operation is a move, copy, or link; and whether or not it's a success. This is the same value that's provided by the [DropResult](dropcompletedeventargs_dropresult.md) property in the [DropCompleted](uielement_dropcompleted.md) event args.


<!--Does it matter if CanDrag is false? (spec: Setting the CanDrag property on a UIElement allows the user to initiate a drag operation.  The DragAsync method similarly allows the application to initiate a drag operation...)-->

## -examples
This example shows how to handle the [PointerPressed](uielement_pointerpressed.md) event on an [Image](../windows.ui.xaml.controls/image.md) element to initiate a drag operation.

```xaml
<Image x:Name="myImage" Source="ms-appx:///Assets/Logo.png" 
       PointerPressed="myImage_PointerPressed" />
```

```csharp
private async void myImage_PointerPressed(object sender, PointerRoutedEventArgs e)
{
    var pointerPoint = e.GetCurrentPoint(sender as UIElement);
    var dropStatus = await myImage.StartDragAsync(pointerPoint);
    if (dropStatus == DataPackageOperation.Move)
    {
        // App specific code for a "move" operation.
    }
}
```



## -see-also
[DragStarting](uielement_dragstarting.md), [CanDrag](uielement_candrag.md), [Drag and drop sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlDragAndDrop)
