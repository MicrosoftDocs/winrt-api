---
-api-id: P:Windows.UI.Xaml.UIElement.CanDrag
-api-type: winrt property
---

<!-- Property syntax
public bool CanDrag { get;  set; }
-->

# Windows.UI.Xaml.UIElement.CanDrag

## -description
Gets or sets a value that indicates whether the element can be dragged as data in a drag-and-drop operation.



## -property-value
**true** if the element can be dragged as data in a drag-and-drop operation; otherwise, **false**. The default is **false**.
## -remarks
<!--* If the value of CanDrag is set after DragStarting event is raised, that value does not come into effect until the next Drag operation i.e. until the next DragStarting event is raised.

* If CanDrag is set to true, during or before DropCompleted is raised, but after the DragStarting event, then the DropCompleted event should not be raised. 

* If CanDrag is set to true, but the app does not handle the DragStarting event, then the Drag operation is cancelled 
-->

## -examples

## -see-also

[Drag and drop overview](/windows/uwp/design/input/drag-and-drop), [Drag and drop sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlDragAndDrop)
