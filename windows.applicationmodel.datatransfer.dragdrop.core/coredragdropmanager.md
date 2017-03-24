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
```csharp
public sealed partial class MainPage : Page
{
      private void DropOperationTargetRequested(CoreDragDropManager sender, 
            CoreDropOperationTargetRequestedEventArgs evtArgs)
      {
            // Create a target (see above for more implementation details)
            var target = new DropTarget ();
            evtArgs.SetTarget(target);
      }
      
      public MainPage()
      {                           
            InitializeComponents();
            var dragDropManager = DragDropManager.GetForCurrentView();
            dragDropManager.DropOperationTargetRequested += DropOperationTargetRequested;
      }
}

```



## -see-also
