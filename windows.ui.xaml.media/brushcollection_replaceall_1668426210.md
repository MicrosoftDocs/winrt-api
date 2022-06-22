---
-api-id: M:Windows.UI.Xaml.Media.BrushCollection.ReplaceAll(Windows.UI.Xaml.Media.Brush[])
-api-type: winrt method
---

<!-- Method syntax
public void ReplaceAll(Windows.UI.Xaml.Media.Brush[] items)
-->

# Windows.UI.Xaml.Media.BrushCollection.ReplaceAll

## -description
Initially clears the collection, then inserts the provided array as new items.



## -parameters
### -param items
The new collection items.

## -remarks
For implementations that track a "changed" event, the initial reset fires an event, but the items added do not fire discrete events.

## -examples

## -see-also
