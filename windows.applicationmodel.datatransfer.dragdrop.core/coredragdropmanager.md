---
-api-id: T:Windows.ApplicationModel.DataTransfer.DragDrop.Core.CoreDragDropManager
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class CoreDragDropManager : Windows.ApplicationModel.DataTransfer.DragDrop.Core.ICoreDragDropManager
-->

# Windows.ApplicationModel.DataTransfer.DragDrop.Core.CoreDragDropManager

## -description

Manages access for drag and drop within and between apps.

## -remarks

## -examples

The following example demonstrates how to use the `CoreDragDropManager` to set up a drag-and-drop target that filters incoming data and delegates handling to a specified control.

```csharp
using System;
using Windows.ApplicationModel.DataTransfer;
using Windows.ApplicationModel.DataTransfer.DragDrop.Core;
using Windows.UI.Xaml.Controls;

public sealed partial class MainPage : Page
{
    private void DropOperationTargetRequested(CoreDragDropManager sender, CoreDropOperationTargetRequestedEventArgs evtArgs)
    {
        // Create a target (see above for more implementation details)
        var target = new DropTarget();

        // Example filter: Only allow storage files
        target.DragOver += (s, e) =>
        {
            if (e.DataView.Contains(StandardDataFormats.StorageItems))
            {
                e.AcceptedOperation = DataPackageOperation.Copy;
            }
            else
            {
                e.AcceptedOperation = DataPackageOperation.None;
            }
        };

        // Delegate handling to a specified control
        target.Drop += (s, e) =>
        {
            // Assuming 'specifiedControl' is a UI element in your app
            specifiedControl.HandleDrop(e);
        };

        evtArgs.SetTarget(target);
    }

    public MainPage()
    {
        InitializeComponent();
        var dragDropManager = CoreDragDropManager.GetForCurrentView();
        dragDropManager.TargetRequested += DropOperationTargetRequested;
    }
}

// Example of a specified control handling the drop
public class SpecifiedControl
{
    public void HandleDrop(CoreDragInfo dragInfo)
    {
        // Handle the drop operation here
    }
}
```

## -see-also
