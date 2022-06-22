---
-api-id: M:Windows.UI.Xaml.Controls.UIElementCollection.Move(System.UInt32,System.UInt32)
-api-type: winrt method
---

<!-- Method syntax
public void Move(System.UInt32 oldIndex, System.UInt32 newIndex)
-->

# Windows.UI.Xaml.Controls.UIElementCollection.Move

## -description
Moves the item at the specified index to a new location in the collection.



## -parameters
### -param oldIndex
The zero-based index specifying the location of the item to be moved.

### -param newIndex
The zero-based index specifying the new location of the item.

## -remarks
Calling this method offers advantages over removing an item and adding it to a new location. Specifically, not as much tree rebuilding is required internally, and panels or controls that use [UIElementCollection](uielementcollection.md) for items can be more responsive.

An example of a scenario where using Move may be useful is if you have a collection view or a specialized panel that supports a user experience where items wrap around. In this case you might want to move an item from the start of the collection to the end or vice versa, without forcing the entire visual tree under the panel or view to be rebuilt.

## -examples

## -see-also
