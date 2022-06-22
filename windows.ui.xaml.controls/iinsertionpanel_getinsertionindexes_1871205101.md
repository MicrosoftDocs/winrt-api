---
-api-id: M:Windows.UI.Xaml.Controls.IInsertionPanel.GetInsertionIndexes(Windows.Foundation.Point,System.Int32@,System.Int32@)
-api-type: winrt method
---

<!-- Method syntax
public void GetInsertionIndexes(Windows.Foundation.Point position, System.Int32 first, System.Int32 second)
-->

# Windows.UI.Xaml.Controls.IInsertionPanel.GetInsertionIndexes

## -description
Returns the index values of the items that the specified point is between.


## -parameters
### -param position
The point for which to get insertion indexes.

### -param first
The index of the item before the specified point.

### -param second
The index of the item after the specified point.

## -remarks
Call this method when handling a [DragOver](../windows.ui.xaml/uielement_dragover.md) event to return the indices of the two items between which the [DragOver](../windows.ui.xaml/uielement_dragover.md) is happening and where a potential drop and insertion would happen.

## -examples

## -see-also
