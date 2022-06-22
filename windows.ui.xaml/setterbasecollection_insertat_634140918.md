---
-api-id: M:Windows.UI.Xaml.SetterBaseCollection.InsertAt(System.UInt32,Windows.UI.Xaml.SetterBase)
-api-type: winrt method
---

<!-- Method syntax
public void InsertAt(System.UInt32 index, Windows.UI.Xaml.SetterBase value)
-->

# Windows.UI.Xaml.SetterBaseCollection.InsertAt

## -description
Inserts the specified item at the specified index.



## -parameters
### -param index
The index at which to set the value.

### -param value
The value to set.

## -remarks
InsertAt expands the collection and moves all subsequent index items by one. In contrast, [SetAt](setterbasecollection_setat_1418942598.md) replaces the item at the index, and the collection count remains the same.



> [!NOTE]
> The equivalent Microsoft .NET API is [Insert](/dotnet/api/system.collections.objectmodel.collection-1.insert).

## -examples

## -see-also
[Insert](/dotnet/api/system.collections.objectmodel.collection-1.insert)
