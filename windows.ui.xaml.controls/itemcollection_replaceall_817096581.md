---
-api-id: M:Windows.UI.Xaml.Controls.ItemCollection.ReplaceAll(System.Object[])
-api-type: winrt method
---

<!-- Method syntax
public void ReplaceAll(System.Object[] items)
-->

# Windows.UI.Xaml.Controls.ItemCollection.ReplaceAll

## -description
Initially clears the collection, then inserts the provided array as new items.



## -parameters
### -param items
The new collection items.

## -remarks
For implementations that track a "changed" event, the initial reset fires an event, but the items added don't fire discrete per-item events.

## -examples

## -see-also
