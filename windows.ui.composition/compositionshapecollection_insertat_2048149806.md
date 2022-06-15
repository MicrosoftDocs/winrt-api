---
-api-id: M:Windows.UI.Composition.CompositionShapeCollection.InsertAt(System.UInt32,Windows.UI.Composition.CompositionShape)
-api-type: winrt method
---

<!-- Method syntax.
public void CompositionShapeCollection.InsertAt(UInt32 index, CompositionShape value)
-->

# Windows.UI.Composition.CompositionShapeCollection.InsertAt

## -description

Inserts the specified item at the specified index.

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Composition.CompositionShapeCollection.InsertAt](/windows/winui/api/microsoft.ui.composition.compositionshapecollection.insertat) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -parameters
### -param index

The zero-based index at which to insert the item.

### -param value

The object to insert into the collection.

## -remarks

InsertAt expands the collection and moves all subsequent index items by one.

In contrast, SetAt replaces the item at the index, and the collection count remains the same.

## -see-also

## -examples

