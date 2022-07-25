---
-api-id: T:Windows.UI.Xaml.Interop.NotifyCollectionChangedAction
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Xaml.Interop.NotifyCollectionChangedAction : int
-->

# NotifyCollectionChangedAction

## -description
Describes the action that caused a [CollectionChanged](inotifycollectionchanged_collectionchanged.md) event.



> **.NET**
> This type appears as [System.Collections.Specialized.NotifyCollectionChangedAction](/dotnet/api/system.collections.specialized.notifycollectionchangedaction?view=dotnet-uwp-10.0&preserve-view=true).



## -enum-fields
### -field Add:0
One or more items were added to the collection.

### -field Remove:1
One or more items were removed from the collection.

### -field Replace:2
One or more items were replaced in the collection.

### -field Move:3
One or more items were moved within the collection.

### -field Reset:4
The content of the collection changed dramatically.


## -remarks
When programming with .NET, this type is hidden and developers should use the [System.Collections.Specialized.NotifyCollectionChangedAction](/dotnet/api/system.collections.specialized.notifycollectionchangedaction?view=dotnet-uwp-10.0&preserve-view=true) type.

## -examples

## -see-also
[XAML data binding sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlBind)
