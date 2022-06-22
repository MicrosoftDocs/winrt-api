---
-api-id: M:Windows.UI.Xaml.Controls.UIElementCollection.ReplaceAll(Windows.UI.Xaml.UIElement[])
-api-type: winrt method
---

<!-- Method syntax
public void ReplaceAll(Windows.UI.Xaml.UIElement[] items)
-->

# Windows.UI.Xaml.Controls.UIElementCollection.ReplaceAll

## -description
Initially clears the collection, then inserts the provided array as new items.



## -parameters
### -param items
The new collection items.

## -remarks
For implementations that track a "changed" event, the initial reset fires an event, but the items added do not fire discrete per-item events.

If you are programming using C# or Microsoft Visual Basic, there is no single-call equivalent to ReplaceAll. Use [Clear](uielementcollection_clear_556466.md) and then successive calls to [Add](/dotnet/api/system.collections.generic.icollection-1.add?view=dotnet-uwp-10.0&preserve-view=true).

## -examples

## -see-also
[Clear](uielementcollection_clear_556466.md)
