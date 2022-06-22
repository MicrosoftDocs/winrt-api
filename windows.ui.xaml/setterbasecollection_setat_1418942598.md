---
-api-id: M:Windows.UI.Xaml.SetterBaseCollection.SetAt(System.UInt32,Windows.UI.Xaml.SetterBase)
-api-type: winrt method
---

<!-- Method syntax
public void SetAt(System.UInt32 index, Windows.UI.Xaml.SetterBase value)
-->

# Windows.UI.Xaml.SetterBaseCollection.SetAt

## -description
Sets the value at the specified index to the [SetterBase](setterbase.md) value specified.



## -parameters
### -param index
The index at which to set the value.

### -param value
The value to set.

## -remarks
[InsertAt](setterbasecollection_insertat_634140918.md) expands the collection and moves all subsequent index items by one. In contrast, SetAt replaces the item at the index, and the collection count remains the same.



> [!NOTE]
> The equivalent Microsoft .NET API is [Item](/dotnet/api/system.collections.objectmodel.collection-1.item) (the indexer).

## -examples

## -see-also
[Item](/dotnet/api/system.collections.objectmodel.collection-1.item)
